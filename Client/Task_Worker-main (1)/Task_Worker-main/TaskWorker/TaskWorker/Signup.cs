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
        private const string connectionString = "Data Source=DESKTOP-RVAMH25;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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
                        // Insert into dbo.Client table
                        string query = "INSERT INTO dbo.Client (NAME, Email, CPassKey) VALUES (@Name, @Email, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Stakeholder registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string getIdQuery = "SELECT Client_ID FROM dbo.Client WHERE NAME = @Name AND Email = @Email";
                        using (SqlCommand getIdCmd = new SqlCommand(getIdQuery, sqlCon))
                        {
                            getIdCmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            getIdCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            object result = getIdCmd.ExecuteScalar();

                            if (result != null)
                            {
                                int clientId = Convert.ToInt32(result);
                                Cprofile cProfileForm = new Cprofile(clientId);
                                cProfileForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Failed to retrieve client ID after registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (rbWorker.Checked)
                    {
                        // Insert into dbo.Worker table
                        string query = "INSERT INTO dbo.Worker (NAME, WPassKey) VALUES (@Name, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Worker registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to wRequest form
                        wRequest wRequestForm = new wRequest();
                        wRequestForm.Show();
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
