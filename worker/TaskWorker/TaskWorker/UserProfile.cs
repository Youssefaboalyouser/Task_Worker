//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

//namespace TaskWorker
//{
//    public partial class wUserProfile : Form
//    {
//        private int workerId; // This should be set dynamically based on the logged-in worker
//        private string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
//        private Image defaultImage; // To store the default image
//        private List<string> selectedSpecialities = new List<string>(); // To track selected specialities
//        public wUserProfile(int workerid)
//        {
//            this.workerId = workerid;
//            InitializeComponent();
//            LoadWorkerProfile(); // Load worker details on form load
//            defaultImage = pictureBox3.Image; // Set the default image
//            UpdateRating(); // Update rating on form load
//        }
//        private void LoadWorkerProfile()
//        {
//            using (SqlConnection sqlCon = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    sqlCon.Open();
//                    string query = "SELECT NAME FROM dbo.Worker WHERE Worker_ID = @WorkerId";
//                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
//                    {
//                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                        object result = cmd.ExecuteScalar();
//                        if (result != null)
//                        {
//                            textBox1.Text = result.ToString();
//                        }
//                    }
//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }
//        private void UpdateRating()
//        {
//            using (SqlConnection sqlCon = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    sqlCon.Open();
//                    string query = "SELECT AVG(CAST(Worker_Rating AS FLOAT)) FROM dbo.Requests WHERE Worker_ID = @WorkerId AND Worker_Rating IS NOT NULL";
//                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
//                    {
//                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                        object result = cmd.ExecuteScalar();
//                        if (result != null && result != DBNull.Value)
//                        {
//                            label8.Text = Math.Round(Convert.ToDouble(result), 1).ToString();
//                        }
//                        else
//                        {
//                            label8.Text = "0"; // Default rating if no ratings exist
//                        }
//                    }
//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }
//        private void SpecialityButton_Click(object sender, EventArgs e)
//        {
//            Button button = sender as Button;
//            if (button.BackColor == Color.Crimson)
//            {
//                button.BackColor = Color.LightSeaGreen;
//                selectedSpecialities.Remove(button.Text.Trim());
//            }
//            else
//            {
//                button.BackColor = Color.Crimson;
//                selectedSpecialities.Add(button.Text.Trim());
//            }
//        }

//        // Assign click events to speciality buttons
//        private void AssignSpecialityButtonEvents()
//        {
//            button7.Click += SpecialityButton_Click;  // Carpenter
//            button8.Click += SpecialityButton_Click;  // Plumber
//            button9.Click += SpecialityButton_Click;  // Electrician
//            button10.Click += SpecialityButton_Click; // Painter
//            button11.Click += SpecialityButton_Click; // Cleaner
//            button12.Click += SpecialityButton_Click; // Mechanic
//            button13.Click += SpecialityButton_Click; // Welder
//            button14.Click += SpecialityButton_Click; // Mason
//        }
//        private void ResetSpecialityButtons()
//        {
//            button7.BackColor = Color.LightSeaGreen;
//            button8.BackColor = Color.LightSeaGreen;
//            button9.BackColor = Color.LightSeaGreen;
//            button10.BackColor = Color.LightSeaGreen;
//            button11.BackColor = Color.LightSeaGreen;
//            button12.BackColor = Color.LightSeaGreen;
//            button13.BackColor = Color.LightSeaGreen;
//            button14.BackColor = Color.LightSeaGreen;
//        }
//        private void label8_Click(object sender, EventArgs e)
//        {

//        }

//        private void button14_Click(object sender, EventArgs e)
//        {

//        }

//        private void button12_Click(object sender, EventArgs e)
//        {

//        }

//        private void Requestbtn_Click(object sender, EventArgs e)
//        {
//            wRequest request = new wRequest(workerId);
//            request.Show();
//            this.Hide();
//        }

//        private void Timebtn_Click(object sender, EventArgs e)
//        {
//            wTimeSlots time = new wTimeSlots(workerId);
//            time.Show();
//            this.Hide();
//        }

