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
    public partial class wChoceArea : Form
    {
        private const string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int workerId;
        private List<Button> areaButtons = new List<Button>();
        private List<string> selectedAreas = new List<string>();
        public wChoceArea(int workerid)
        {
            this.workerId = workerid;
            InitializeComponent();
            InitializeAreaButtons();
            SetupDataGridView();
            LoadWorkerAreas();
        }
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("WorkerAreaID", "Worker Area ID");
            dataGridView1.Columns.Add("AreaName", "Area Name");

            int totalWidth = dataGridView1.Width - 4;
            dataGridView1.Columns["WorkerAreaID"].Width = (int)(totalWidth * 0.3);
            dataGridView1.Columns["AreaName"].Width = (int)(totalWidth * 0.7);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void InitializeAreaButtons()
        {
            areaButtons.Add(button7);  // Dokie
            areaButtons.Add(button8);  // Giza
            areaButtons.Add(button9);  // Zamalek
            areaButtons.Add(button10); // 6'October
            areaButtons.Add(button14); // Zaid
            areaButtons.Add(button13); // Hossary
            areaButtons.Add(button12); // Fessal
            areaButtons.Add(button11); // Agozza

            foreach (var button in areaButtons)
            {
                button.Click += AreaButton_Click;
            }
        }
        private void AreaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == Color.LightSeaGreen)
            {
                clickedButton.BackColor = Color.Crimson;
                selectedAreas.Add(clickedButton.Text);
            }
            else
            {
                clickedButton.BackColor = Color.LightSeaGreen;
                selectedAreas.Remove(clickedButton.Text);
            }
        }
        private void LoadWorkerAreas()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = @"
                    SELECT wsa.WorkerArea_ID, sa.Area_Name 
                    FROM Worker_Service_Area wsa
                    JOIN Service_Area sa ON wsa.Area_ID = sa.Area_ID
                    WHERE wsa.Worker_ID = @WorkerID";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WorkerID", workerId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["WorkerArea_ID"].ToString(),
                                    reader["Area_Name"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string workerAreaId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(workerAreaId, out int id))
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        try
                        {
                            sqlCon.Open();
                            string query = "DELETE FROM Worker_Service_Area WHERE Worker_ID = @WorkerID AND WorkerArea_ID = @WorkerAreaID";
                            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@WorkerID", workerId);
                                cmd.Parameters.AddWithValue("@WorkerAreaID", id);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Area deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadWorkerAreas();
                                }
                                else
                                {
                                    MessageBox.Show("No matching record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Worker Area ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an area to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Requestsbtn_Click(object sender, EventArgs e)
        {
            wRequest wRequests = new wRequest(workerId);
            wRequests.Show();
            this.Hide();
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots wTimeSlots = new wTimeSlots(workerId);
            wTimeSlots.Show();
            this.Hide();
        }

        private void Tasksbtn_Click(object sender, EventArgs e)
        {
            wTasks wTasks = new wTasks(workerId);
            wTasks.Show();
            this.Hide();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            wUserProfile wUserProfile = new wUserProfile(workerId);
            wUserProfile.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }
    }
}