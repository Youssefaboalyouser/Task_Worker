//namespace TaskWorker
//{
//    partial class Crequest
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crequest));
//            panel1 = new Panel();
//            UProfilebtn = new Button();
//            panel2 = new Panel();
//            pictureBox1 = new PictureBox();
//            btnLogout = new Button();
//            pictureBox2 = new PictureBox();
//            Taskbtn = new Button();
//            button1 = new Button();
//            panel3 = new Panel();
//            Exit = new Label();
//            label1 = new Label();
//            label2 = new Label();
//            cmbSpecialty = new ComboBox();
//            label3 = new Label();
//            label4 = new Label();
//            txtMinimumRate = new TextBox();
//            label6 = new Label();
//            txtHourlyRate = new TextBox();
//            btnPost = new Button();
//            label5 = new Label();
//            label7 = new Label();
//            txtRequestName = new TextBox();
//            txtAverageTime = new TextBox();
//            label8 = new Label();
//            cmbServiceArea = new ComboBox();
//            //checkedListBox1 = new CheckedListBox();
//            //checkedListBox2 = new CheckedListBox();
//            lstTimeSlots = new CheckedListBox();
//            panel1.SuspendLayout();
//            panel2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
//            panel3.SuspendLayout();
//            SuspendLayout();
//            // 
//            // panel1
//            // 
//            panel1.BackColor = Color.DarkCyan;
//            //panel1.Controls.Add(checkedListBox1);
//            panel1.Controls.Add(UProfilebtn);
//            panel1.Controls.Add(panel2);
//            panel1.Controls.Add(pictureBox2);
//            panel1.Controls.Add(Taskbtn);
//            panel1.Controls.Add(button1);
//            panel1.Dock = DockStyle.Left;
//            panel1.Location = new Point(0, 0);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(236, 528);
//            panel1.TabIndex = 3;
//            // 
//            // UProfilebtn
//            // 
//            UProfilebtn.FlatAppearance.BorderColor = Color.White;
//            UProfilebtn.FlatAppearance.BorderSize = 0;
//            UProfilebtn.FlatStyle = FlatStyle.Flat;
//            UProfilebtn.ForeColor = Color.FromArgb(248, 242, 232);
//            UProfilebtn.Location = new Point(3, 289);
//            UProfilebtn.Name = "UProfilebtn";
//            UProfilebtn.Size = new Size(233, 37);
//            UProfilebtn.TabIndex = 6;
//            UProfilebtn.Text = "UserProfile";
//            UProfilebtn.UseVisualStyleBackColor = true;
//            UProfilebtn.Click += UProfilebtn_Click;
//            // 
//            // panel2
//            // 
//            panel2.BackColor = Color.LightSeaGreen;
//            panel2.Controls.Add(pictureBox1);
//            panel2.Controls.Add(btnLogout);
//            panel2.Location = new Point(0, 456);
//            panel2.Name = "panel2";
//            panel2.Size = new Size(236, 91);
//            panel2.TabIndex = 4;
//            // 
//            // pictureBox1
//            // 
//            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
//            pictureBox1.Location = new Point(23, 20);
//            pictureBox1.Name = "pictureBox1";
//            pictureBox1.Size = new Size(56, 46);
//            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
//            pictureBox1.TabIndex = 5;
//            pictureBox1.TabStop = false;
//            // 
//            // btnLogout
//            // 
//            btnLogout.BackColor = Color.Crimson;
//            btnLogout.FlatAppearance.BorderColor = Color.White;
//            btnLogout.FlatAppearance.BorderSize = 0;
//            btnLogout.FlatStyle = FlatStyle.Flat;
//            btnLogout.ForeColor = Color.FromArgb(248, 242, 232);
//            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
//            btnLogout.Location = new Point(75, 26);
//            btnLogout.Name = "btnLogout";
//            btnLogout.Size = new Size(110, 37);
//            btnLogout.TabIndex = 4;
//            btnLogout.Text = "Logout";
//            btnLogout.UseVisualStyleBackColor = false;
//            btnLogout.Click += btnLogout_Click;
//            // 
//            // pictureBox2
//            // 
//            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
//            pictureBox2.Location = new Point(33, 12);
//            pictureBox2.Name = "pictureBox2";
//            pictureBox2.Size = new Size(152, 86);
//            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
//            pictureBox2.TabIndex = 1;
//            pictureBox2.TabStop = false;
//            // 
//            // Taskbtn
//            // 
//            Taskbtn.BackColor = Color.DarkCyan;
//            Taskbtn.FlatAppearance.BorderColor = Color.White;
//            Taskbtn.FlatAppearance.BorderSize = 0;
//            Taskbtn.FlatStyle = FlatStyle.Flat;
//            Taskbtn.ForeColor = Color.FromArgb(248, 242, 232);
//            Taskbtn.Location = new Point(0, 227);
//            Taskbtn.Name = "Taskbtn";
//            Taskbtn.Size = new Size(233, 37);
//            Taskbtn.TabIndex = 2;
//            Taskbtn.Text = "Tasks";
//            Taskbtn.UseVisualStyleBackColor = false;
//            Taskbtn.Click += Taskbtn_Click;
//            // 
//            // button1
//            // 
//            button1.BackColor = Color.LightSeaGreen;
//            button1.FlatAppearance.BorderColor = Color.White;
//            button1.FlatAppearance.BorderSize = 0;
//            button1.FlatStyle = FlatStyle.Flat;
//            button1.ForeColor = Color.FromArgb(248, 242, 232);
//            button1.Location = new Point(0, 163);
//            button1.Name = "button1";
//            button1.Size = new Size(233, 37);
//            button1.TabIndex = 1;
//            button1.Text = "Make Request";
//            button1.UseVisualStyleBackColor = false;
//            // 
//            // panel3
//            // 
//            panel3.BackColor = Color.LightSeaGreen;
//            panel3.Controls.Add(Exit);
//            panel3.Controls.Add(label1);
//            panel3.Dock = DockStyle.Top;
//            panel3.Location = new Point(236, 0);
//            panel3.Name = "panel3";
//            panel3.Size = new Size(673, 41);
//            panel3.TabIndex = 9;
//            // 
//            // Exit
//            // 
//            Exit.AutoSize = true;
//            Exit.BackColor = Color.LightSeaGreen;
//            Exit.FlatStyle = FlatStyle.Flat;
//            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            Exit.ForeColor = Color.White;
//            Exit.Location = new Point(626, 7);
//            Exit.Name = "Exit";
//            Exit.Size = new Size(26, 25);
//            Exit.TabIndex = 14;
//            Exit.Text = "X";
//            Exit.Click += Exit_Click;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.ForeColor = Color.White;
//            label1.Location = new Point(15, 12);
//            label1.Name = "label1";
//            label1.Size = new Size(314, 18);
//            label1.TabIndex = 13;
//            label1.Text = "TaskWorker ProgramV1.0 Client Menu";
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Location = new Point(286, 117);
//            label2.Name = "label2";
//            label2.Size = new Size(165, 18);
//            label2.TabIndex = 10;
//            label2.Text = "Speciality Required";
//            // 
//            // cmbSpecialty
//            // 
//            cmbSpecialty.FormattingEnabled = true;
//            cmbSpecialty.Items.AddRange(new object[] { "Cleaner", "Mechanic", "Welder", "Mason", "Painter", "Electrician", "Plumber", "Carpenter" });
//            cmbSpecialty.Location = new Point(508, 114);
//            cmbSpecialty.Name = "cmbSpecialty";
//            cmbSpecialty.Size = new Size(296, 26);
//            cmbSpecialty.TabIndex = 11;
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Location = new Point(286, 172);
//            label3.Name = "label3";
//            label3.Size = new Size(187, 18);
//            label3.TabIndex = 12;
//            label3.Text = "Service Area Required";
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Location = new Point(286, 234);
//            label4.Name = "label4";
//            label4.Size = new Size(203, 18);
//            label4.TabIndex = 14;
//            label4.Text = "Minimum Rate Required";
//            // 
//            // txtMinimumRate
//            // 
//            txtMinimumRate.Location = new Point(508, 230);
//            txtMinimumRate.Name = "txtMinimumRate";
//            txtMinimumRate.Size = new Size(296, 27);
//            txtMinimumRate.TabIndex = 15;
//            // 
//            // label6
//            // 
//            label6.AutoSize = true;
//            label6.Location = new Point(286, 294);
//            label6.Name = "label6";
//            label6.Size = new Size(104, 18);
//            label6.TabIndex = 16;
//            label6.Text = "Hourly Rate";
//            // 
//            // txtHourlyRate
//            // 
//            txtHourlyRate.Location = new Point(508, 290);
//            txtHourlyRate.Name = "txtHourlyRate";
//            txtHourlyRate.Size = new Size(296, 27);
//            txtHourlyRate.TabIndex = 17;
//            // 
//            // btnPost
//            // 
//            btnPost.BackColor = Color.LightSeaGreen;
//            btnPost.FlatAppearance.BorderColor = Color.White;
//            btnPost.FlatAppearance.BorderSize = 0;
//            btnPost.FlatStyle = FlatStyle.Flat;
//            btnPost.ForeColor = Color.FromArgb(248, 242, 232);
//            btnPost.ImageAlign = ContentAlignment.MiddleLeft;
//            btnPost.Location = new Point(528, 485);
//            btnPost.Name = "btnPost";
//            btnPost.Size = new Size(110, 37);
//            btnPost.TabIndex = 34;
//            btnPost.Text = "Post";
//            btnPost.UseVisualStyleBackColor = false;
//            btnPost.Click += btnPost_Click;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Location = new Point(286, 409);
//            label5.Name = "label5";
//            label5.Size = new Size(150, 18);
//            label5.TabIndex = 35;
//            label5.Text = "Preferd Time Slot";
//            label5.Click += label5_Click;
//            // 
//            // label7
//            // 
//            label7.AutoSize = true;
//            label7.Location = new Point(286, 60);
//            label7.Name = "label7";
//            label7.Size = new Size(128, 18);
//            label7.TabIndex = 38;
//            label7.Text = "Request Name";
//            // 
//            // txtRequestName
//            // 
//            txtRequestName.Location = new Point(508, 57);
//            txtRequestName.Name = "txtRequestName";
//            txtRequestName.Size = new Size(296, 27);
//            txtRequestName.TabIndex = 39;
//            // 
//            // txtAverageTime
//            // 
//            txtAverageTime.Location = new Point(508, 343);
//            txtAverageTime.Name = "txtAverageTime";
//            txtAverageTime.Size = new Size(296, 27);
//            txtAverageTime.TabIndex = 41;
//            // 
//            // label8
//            // 
//            label8.AutoSize = true;
//            label8.Location = new Point(286, 347);
//            label8.Name = "label8";
//            label8.Size = new Size(186, 18);
//            label8.TabIndex = 40;
//            label8.Text = "Average Time needed";
//            // 
//            // cmbServiceArea
//            // 
//            cmbServiceArea.FormattingEnabled = true;
//            cmbServiceArea.Items.AddRange(new object[] { "Zamalek", "Dokie", "Giza", "Zaid", "Fessal", "Hossary", "Agozza", "6'October " });
//            cmbServiceArea.Location = new Point(508, 169);
//            cmbServiceArea.Name = "cmbServiceArea";
//            cmbServiceArea.Size = new Size(296, 26);
//            cmbServiceArea.TabIndex = 42;
//            // 
//            // checkedListBox1
//            // 
//            //checkedListBox1.FormattingEnabled = true;
//            //checkedListBox1.Location = new Point(516, 388);
//            //checkedListBox1.Name = "checkedListBox1";
//            //checkedListBox1.Size = new Size(120, 92);
//            //checkedListBox1.TabIndex = 7;
//            // 
//            // checkedListBox2
//            // 
//            lstTimeSlots.FormattingEnabled = true;
//            lstTimeSlots.Items.AddRange(new object[] { "8 AM : 10 AM", "11 AM : 1 PM", "2 PM : 4 PM", "5 PM : 7 PM", "8 PM : 10 PM", "11 PM : 1 AM", "3 AM : 5 AM", "6 AM : 8 AM " });
//            lstTimeSlots.Location = new Point(508, 387);
//            lstTimeSlots.Name = "checkedListBox2";
//            lstTimeSlots.Size = new Size(296, 92);
//            lstTimeSlots.TabIndex = 43;
//            // 
//            // Crequest
//            // 
//            AutoScaleDimensions = new SizeF(10F, 18F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.FromArgb(242, 248, 232);
//            ClientSize = new Size(909, 528);
//            Controls.Add(lstTimeSlots);
//            Controls.Add(cmbServiceArea);
//            Controls.Add(txtAverageTime);
//            Controls.Add(label8);
//            Controls.Add(txtRequestName);
//            Controls.Add(label7);
//            Controls.Add(label5);
//            Controls.Add(btnPost);
//            Controls.Add(txtHourlyRate);
//            Controls.Add(label6);
//            Controls.Add(txtMinimumRate);
//            Controls.Add(label4);
//            Controls.Add(label3);
//            Controls.Add(cmbSpecialty);
//            Controls.Add(label2);
//            Controls.Add(panel3);
//            Controls.Add(panel1);
//            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            FormBorderStyle = FormBorderStyle.None;
//            Margin = new Padding(4);
//            Name = "Crequest";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Client_request";
//            Load += Crequest_Load;
//            panel1.ResumeLayout(false);
//            panel2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
//            panel3.ResumeLayout(false);
//            panel3.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Panel panel1;
//        private Button UProfilebtn;
//        private Panel panel2;
//        private PictureBox pictureBox1;
//        private Button btnLogout;
//        private PictureBox pictureBox2;
//        private Button Taskbtn;
//        private Button button1;
//        private Panel panel3;
//        private Label Exit;
//        private Label label1;
//        private Label label2;
//        private ComboBox cmbSpecialty;
//        private Label label3;
//        private ComboBox cmbServiceArea;
//        //private CheckedListBox checkedListBox1;
//        //private CheckedListBox checkedListBox2;
//        private Label label4;
//        private TextBox txtMinimumRate;
//        private Label label6;
//        private TextBox txtHourlyRate;
//        private Button btnPost;
//        private Label label5;
//        private CheckedListBox lstTimeSlots;
//        private Label label7;
//        private TextBox txtRequestName;
//        private TextBox txtAverageTime;
//        private Label label8;
//    }
//}
namespace TaskWorker
{
    partial class Crequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crequest));
            panel1 = new Panel();
            checkedListBox1 = new CheckedListBox();
            UProfilebtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            Taskbtn = new Button();
            button1 = new Button();
            panel3 = new Panel();
            Exit = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbSpecialty = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtMinimumRate = new TextBox();
            label6 = new Label();
            txtHourlyRate = new TextBox();
            btnPost = new Button();
            label5 = new Label();
            label7 = new Label();
            txtRequestName = new TextBox();
            txtAverageTime = new TextBox();
            label8 = new Label();
            cmbServiceArea = new ComboBox();
            lstTimeSlots = new CheckedListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(UProfilebtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Taskbtn);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 528);
            panel1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(516, 388);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 92);
            checkedListBox1.TabIndex = 7;
            // 
            // UProfilebtn
            // 
            UProfilebtn.FlatAppearance.BorderColor = Color.White;
            UProfilebtn.FlatAppearance.BorderSize = 0;
            UProfilebtn.FlatStyle = FlatStyle.Flat;
            UProfilebtn.ForeColor = Color.FromArgb(248, 242, 232);
            UProfilebtn.Location = new Point(3, 289);
            UProfilebtn.Name = "UProfilebtn";
            UProfilebtn.Size = new Size(233, 37);
            UProfilebtn.TabIndex = 6;
            UProfilebtn.Text = "UserProfile";
            UProfilebtn.UseVisualStyleBackColor = true;
            UProfilebtn.Click += UProfilebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLogout);
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
            // btnLogout
            // 
            btnLogout.BackColor = Color.Crimson;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(248, 242, 232);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(75, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 37);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            // Taskbtn
            // 
            Taskbtn.BackColor = Color.DarkCyan;
            Taskbtn.FlatAppearance.BorderColor = Color.White;
            Taskbtn.FlatAppearance.BorderSize = 0;
            Taskbtn.FlatStyle = FlatStyle.Flat;
            Taskbtn.ForeColor = Color.FromArgb(248, 242, 232);
            Taskbtn.Location = new Point(0, 227);
            Taskbtn.Name = "Taskbtn";
            Taskbtn.Size = new Size(233, 37);
            Taskbtn.TabIndex = 2;
            Taskbtn.Text = "Tasks";
            Taskbtn.UseVisualStyleBackColor = false;
            Taskbtn.Click += Taskbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(248, 242, 232);
            button1.Location = new Point(0, 163);
            button1.Name = "button1";
            button1.Size = new Size(233, 37);
            button1.TabIndex = 1;
            button1.Text = "Make Request";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel3.TabIndex = 9;
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
            label1.Size = new Size(314, 18);
            label1.TabIndex = 13;
            label1.Text = "TaskWorker ProgramV1.0 Client Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 117);
            label2.Name = "label2";
            label2.Size = new Size(165, 18);
            label2.TabIndex = 10;
            label2.Text = "Speciality Required";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Items.AddRange(new object[] { "Cleaner", "Mechanic", "Welder", "Mason", "Painter", "Electrician", "Plumber", "Carpenter" });
            cmbSpecialty.Location = new Point(508, 114);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(296, 26);
            cmbSpecialty.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 172);
            label3.Name = "label3";
            label3.Size = new Size(187, 18);
            label3.TabIndex = 12;
            label3.Text = "Service Area Required";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 234);
            label4.Name = "label4";
            label4.Size = new Size(203, 18);
            label4.TabIndex = 14;
            label4.Text = "Minimum Rate Required";
            // 
            // txtMinimumRate
            // 
            txtMinimumRate.Location = new Point(508, 230);
            txtMinimumRate.Name = "txtMinimumRate";
            txtMinimumRate.Size = new Size(296, 27);
            txtMinimumRate.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 294);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 16;
            label6.Text = "Hourly Rate";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(508, 290);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(296, 27);
            txtHourlyRate.TabIndex = 17;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.LightSeaGreen;
            btnPost.FlatAppearance.BorderColor = Color.White;
            btnPost.FlatAppearance.BorderSize = 0;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.ForeColor = Color.FromArgb(248, 242, 232);
            btnPost.ImageAlign = ContentAlignment.MiddleLeft;
            btnPost.Location = new Point(528, 485);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(110, 37);
            btnPost.TabIndex = 34;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 409);
            label5.Name = "label5";
            label5.Size = new Size(150, 18);
            label5.TabIndex = 35;
            label5.Text = "Preferd Time Slot";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 60);
            label7.Name = "label7";
            label7.Size = new Size(128, 18);
            label7.TabIndex = 38;
            label7.Text = "Request Name";
            // 
            // txtRequestName
            // 
            txtRequestName.Location = new Point(508, 57);
            txtRequestName.Name = "txtRequestName";
            txtRequestName.Size = new Size(296, 27);
            txtRequestName.TabIndex = 39;
            // 
            // txtAverageTime
            // 
            txtAverageTime.Location = new Point(508, 343);
            txtAverageTime.Name = "txtAverageTime";
            txtAverageTime.Size = new Size(296, 27);
            txtAverageTime.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 347);
            label8.Name = "label8";
            label8.Size = new Size(186, 18);
            label8.TabIndex = 40;
            label8.Text = "Average Time needed";
            // 
            // cmbServiceArea
            // 
            cmbServiceArea.FormattingEnabled = true;
            cmbServiceArea.Items.AddRange(new object[] { "Zamalek", "Dokie", "Giza", "Zaid", "Fessal", "Hossary", "Agozza", "6'October " });
            cmbServiceArea.Location = new Point(508, 169);
            cmbServiceArea.Name = "cmbServiceArea";
            cmbServiceArea.Size = new Size(296, 26);
            cmbServiceArea.TabIndex = 42;
            // 
            // lstTimeSlots
            // 
            lstTimeSlots.FormattingEnabled = true;
            lstTimeSlots.Items.AddRange(new object[] { "8 AM : 10 AM", "11 AM : 1 PM", "2 PM : 4 PM", "5 PM : 7 PM", "8 PM : 10 PM", "11 PM : 1 AM", "3 AM : 5 AM", "6 AM : 8 AM " });
            lstTimeSlots.Location = new Point(508, 387);
            lstTimeSlots.Name = "lstTimeSlots";
            lstTimeSlots.Size = new Size(296, 92);
            lstTimeSlots.TabIndex = 43;
            // 
            // Crequest
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(909, 528);
            Controls.Add(lstTimeSlots);
            Controls.Add(cmbServiceArea);
            Controls.Add(txtAverageTime);
            Controls.Add(label8);
            Controls.Add(txtRequestName);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(btnPost);
            Controls.Add(txtHourlyRate);
            Controls.Add(label6);
            Controls.Add(txtMinimumRate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbSpecialty);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Crequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client_request";
            Load += Crequest_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button UProfilebtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private Button Taskbtn;
        private Button button1;
        private Panel panel3;
        private Label Exit;
        private Label label1;
        private Label label2;
        private ComboBox cmbSpecialty;
        private Label label3;
        private ComboBox cmbServiceArea;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private TextBox txtMinimumRate;
        private Label label6;
        private TextBox txtHourlyRate;
        private Button btnPost;
        private Label label5;
        private Label label7;
        private TextBox txtRequestName;
        private TextBox txtAverageTime;
        private Label label8;
        private CheckedListBox lstTimeSlots;
    }
}