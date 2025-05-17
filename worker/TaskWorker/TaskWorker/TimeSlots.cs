

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
    public partial class wTimeSlots : Form
    {
        private const string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int workerId; // This should be set dynamically based on the logged-in worker
        private List<Button> timeButtons = new List<Button>();
        private List<string> selectedTimes = new List<string>();

        public wTimeSlots(int workerId)
        {
            this.workerId = workerId; // Set the workerId for this session
            InitializeComponent();
            InitializeTimeButtons();
            SetupDataGridView(); // Set up DataGridView design and columns
            LoadTimeSlots();
        }

        private void SetupDataGridView()
        {
            // Clear any existing columns to avoid duplicates
            dataGridView1.Columns.Clear();

            // Define columns
            dataGridView1.Columns.Add("AvailabilityID", "Availability ID");
            dataGridView1.Columns.Add("StartTime", "Start Time");
            dataGridView1.Columns.Add("EndTime", "End Time");

            // Fit columns to grid width
            int totalWidth = dataGridView1.Width - 4; // Subtract a small buffer for borders
            dataGridView1.Columns["AvailabilityID"].Width = (int)(totalWidth * 0.3); // 30% for ID
            dataGridView1.Columns["StartTime"].Width = (int)(totalWidth * 0.35); // 35% for Start Time
            dataGridView1.Columns["EndTime"].Width = (int)(totalWidth * 0.35); // 35% for End Time

            // Enhance design
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

        private void InitializeTimeButtons()
        {
            timeButtons.Add(button7);  // 8 AM: 10 AM
            timeButtons.Add(button8);  // 11 AM: 1 PM
            timeButtons.Add(button9);  // 2 PM: 4 PM
            timeButtons.Add(button10); // 5 PM: 7 PM
            timeButtons.Add(button14); // 8 PM: 10 PM
            timeButtons.Add(button13); // 11 PM: 1 AM
            timeButtons.Add(button12); // 3 AM: 5 AM
            timeButtons.Add(button11); // 6 AM: 8 AM

            foreach (var button in timeButtons)
            {
                button.Click += TimeButton_Click;
            }
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == Color.LightSeaGreen)
            {
                clickedButton.BackColor = Color.Crimson;
                selectedTimes.Add(clickedButton.Text);
            }
            else
            {
                clickedButton.BackColor = Color.LightSeaGreen;
                selectedTimes.Remove(clickedButton.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e) // Add button
        {
            if (selectedTimes.Count == 0)
            {
                MessageBox.Show("Please select at least one time slot.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    foreach (string timeSlot in selectedTimes)
                    {
                        string[] times = timeSlot.Split(':');
                        string startStr = times[0].Trim();
                        string endStr = times[1].Trim();

                        DateTime startTime = DateTime.Parse(startStr);
                        DateTime endTime = DateTime.Parse(endStr);
                        Random random = new Random();
                        int availabilityId = random.Next(1, 1000000);

                        string query = "INSERT INTO Worker_Availability (Availability_ID, Worker_ID, Start_Time, End_Time) VALUES (@AvailabilityID, @WorkerID, @StartTime, @EndTime)";
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@AvailabilityID", availabilityId);
                            cmd.Parameters.AddWithValue("@WorkerID", workerId);
                            cmd.Parameters.AddWithValue("@StartTime", startTime);
                            cmd.Parameters.AddWithValue("@EndTime", endTime);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Time slots added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTimeSlots();
                    button16_Click_1(sender, e); // Reset buttons
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTimeSlots()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT Availability_ID, Start_Time, End_Time FROM Worker_Availability WHERE Worker_ID = @WorkerID";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WorkerID", workerId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["Availability_ID"].ToString(),
                                    Convert.ToDateTime(reader["Start_Time"]).ToString("h:mm tt"),
                                    Convert.ToDateTime(reader["End_Time"]).ToString("h:mm tt")
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

        

        private void Requestbtn_Click(object sender, EventArgs e)
        {
            wRequest request = new wRequest(this.workerId);
            request.Show();
            this.Hide();
        }

        private void Areabtn_Click(object sender, EventArgs e)
        {
            wChoceArea area = new wChoceArea(workerId);
            area.Show();
            this.Hide();
        }

        private void Tasksbtn_Click(object sender, EventArgs e)
        {
            wTasks tasks = new wTasks(workerId);
            tasks.Show();
            this.Hide();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            wUserProfile profile = new wUserProfile(workerId);
            profile.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            foreach (var button in timeButtons)
            {
                button.BackColor = Color.LightSeaGreen;
            }
            selectedTimes.Clear();
            MessageBox.Show("Selections canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string availabilityId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(availabilityId, out int id))
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        try
                        {
                            sqlCon.Open();
                            string query = "DELETE FROM Worker_Availability WHERE Worker_ID = @WorkerID AND Availability_ID = @AvailabilityID";
                            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                            {
                                cmd.Parameters.AddWithValue("@WorkerID", workerId);
                                cmd.Parameters.AddWithValue("@AvailabilityID", id);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Time slot deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadTimeSlots();
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
                    MessageBox.Show("Invalid Availability ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a time slot to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
