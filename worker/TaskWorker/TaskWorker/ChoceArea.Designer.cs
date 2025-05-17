
using Microsoft.Data.SqlClient;

namespace TaskWorker
{
    partial class wChoceArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wChoceArea));
            panel1 = new Panel();
            Profilebtn = new Button();
            button6 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            Timebtn = new Button();
            Tasksbtn = new Button();
            Requestsbtn = new Button();
            panel3 = new Panel();
            Exit = new Label();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button17 = new Button();
            button16 = new Button();
            dataGridView1 = new DataGridView();
            button15 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(Profilebtn);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Timebtn);
            panel1.Controls.Add(Tasksbtn);
            panel1.Controls.Add(Requestsbtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 528);
            panel1.TabIndex = 2;
            // 
            // Profilebtn
            // 
            Profilebtn.FlatAppearance.BorderColor = Color.White;
            Profilebtn.FlatAppearance.BorderSize = 0;
            Profilebtn.FlatStyle = FlatStyle.Flat;
            Profilebtn.ForeColor = Color.FromArgb(248, 242, 232);
            Profilebtn.Location = new Point(3, 324);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(233, 37);
            Profilebtn.TabIndex = 6;
            Profilebtn.Text = "UserProfile";
            Profilebtn.UseVisualStyleBackColor = true;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSeaGreen;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(248, 242, 232);
            button6.Location = new Point(3, 238);
            button6.Name = "button6";
            button6.Size = new Size(233, 37);
            button6.TabIndex = 5;
            button6.Text = "Chooce Area";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(0, 456);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 91);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(248, 242, 232);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(75, 26);
            button5.Name = "button5";
            button5.Size = new Size(110, 37);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Timebtn
            // 
            Timebtn.BackColor = Color.DarkCyan;
            Timebtn.FlatAppearance.BorderColor = Color.White;
            Timebtn.FlatAppearance.BorderSize = 0;
            Timebtn.FlatStyle = FlatStyle.Flat;
            Timebtn.ForeColor = Color.FromArgb(248, 242, 232);
            Timebtn.Location = new Point(0, 186);
            Timebtn.Name = "Timebtn";
            Timebtn.Size = new Size(233, 37);
            Timebtn.TabIndex = 3;
            Timebtn.Text = "Chooce Time";
            Timebtn.UseVisualStyleBackColor = false;
            Timebtn.Click += Timebtn_Click;
            // 
            // Tasksbtn
            // 
            Tasksbtn.BackColor = Color.DarkCyan;
            Tasksbtn.FlatAppearance.BorderColor = Color.White;
            Tasksbtn.FlatAppearance.BorderSize = 0;
            Tasksbtn.FlatStyle = FlatStyle.Flat;
            Tasksbtn.ForeColor = Color.FromArgb(248, 242, 232);
            Tasksbtn.Location = new Point(0, 281);
            Tasksbtn.Name = "Tasksbtn";
            Tasksbtn.Size = new Size(233, 37);
            Tasksbtn.TabIndex = 2;
            Tasksbtn.Text = "Tasks";
            Tasksbtn.UseVisualStyleBackColor = false;
            Tasksbtn.Click += Tasksbtn_Click;
            // 
            // Requestsbtn
            // 
            Requestsbtn.BackColor = Color.DarkCyan;
            Requestsbtn.FlatAppearance.BorderColor = Color.White;
            Requestsbtn.FlatAppearance.BorderSize = 0;
            Requestsbtn.FlatStyle = FlatStyle.Flat;
            Requestsbtn.ForeColor = Color.FromArgb(248, 242, 232);
            Requestsbtn.Location = new Point(0, 132);
            Requestsbtn.Name = "Requestsbtn";
            Requestsbtn.Size = new Size(233, 37);
            Requestsbtn.TabIndex = 1;
            Requestsbtn.Text = "Requests";
            Requestsbtn.UseVisualStyleBackColor = false;
            Requestsbtn.Click += Requestsbtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(Exit);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(236, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(673, 41);
            panel3.TabIndex = 8;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.LightSeaGreen;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(626, 7);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 25);
            Exit.TabIndex = 14;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(323, 18);
            label1.TabIndex = 13;
            label1.Text = "TaskWorker ProgramV1.0 Worker Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16F);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(434, 54);
            label2.Name = "label2";
            label2.Size = new Size(256, 26);
            label2.TabIndex = 15;
            label2.Text = "Available Service Area";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(256, 114);
            button7.Name = "button7";
            button7.Size = new Size(122, 26);
            button7.TabIndex = 16;
            button7.Text = "Dokie";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(424, 114);
            button8.Name = "button8";
            button8.Size = new Size(122, 26);
            button8.TabIndex = 17;
            button8.Text = "Giza";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSeaGreen;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(592, 114);
            button9.Name = "button9";
            button9.Size = new Size(122, 26);
            button9.TabIndex = 18;
            button9.Text = "Zamalek";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(757, 114);
            button10.Name = "button10";
            button10.Size = new Size(122, 26);
            button10.TabIndex = 19;
            button10.Text = "6'October";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSeaGreen;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(757, 172);
            button11.Name = "button11";
            button11.Size = new Size(122, 26);
            button11.TabIndex = 23;
            button11.Text = "Agozza";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSeaGreen;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(592, 172);
            button12.Name = "button12";
            button12.Size = new Size(122, 26);
            button12.TabIndex = 22;
            button12.Text = "Fessal";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.LightSeaGreen;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(424, 172);
            button13.Name = "button13";
            button13.Size = new Size(122, 26);
            button13.TabIndex = 21;
            button13.Text = "Hossary";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSeaGreen;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(256, 172);
            button14.Name = "button14";
            button14.Size = new Size(122, 26);
            button14.TabIndex = 20;
            button14.Text = "Zaid";
            button14.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.Crimson;
            button17.FlatAppearance.BorderColor = Color.White;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.FromArgb(248, 242, 232);
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(682, 482);
            button17.Name = "button17";
            button17.Size = new Size(110, 37);
            button17.TabIndex = 36;
            button17.Text = "Delete";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkRed;
            button16.FlatAppearance.BorderColor = Color.White;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.FromArgb(248, 242, 232);
            button16.ImageAlign = ContentAlignment.MiddleLeft;
            button16.Location = new Point(512, 482);
            button16.Name = "button16";
            button16.Size = new Size(110, 37);
            button16.TabIndex = 35;
            button16.Text = "Cancel";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(673, 188);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button15
            // 
            button15.BackColor = Color.LightSeaGreen;
            button15.FlatAppearance.BorderColor = Color.White;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.FromArgb(248, 242, 232);
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(347, 482);
            button15.Name = "button15";
            button15.Size = new Size(110, 37);
            button15.TabIndex = 33;
            button15.Text = "Add";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // wChoceArea
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 242, 232);
            ClientSize = new Size(909, 528);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(dataGridView1);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "wChoceArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoceArea";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (selectedAreas.Count == 0)
            {
                MessageBox.Show("Please select at least one area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    foreach (string areaName in selectedAreas.ToList()) // Use ToList to avoid collection modified error
                    {
                        // Check if the area is already associated with the worker
                        string queryCheck = "SELECT COUNT(*) FROM Worker_Service_Area WHERE Worker_ID = @WorkerID AND Area_ID = (SELECT Area_ID FROM Service_Area WHERE Area_Name = @AreaName)";
                        using (SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon))
                        {
                            cmdCheck.Parameters.AddWithValue("@WorkerID", workerId);
                            cmdCheck.Parameters.AddWithValue("@AreaName", areaName);
                            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show($"Area '{areaName}' is already assigned to this worker.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                selectedAreas.Remove(areaName);
                                continue;
                            }
                        }

                        // Get Area_ID
                        string queryAreaId = "SELECT Area_ID FROM Service_Area WHERE Area_Name = @AreaName";
                        int areaId;
                        using (SqlCommand cmdArea = new SqlCommand(queryAreaId, sqlCon))
                        {
                            cmdArea.Parameters.AddWithValue("@AreaName", areaName);
                            var result = cmdArea.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show($"Area '{areaName}' not found in Service_Area table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            areaId = Convert.ToInt32(result);
                        }

                        // Insert into Worker_Service_Area
                        string queryInsert = "INSERT INTO Worker_Service_Area (Worker_ID, Area_ID) VALUES (@WorkerID, @AreaID); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand cmdInsert = new SqlCommand(queryInsert, sqlCon))
                        {
                            cmdInsert.Parameters.AddWithValue("@WorkerID", workerId);
                            cmdInsert.Parameters.AddWithValue("@AreaID", areaId);
                            cmdInsert.ExecuteScalar(); // Execute to insert and get WorkerArea_ID
                        }
                    }
                    if (selectedAreas.Count > 0)
                    {
                        MessageBox.Show("Areas added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadWorkerAreas();
                    button16_Click(sender, e); // Reset buttons
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (var button in areaButtons)
            {
                button.BackColor = Color.LightSeaGreen;
            }
            selectedAreas.Clear();
            MessageBox.Show("Selections canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private Panel panel1;
        private Button Profilebtn;
        private Button button6;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button5;
        private PictureBox pictureBox2;
        private Button Timebtn;
        private Button Tasksbtn;
        private Button Requestsbtn;
        private Panel panel3;
        private Label Exit;
        private Label label1;
        private Label label2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button17;
        private Button button16;
        private DataGridView dataGridView1;
        private Button button15;
    }
}