//        private void Areabtn_Click(object sender, EventArgs e)
//        {
//            wChoceArea area = new wChoceArea(workerId);
//            area.Show();
//            this.Hide();
//        }

//        private void Tasksbtn_Click(object sender, EventArgs e)
//        {
//            wTasks tasks = new wTasks(workerId);
//            tasks.Show();
//            this.Hide();
//        }

//        private void Exit_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void button4_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {
//            using (SqlConnection sqlCon = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    sqlCon.Open();
//                    string query = "UPDATE dbo.Worker SET NAME = @Name WHERE Worker_ID = @WorkerId";
//                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
//                    {
//                        cmd.Parameters.AddWithValue("@Name", textBox1.Text);
//                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private void button5_Click(object sender, EventArgs e)
//        {
//            StartForm sForm = new StartForm();
//            sForm.Show();
//            this.Hide();
//        }

//        private void button15_Click(object sender, EventArgs e)
//        {
//            using (OpenFileDialog openFileDialog = new OpenFileDialog())
//            {
//                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
//                if (openFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
//                }
//            }
//        }

//        private void label6_Click(object sender, EventArgs e)
//        {
//            pictureBox3.Image = defaultImage;
//        }

//        private void button16_Click(object sender, EventArgs e)
//        {
//            selectedSpecialities.Clear();
//            ResetSpecialityButtons();
//        }

//        private void button17_Click(object sender, EventArgs e)
//        {
//            if (selectedSpecialities.Count == 0)
//            {
//                MessageBox.Show("Please select at least one speciality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            using (SqlConnection sqlCon = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    sqlCon.Open();

//                    // Get current worker details
//                    string getWorkerQuery = "SELECT NAME, WPassKey FROM dbo.Worker WHERE Worker_ID = @WorkerId";
//                    string name = "";
//                    string password = "";
//                    using (SqlCommand cmd = new SqlCommand(getWorkerQuery, sqlCon))
//                    {
//                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                name = reader["NAME"].ToString();
//                                password = reader["WPassKey"].ToString();
//                            }
//                        }
//                    }

