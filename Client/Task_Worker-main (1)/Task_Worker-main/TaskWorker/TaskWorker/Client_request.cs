
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TaskWorker
{
    public partial class Crequest : Form
    {
        private string connectionString = "Data Source=DESKTOP-RVAMH25;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private Dictionary<string, int> specialtyDict = new()
        {
            { "Cleaner", 1 },
            { "Mechanic", 2 },
            { "Welder", 3 },
            { "Mason", 4 },
            { "Painter", 5 },
            { "Electrician", 6 },
            { "Plumber", 7 },
            { "Carpenter", 8 }
        };

        private Dictionary<string, int> serviceAreaDict = new()
        {
            { "Zamalek", 1 },
            { "Dokie", 2 },
            { "Giza", 3 },
            { "Zaid", 4 },
            { "Fessal", 5 },
            { "Hossary", 6 },
            { "Agozza", 7 },
            { "6'October", 8 }
        };

        private int clientId;

        public Crequest(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;

            cmbSpecialty.Items.Clear();
            cmbSpecialty.Items.AddRange(specialtyDict.Keys.ToArray());

            cmbServiceArea.Items.Clear();
            cmbServiceArea.Items.AddRange(serviceAreaDict.Keys.ToArray());

            // Populate CheckedListBox for time slots
            lstTimeSlots.Items.Clear();
            lstTimeSlots.Items.AddRange(new string[]
            {
                "8 AM : 10 AM",
                "11 AM : 1 PM",
                "2 PM : 4 PM",
                "5 PM : 7 PM",
                "8 PM : 10 PM",
                "11 PM : 1 AM",
                "3 AM : 5 AM",
                "6 AM : 8 AM"
            });
        }

        private void Taskbtn_Click(object sender, EventArgs e)
        {
            Ctasks task = new Ctasks(clientId);
            task.Show();
            this.Hide();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            // 1. Ensure all fields are filled/selected
            if (string.IsNullOrWhiteSpace(txtRequestName.Text))
            {
                MessageBox.Show("Please enter a Request Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSpecialty.SelectedItem == null)
            {
                MessageBox.Show("Please select a Specialty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbServiceArea.SelectedItem == null)
            {
                MessageBox.Show("Please select a Service Area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMinimumRate.Text) || !float.TryParse(txtMinimumRate.Text, out float minimumRate))
            {
                MessageBox.Show("Please enter a valid Minimum Rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHourlyRate.Text) || !float.TryParse(txtHourlyRate.Text, out float hourlyRate))
            {
                MessageBox.Show("Please enter a valid Hourly Rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAverageTime.Text) || !float.TryParse(txtAverageTime.Text, out float averageTime))
            {
                MessageBox.Show("Please enter a valid Average Time Needed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstTimeSlots.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one Preferred Time Slot.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validate Minimum Rate
            if (minimumRate <= 0 || minimumRate > 5)
            {
                MessageBox.Show("Minimum Rate must be greater than 0 and less than or equal to 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Validate Hourly Rate and Average Time
            if (hourlyRate <= 0)
            {
                MessageBox.Show("Hourly Rate must be a positive value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (averageTime <= 0)
            {
                MessageBox.Show("Average Time Needed must be a positive value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Format Preferred Time Slots as a string
            string preferredTimeSlots = string.Join(" && ", lstTimeSlots.CheckedItems.Cast<string>());

            // Generate a random Task_ID
            Random random = new Random();
            int taskId = random.Next(1, 1000000);

            // Get Area_ID from dictionary
            int areaId = serviceAreaDict[cmbServiceArea.SelectedItem.ToString()];

            // Calculate Average Task Fee
            float averageTaskFee = averageTime * hourlyRate;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();

                    // 1. Insert into dbo.Task table first
                    string taskQuery = "INSERT INTO dbo.Task (TaskId, Taskname, required_specialty, Average_Time_Needed, Average_Task_Fee) " +
                                       "VALUES (@TaskId, @Taskname, @RequiredSpeciality, @AverageTimeNeeded, @AverageTaskFee)";
                    using (SqlCommand cmd = new SqlCommand(taskQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@TaskId", taskId);
                        cmd.Parameters.AddWithValue("@Taskname", txtRequestName.Text);
                        cmd.Parameters.AddWithValue("@RequiredSpeciality", cmbSpecialty.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@AverageTimeNeeded", averageTime);
                        cmd.Parameters.AddWithValue("@AverageTaskFee", averageTaskFee);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert into dbo.Requests table
                    string requestQuery = "INSERT INTO dbo.Requests (Request_Name, Prefered_Time_Slot, Client_ID, Task_ID, Area_ID, MinimumRate_Required) " +
                                          "VALUES (@RequestName, @PreferredTimeSlot, @ClientID, @TaskID, @AreaID, @MinimumRate)";
                    using (SqlCommand cmd = new SqlCommand(requestQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@RequestName", txtRequestName.Text);
                        cmd.Parameters.Add("@PreferredTimeSlot", SqlDbType.NVarChar).Value = preferredTimeSlots;
                        cmd.Parameters.AddWithValue("@ClientID", clientId);
                        cmd.Parameters.AddWithValue("@TaskID", taskId);
                        cmd.Parameters.AddWithValue("@AreaID", areaId);
                        cmd.Parameters.AddWithValue("@MinimumRate", minimumRate);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Request posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form after posting
                    txtRequestName.Clear();
                    cmbSpecialty.SelectedIndex = -1;
                    cmbServiceArea.SelectedIndex = -1;
                    txtMinimumRate.Clear();
                    txtHourlyRate.Clear();
                    txtAverageTime.Clear();
                    for (int i = 0; i < lstTimeSlots.Items.Count; i++)
                    {
                        lstTimeSlots.SetItemChecked(i, false);
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UProfilebtn_Click(object sender, EventArgs e)
        {
            Cprofile profile = new Cprofile(clientId);
            profile.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Crequest_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }
    }
}