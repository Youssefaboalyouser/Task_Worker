namespace TaskWorker
{
    partial class wRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wRequest));
            panel1 = new Panel();
            Profilebtn = new Button();
            Areabtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            Timebtn = new Button();
            Tasksbtn = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            Exit = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button7 = new Button();
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
            panel1.Controls.Add(Areabtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Timebtn);
            panel1.Controls.Add(Tasksbtn);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 528);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            // Areabtn
            // 
            Areabtn.BackColor = Color.DarkCyan;
            Areabtn.FlatAppearance.BorderColor = Color.White;
            Areabtn.FlatAppearance.BorderSize = 0;
            Areabtn.FlatStyle = FlatStyle.Flat;
            Areabtn.ForeColor = Color.FromArgb(248, 242, 232);
            Areabtn.Location = new Point(3, 238);
            Areabtn.Name = "Areabtn";
            Areabtn.Size = new Size(233, 37);
            Areabtn.TabIndex = 5;
            Areabtn.Text = "Chooce Area";
            Areabtn.UseVisualStyleBackColor = false;
            Areabtn.Click += Areabtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(0, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 69);
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
            Timebtn.FlatAppearance.BorderColor = Color.White;
            Timebtn.FlatAppearance.BorderSize = 0;
            Timebtn.FlatStyle = FlatStyle.Flat;
            Timebtn.ForeColor = Color.FromArgb(248, 242, 232);
            Timebtn.Location = new Point(0, 186);
            Timebtn.Name = "Timebtn";
            Timebtn.Size = new Size(233, 37);
            Timebtn.TabIndex = 3;
            Timebtn.Text = "Chooce Time";
            Timebtn.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(248, 242, 232);
            button1.Location = new Point(0, 132);
            button1.Name = "button1";
            button1.Size = new Size(233, 37);
            button1.TabIndex = 1;
            button1.Text = "Requests";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(236, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(673, 41);
            panel3.TabIndex = 6;
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
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.LightSeaGreen;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(879, 6);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 25);
            Exit.TabIndex = 12;
            Exit.Text = "X";
            Exit.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16F);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(381, 54);
            label2.Name = "label2";
            label2.Size = new Size(380, 26);
            label2.TabIndex = 13;
            label2.Text = "Offerd Jobs Based on User profile";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(673, 350);
            dataGridView1.TabIndex = 14;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(798, 483);
            button7.Name = "button7";
            button7.Size = new Size(99, 40);
            button7.TabIndex = 16;
            button7.Text = "APPLY";
            button7.UseVisualStyleBackColor = false;
            // 
            // wRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 242, 232);
            ClientSize = new Size(909, 528);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(Exit);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "wRequest";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Worker_Menu";
            Load += Worker_Menu_Load;
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

        #endregion

        private Panel panel1;
        private Button Timebtn;
        private Button Tasksbtn;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button5;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button Profilebtn;
        private Button Areabtn;
        private Panel panel3;
        private Label Exit;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button7;
    }
}