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
    public partial class Ctasks : Form
    {
        private string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private Dictionary<string, float> ratingDict = new Dictionary<string, float>
        {
            { "Excellent", 0.7f },
            { "Very Good", 0.6f },
            { "Good", 0.4f },
            { "Bad", 0.1f },
            { "Very Bad", -0.1f }
        };
        public Ctasks()
        {
            InitializeComponent();
            SetupControls();
            LoadTasks();
        }
        private void SetupControls()
        {
            
            StyleDataGridView();

            // Handle row selection to enable/disable controls
            dgvTasks.SelectionChanged += (s, e) =>
            {
                if (dgvTasks.SelectedRows.Count > 0)
                {
                    btnDelete.Enabled = true;
                    cmbStatus.Enabled = true;
                    var status = dgvTasks.SelectedRows[0].Cells["Status"].Value.ToString();
                    cmbStatus.SelectedItem = status;
                    UpdateRatingControl(status);
                }
                else
                {
                    btnDelete.Enabled = false;
                    cmbStatus.Enabled = false;
                    cmbRating.Enabled = false;
                }
            };
        }
        private void StyleDataGridView()
        {
            // Style the DataGridView
            dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvTasks.EnableHeadersVisualStyles = false;

            dgvTasks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvTasks.DefaultCellStyle.BackColor = Color.White;
            dgvTasks.DefaultCellStyle.ForeColor = Color.Black;
            dgvTasks.DefaultCellStyle.Font = new Font("Verdana", 9);
        }
        private void LoadTasks()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT TaskId, Taskname, required_specialty, Average_Time_Needed, Average_Task_Fee, Status FROM dbo.Task";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvTasks.DataSource = dt;

                        // Rename columns for better display
                        dgvTasks.Columns["Taskname"].HeaderText = "Task Name";
                        dgvTasks.Columns["Required_Speciality"].HeaderText = "Speciality";
                        dgvTasks.Columns["Average_Time_Needed"].HeaderText = "Avg Time (hrs)";
                        dgvTasks.Columns["Average_Task_Fee"].HeaderText = "Avg Fee";
                        dgvTasks.Columns["Status"].HeaderText = "Status";

                        // Hide TaskId column (used for deletion but not displayed)
                        dgvTasks.Columns["TaskId"].Visible = false;
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
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MRequestbtn_Click(object sender, EventArgs e)
        {
            int clientId = 1;
            Crequest cr = new Crequest(clientId);
            cr.Show();
            this.Hide();
        }

        private void UProfilebtn_Click(object sender, EventArgs e)
        {
            Cprofile cp = new Cprofile();
            cp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskId"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlCon.Open();

                        // Delete from dbo.Requests
                        string deleteRequestQuery = "DELETE FROM dbo.Requests WHERE Task_ID = @TaskId";
                        using (SqlCommand cmd = new SqlCommand(deleteRequestQuery, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@TaskId", taskId);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from dbo.Task
                        string deleteTaskQuery = "DELETE FROM dbo.Task WHERE TaskId = @TaskId";
                        using (SqlCommand cmd = new SqlCommand(deleteTaskQuery, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@TaskId", taskId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTasks(); // Refresh the grid
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0) return;

            int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskId"].Value);
            string newStatus = cmbStatus.SelectedItem.ToString();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string updateQuery = "UPDATE dbo.Task SET Status = @Status WHERE TaskId = @TaskId";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@TaskId", taskId);
                        cmd.ExecuteNonQuery();
                    }

                    // Refresh the grid
                    LoadTasks();

                    // Update rating control based on new status
                    UpdateRatingControl(newStatus);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateRatingControl(string status)
        {
            if (status == "Finished")
            {
                cmbRating.Enabled = true;
            }
            else
            {
                cmbRating.Enabled = false;
                cmbRating.SelectedIndex = -1; // Clear selection
            }
        }

        private void CmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0 || cmbRating.SelectedItem == null) return;

            int taskId = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskId"].Value);
            string selectedRating = cmbRating.SelectedItem.ToString();
            float ratingValue = ratingDict[selectedRating];

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string updateQuery = "UPDATE dbo.Requests SET Worker_Rating = @Rating WHERE Task_ID = @TaskId";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Rating", ratingValue);
                        cmd.Parameters.AddWithValue("@TaskId", taskId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Worker rated as {selectedRating} ({ratingValue})!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ctasks_Load(object sender, EventArgs e)
        {

        }
    }
}

