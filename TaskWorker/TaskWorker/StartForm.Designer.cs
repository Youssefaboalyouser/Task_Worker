namespace TaskWorker
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            label1 = new Label();
            panel3 = new Panel();
            Exit = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            to_login = new Button();
            to_SignUp = new Button();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(135, 109);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our program";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(Exit);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 81);
            panel3.TabIndex = 9;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.LightSeaGreen;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(619, 7);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 25);
            Exit.TabIndex = 14;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(438, 63);
            label2.Name = "label2";
            label2.Size = new Size(211, 18);
            label2.TabIndex = 13;
            label2.Text = "TaskWorker ProgramV1.0";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(61, 158);
            label3.Name = "label3";
            label3.Size = new Size(503, 18);
            label3.TabIndex = 10;
            label3.Text = "Whether you're building your career or finding the right help";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(610, 18);
            label4.TabIndex = 11;
            label4.Text = "TaskWorker is your launchpad to progress, performance, and real results.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(182, 231);
            label6.Name = "label6";
            label6.Size = new Size(213, 18);
            label6.TabIndex = 12;
            label6.Text = "Start your journey today.";
            // 
            // to_login
            // 
            to_login.BackColor = Color.Teal;
            to_login.FlatStyle = FlatStyle.Flat;
            to_login.ForeColor = Color.White;
            to_login.Location = new Point(80, 291);
            to_login.Name = "to_login";
            to_login.Size = new Size(163, 53);
            to_login.TabIndex = 13;
            to_login.Text = "LogIn";
            to_login.UseVisualStyleBackColor = false;
            to_login.Click += to_login_Click;
            // 
            // to_SignUp
            // 
            to_SignUp.BackColor = Color.LightSeaGreen;
            to_SignUp.FlatStyle = FlatStyle.Flat;
            to_SignUp.ForeColor = Color.White;
            to_SignUp.Location = new Point(361, 291);
            to_SignUp.Name = "to_SignUp";
            to_SignUp.Size = new Size(153, 53);
            to_SignUp.TabIndex = 14;
            to_SignUp.Text = "SignUp";
            to_SignUp.UseVisualStyleBackColor = false;
            to_SignUp.Click += to_SignUp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(649, 407);
            Controls.Add(to_SignUp);
            Controls.Add(to_login);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            Load += StartForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label Exit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button to_login;
        private Button to_SignUp;
        private PictureBox pictureBox1;
    }
}