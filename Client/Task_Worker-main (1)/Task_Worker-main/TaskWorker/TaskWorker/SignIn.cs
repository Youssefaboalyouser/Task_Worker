using Microsoft.Data.SqlClient;
using System.Data;

namespace TaskWorker
{
    public partial class SignIn : Form
    {
        private string connectionString = "Data Source=DESKTOP-RVAMH25;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartForm sForm = new StartForm();
            sForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            rbStakeholder.Checked = false;
            rbWorker.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if a role is selected
            if (!rbStakeholder.Checked && !rbWorker.Checked)
            {
                MessageBox.Show("Please select a role (Stakeholder or Worker).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();

                    if (rbStakeholder.Checked)
                    {
                        // Search in dbo.Client table and get Client_ID
                        string query = "SELECT Client_ID FROM dbo.Client WHERE NAME = @Name AND CPassKey = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                int clientId = Convert.ToInt32(result);

                                Cprofile profileForm = new Cprofile(clientId);
                                profileForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (rbWorker.Checked)
                    {
                        // Search in dbo.Worker table
                        string query = "SELECT COUNT(*) FROM dbo.Worker WHERE NAME = @Name AND WPassKey = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // Redirect to wRequest form
                                wRequest wRequestForm = new wRequest();
                                wRequestForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