//                    if (selectedSpecialities.Count == 1)
//                    {
//                        // Update the existing record
//                        string updateQuery = "UPDATE dbo.Worker SET Specialty_Name = @Specialty WHERE Worker_ID = @WorkerId AND Specialty_Name IS NULL";
//                        using (SqlCommand cmd = new SqlCommand(updateQuery, sqlCon))
//                        {
//                            cmd.Parameters.AddWithValue("@Specialty", selectedSpecialities[0]);
//                            cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                            int rowsAffected = cmd.ExecuteNonQuery();
//                            if (rowsAffected > 0)
//                            {
//                                MessageBox.Show("Speciality updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        // Create redundant records for each speciality
//                        foreach (string speciality in selectedSpecialities)
//                        {
//                            string insertQuery = "INSERT INTO dbo.Worker (Worker_ID, NAME, Specialty_Name, WPassKey) VALUES (@WorkerId, @Name, @Specialty, @Password)";
//                            using (SqlCommand cmd = new SqlCommand(insertQuery, sqlCon))
//                            {
//                                cmd.Parameters.AddWithValue("@WorkerId", workerId);
//                                cmd.Parameters.AddWithValue("@Name", name);
//                                cmd.Parameters.AddWithValue("@Specialty", speciality);
//                                cmd.Parameters.AddWithValue("@Password", password);
//                                cmd.ExecuteNonQuery();
//                            }
//                        }
//                        MessageBox.Show("Specialities added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private void wUserProfile_Load(object sender, EventArgs e)
//        {
//            AssignSpecialityButtonEvents();
//        }
//    }
//}
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
    public partial class wUserProfile : Form
    {
        private int workerId;
        private string connectionString = "Data Source=DESKTOP-KTV1SV9\\SQLEXPRESS;Initial Catalog=Task_WorkerMatching;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private Image defaultImage; // To store the default image
        private List<string> selectedSpecialities = new List<string>(); // To track selected specialities

        public wUserProfile(int workerid)
        {
            this.workerId = workerid;
            InitializeComponent();
            LoadWorkerProfile(); // Load worker details on form load
            defaultImage = pictureBox3.Image; // Set the default image
            UpdateRating(); // Update rating on form load
        }

        // Load worker profile (name and rating)
        private void LoadWorkerProfile()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT NAME FROM dbo.Worker WHERE Worker_ID = @WorkerId";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            textBox1.Text = result.ToString();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update worker name in the database when text changes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE dbo.Worker SET NAME = @Name WHERE Worker_ID = @WorkerId";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update rating from Requests table
        private void UpdateRating()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT AVG(CAST(Worker_Rating AS FLOAT)) FROM dbo.Requests WHERE Worker_ID = @WorkerId AND Worker_Rating IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label8.Text = Math.Round(Convert.ToDouble(result), 1).ToString();
                        }
                        else
                        {
                            label8.Text = "0"; // Default rating if no ratings exist
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handle logout button click
        private void button5_Click(object sender, EventArgs e)
        {
            StartForm sForm = new StartForm();
            sForm.Show();
            this.Hide();
        }

        // Change avatar button click
        private void button15_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        // Reset label click to revert to default image
        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = defaultImage;
        }

        // Speciality button clicks (limit to one selection)
        private void SpecialityButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Crimson)
            {
                button.BackColor = Color.LightSeaGreen;
                selectedSpecialities.Clear(); // Clear the selection
            }
            else
            {
                // Deselect all other buttons
                ResetSpecialityButtons();
                button.BackColor = Color.Crimson;
                selectedSpecialities.Clear(); // Clear previous selection
                selectedSpecialities.Add(button.Text.Trim()); // Add new selection
            }
        }

        // Assign click events to speciality buttons
        private void AssignSpecialityButtonEvents()
        {
            button7.Click += SpecialityButton_Click;  // Carpenter
            button8.Click += SpecialityButton_Click;  // Plumber
            button9.Click += SpecialityButton_Click;  // Electrician
            button10.Click += SpecialityButton_Click; // Painter
            button11.Click += SpecialityButton_Click; // Cleaner
            button12.Click += SpecialityButton_Click; // Mechanic
            button13.Click += SpecialityButton_Click; // Welder
            button14.Click += SpecialityButton_Click; // Mason
        }

        // Cancel button click to reset specialities
        private void button16_Click(object sender, EventArgs e)
        {
            selectedSpecialities.Clear();
            ResetSpecialityButtons();
        }

        // Reset speciality buttons color
        private void ResetSpecialityButtons()
        {
            button7.BackColor = Color.LightSeaGreen;
            button8.BackColor = Color.LightSeaGreen;
            button9.BackColor = Color.LightSeaGreen;
            button10.BackColor = Color.LightSeaGreen;
            button11.BackColor = Color.LightSeaGreen;
            button12.BackColor = Color.LightSeaGreen;
            button13.BackColor = Color.LightSeaGreen;
            button14.BackColor = Color.LightSeaGreen;
        }

        // Add button click to save speciality
        private void button17_Click(object sender, EventArgs e)
        {
            if (selectedSpecialities.Count == 0)
            {
                MessageBox.Show("Please select one speciality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSpecialities.Count > 1)
            {
                MessageBox.Show("You can only choose one speciality. Please use a different email for additional specialties.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetSpecialityButtons();
                selectedSpecialities.Clear();
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();

                    // Update the existing record with the selected speciality
                    string updateQuery = "UPDATE dbo.Worker SET Specialty_Name = @Specialty WHERE Worker_ID = @WorkerId AND (Specialty_Name IS NULL OR Specialty_Name = '')";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Specialty", selectedSpecialities[0]);
                        cmd.Parameters.AddWithValue("@WorkerId", workerId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Speciality updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetSpecialityButtons();
                            selectedSpecialities.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Speciality already set or update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void Requestbtn_Click(object sender, EventArgs e)
        {
            wRequest request = new wRequest(workerId);
            request.Show();
            this.Hide();
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots time = new wTimeSlots(workerId);
            time.Show();
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void wUserProfile_Load(object sender, EventArgs e)
        {
            AssignSpecialityButtonEvents(); // Assign events to speciality buttons on form load
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
