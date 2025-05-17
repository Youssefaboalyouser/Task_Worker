using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TaskWorker
{
    public partial class SignUp : Form
    {
        private const string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int workerId; // Assuming this is the ID for the worker

        public SignUp()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartForm sForm = new StartForm();
            sForm.Show();
            this.Hide();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Check if Password and Confirm match, and Password length <= 12
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Length < 12)
            {
                MessageBox.Show("Password must be 12 characters or more.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if a role is selected
            if (!rbStakeholder.Checked && !rbWorker.Checked)
            {
                MessageBox.Show("Please select a role (Stakeholder or Worker).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Store data based on role
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();

                    if (rbStakeholder.Checked)
                    {
                        string query = "INSERT INTO dbo.Client (NAME, Email, CPassKey) VALUES (@Name, @Email, @Password); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            int clientId = Convert.ToInt32(cmd.ExecuteScalar());
                            MessageBox.Show("Stakeholder registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Crequest cRequestForm = new Crequest(clientId);
                            cRequestForm.Show();
                            this.Hide();
                        }
                    }
                    else if (rbWorker.Checked)
                    {
                        string query = "INSERT INTO dbo.Worker (NAME, WPassKey) VALUES (@Name, @Password); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            workerId = Convert.ToInt32(cmd.ExecuteScalar()); // Get the newly inserted Worker_ID
                        }
                        MessageBox.Show("Worker registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        wTimeSlots timeSlotsForm = new wTimeSlots(workerId);
                        timeSlotsForm.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            rbStakeholder.Checked = false;
            rbWorker.Checked = false;
        }
    }
}
