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
    public partial class Cprofile : Form
    {
        private int clientId;

        public Cprofile(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MRequestbtn_Click(object sender, EventArgs e)
        {
            Crequest cr = new Crequest(clientId);
            cr.Show();
            this.Hide();
        }

        private void Tasksbtn_Click(object sender, EventArgs e)
        {
            Ctasks ct = new Ctasks(clientId);
            ct.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cprofile_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RVAMH25;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT NAME, Email, Phone, payment_info, Address FROM dbo.Client WHERE Client_ID = @ClientID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ClientID", clientId);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Text = reader["NAME"]?.ToString();
                        textBox2.Text = reader["Email"]?.ToString();
                        textBox3.Text = reader["Phone"]?.ToString();
                        textBox4.Text = reader["payment_info"]?.ToString();
                        textBox5.Text = reader["Address"]?.ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RVAMH25;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE dbo.Client 
                 SET NAME = @Name, Email = @Email, Phone = @Phone, 
                     payment_info = @PaymentInfo, Address = @Address 
                 WHERE Client_ID = @ClientID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(textBox3.Text) ? DBNull.Value : (object)textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@PaymentInfo", string.IsNullOrWhiteSpace(textBox4.Text) ? DBNull.Value : (object)textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(textBox5.Text) ? DBNull.Value : (object)textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientID", clientId);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No changes made.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignIn loginForm = new SignIn();
            loginForm.Show();
            this.Close();
        }
    }
}
