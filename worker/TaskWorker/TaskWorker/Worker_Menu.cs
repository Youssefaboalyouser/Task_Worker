
//====================================================================================================================================================

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
    public partial class wRequest : Form
    {
        private int workerId; // Set dynamically based on the logged-in worker
        private string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public wRequest(int workerId)
        {
            this.workerId = workerId;
            InitializeComponent();
            SetupDataGridView(); // Set up DataGridView design
            LoadTasks();
            button7.Click += button7_Click; // Assign click event to Apply button
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TaskID", "Task ID");
            dataGridView1.Columns.Add("TaskName", "Task Name");
            dataGridView1.Columns.Add("Specialty", "Specialty");
            dataGridView1.Columns.Add("Area", "Area");
            dataGridView1.Columns.Add("MinimumRate", "Minimum Rate");
            dataGridView1.Columns.Add("PreferredTimeSlot", "Preferred Time Slot");

            // Fit columns to grid width
            int totalWidth = dataGridView1.Width - 4; // Subtract a small buffer for borders
            dataGridView1.Columns["TaskID"].Width = (int)(totalWidth * 0.15);
            dataGridView1.Columns["TaskName"].Width = (int)(totalWidth * 0.25);
            dataGridView1.Columns["Specialty"].Width = (int)(totalWidth * 0.15);
            dataGridView1.Columns["Area"].Width = (int)(totalWidth * 0.15);
            dataGridView1.Columns["MinimumRate"].Width = (int)(totalWidth * 0.15);
            dataGridView1.Columns["PreferredTimeSlot"].Width = (int)(totalWidth * 0.15);

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

        private void LoadTasks()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    // Get worker's profile data with DISTINCT Area_ID
                    string workerQuery = @"
                        SELECT w.Specialty_Name, 
                               (SELECT STRING_AGG(CAST(Area_ID AS NVARCHAR(MAX)), ',') 
                                FROM Worker_Service_Area wsa 
                                WHERE wsa.Worker_ID = w.Worker_ID 
                                GROUP BY wsa.Worker_ID) AS Area_IDs,
                               COALESCE((SELECT AVG(CAST(Worker_Rating AS FLOAT)) 
                                         FROM dbo.Requests r 
                                         WHERE r.Worker_ID = w.Worker_ID AND r.Worker_Rating IS NOT NULL), 0) AS Worker_Rating,
                               wa.Start_Time, wa.End_Time
                        FROM dbo.Worker w
                        LEFT JOIN Worker_Availability wa ON w.Worker_ID = wa.Worker_ID
                        WHERE w.Worker_ID = @WorkerID";
                    using (SqlCommand cmdWorker = new SqlCommand(workerQuery, sqlCon))
                    {
                        cmdWorker.Parameters.AddWithValue("@WorkerID", workerId);
                        using (SqlDataReader reader = cmdWorker.ExecuteReader())
                        {
                            List<DateTime> workerStartTimes = new List<DateTime>();
                            List<DateTime> workerEndTimes = new List<DateTime>();
                            List<int> areaIds = new List<int>();
                            string specialty = null;
                            float? workerRate = null;

                            while (reader.Read())
                            {
                                specialty = reader["Specialty_Name"]?.ToString();
                                workerRate = reader["Worker_Rating"] as float?;
                                if (reader["Start_Time"] != DBNull.Value && reader["End_Time"] != DBNull.Value)
                                {
                                    workerStartTimes.Add(reader.GetDateTime(reader.GetOrdinal("Start_Time")));
                                    workerEndTimes.Add(reader.GetDateTime(reader.GetOrdinal("End_Time")));
                                }

                                // Parse Area_IDs
                                string areaIdsStr = reader["Area_IDs"]?.ToString();
                                if (!string.IsNullOrEmpty(areaIdsStr))
                                {
                                    areaIds = areaIdsStr.Split(',')
                                        .Select(x => int.Parse(x.Trim()))
                                        .Distinct()
                                        .ToList();
                                }
                            }
                            reader.Close();

                            if (specialty != null && areaIds.Count > 0 && workerStartTimes.Count > 0)
                            {
                                string taskQuery = @"
                                    SELECT t.TaskId, t.taskname, t.required_specialty, sa.Area_Name, 
                                           r.MinimumRate_Required, r.Prefered_Time_Slot
                                    FROM dbo.Task t
                                    JOIN dbo.Requests r ON t.TaskId = r.Task_ID
                                    JOIN dbo.Service_Area sa ON r.Area_ID = sa.Area_ID
                                    WHERE t.Status = 'Need Worker'
                                    AND r.Worker_ID IS NULL
                                    AND t.required_specialty = @Specialty
                                    AND r.Area_ID IN ({0})
                                    AND (r.MinimumRate_Required = 0 OR r.MinimumRate_Required <= @WorkerRate OR r.MinimumRate_Required IS NULL)";

                                string[] paramNames = areaIds.Select((_, i) => $"@AreaID{i}").ToArray();
                                taskQuery = string.Format(taskQuery, string.Join(",", paramNames));

                                using (SqlCommand cmdTask = new SqlCommand(taskQuery, sqlCon))
                                {
                                    cmdTask.Parameters.AddWithValue("@Specialty", specialty);
                                    cmdTask.Parameters.AddWithValue("@WorkerRate", workerRate ?? 0);
                                    for (int i = 0; i < areaIds.Count; i++)
                                    {
                                        cmdTask.Parameters.AddWithValue($"@AreaID{i}", areaIds[i]);
                                    }

                                    using (SqlDataReader taskReader = cmdTask.ExecuteReader())
                                    {
                                        while (taskReader.Read())
                                        {
                                            string taskId = taskReader["TaskId"].ToString();
                                            string taskName = taskReader["taskname"].ToString();
                                            string requiredSpecialty = taskReader["required_specialty"].ToString();
                                            string areaName = taskReader["Area_Name"].ToString();
                                            float minimumRateRequired = taskReader["MinimumRate_Required"] != DBNull.Value
                                                ? Convert.ToSingle(taskReader["MinimumRate_Required"])
                                                : 0;
                                            string preferredTimeSlot = taskReader["Prefered_Time_Slot"].ToString();

                                            bool timeMatch = false;
                                            string[] timeSlots = preferredTimeSlot.Split(new[] { "&" }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(x => x.Trim())
                                                .ToArray();
                                            foreach (string slot in timeSlots)
                                            {
                                                if (IsTimeOverlap(slot, workerStartTimes, workerEndTimes))
                                                {
                                                    timeMatch = true;
                                                    break;
                                                }
                                            }

                                            bool rateMatch = minimumRateRequired == 0 || !workerRate.HasValue || minimumRateRequired <= workerRate.Value;

                                            if (timeMatch && rateMatch)
                                            {
                                                dataGridView1.Rows.Add(
                                                    taskId,
                                                    taskName,
                                                    requiredSpecialty,
                                                    areaName,
                                                    minimumRateRequired.ToString("F2"),
                                                    preferredTimeSlot
                                                );
                                            }
                                        }
                                        dataGridView1.Refresh(); // Force refresh
                                    }
                                }
                            }
                            else
                            {
                                label3.Text = "Please complete your profile (specialty, service areas, time slots) to see available tasks.";
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsTimeOverlap(string preferredTimeSlot, List<DateTime> workerStartTimes, List<DateTime> workerEndTimes)
        {
            try
            {
                string[] timeRange = preferredTimeSlot.Split(new[] { " : " }, StringSplitOptions.None);
                if (timeRange.Length != 2)
                {
                    return false;
                }

                DateTime preferredStart = DateTime.Parse($"{DateTime.Today.ToShortDateString()} {timeRange[0]}");
                DateTime preferredEnd = DateTime.Parse($"{DateTime.Today.ToShortDateString()} {timeRange[1]}");

                for (int i = 0; i < workerStartTimes.Count; i++)
                {
                    DateTime workerStartTime = DateTime.Today.Add(workerStartTimes[i].TimeOfDay);
                    DateTime workerEndTime = DateTime.Today.Add(workerEndTimes[i].TimeOfDay);

                    bool overlap = !(workerEndTime <= preferredStart || workerStartTime >= preferredEnd);
                    if (overlap)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TaskID"].Value);
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlCon.Open();
                        // Check if worker has already applied for this task
                        string checkQuery = "SELECT COUNT(*) FROM dbo.Requests WHERE Task_ID = @TaskID AND Worker_ID = @WorkerID";
                        using (SqlCommand cmdCheck = new SqlCommand(checkQuery, sqlCon))
                        {
                            cmdCheck.Parameters.AddWithValue("@TaskID", taskId);
                            cmdCheck.Parameters.AddWithValue("@WorkerID", workerId);
                            int count = (int)cmdCheck.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("You have already applied for this task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        using (SqlTransaction transaction = sqlCon.BeginTransaction())
                        {
                            try
                            {
                                string updateTaskQuery = "UPDATE dbo.Task SET Status = 'Working on' WHERE TaskId = @TaskID AND Status = 'Need Worker'";
                                using (SqlCommand cmdTask = new SqlCommand(updateTaskQuery, sqlCon, transaction))
                                {
                                    cmdTask.Parameters.AddWithValue("@TaskID", taskId);
                                    int taskRowsAffected = cmdTask.ExecuteNonQuery();
                                    if (taskRowsAffected == 0)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Task is no longer available or already assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }

                                string updateRequestQuery = "UPDATE dbo.Requests SET Worker_ID = @WorkerID WHERE Task_ID = @TaskID AND Worker_ID IS NULL";
                                using (SqlCommand cmdRequest = new SqlCommand(updateRequestQuery, sqlCon, transaction))
                                {
                                    cmdRequest.Parameters.AddWithValue("@WorkerID", workerId);
                                    cmdRequest.Parameters.AddWithValue("@TaskID", taskId);
                                    int requestRowsAffected = cmdRequest.ExecuteNonQuery();
                                    if (requestRowsAffected == 0)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Task is already assigned or no longer available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }

                                transaction.Commit();
                                MessageBox.Show("Application successful! Task is now 'Working on'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Keep the task in DataGridView as per new requirement
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to apply.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots timeSlots = new wTimeSlots(workerId);
            timeSlots.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void Worker_Menu_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}