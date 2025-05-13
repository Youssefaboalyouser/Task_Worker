namespace TaskWorker
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            panel1 = new Panel();
            Back = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnReset = new Label();
            Exit = new Label();
            rbStakeholder = new RadioButton();
            rbWorker = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Back);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 407);
            panel1.TabIndex = 0;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 3);
            Back.Name = "Back";
            Back.Size = new Size(62, 25);
            Back.TabIndex = 17;
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(396, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "TaskWorker";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(311, 74);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(311, 106);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(259, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(311, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(311, 160);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(377, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LogIn";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Crimson;
            btnReset.Location = new Point(423, 348);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 18);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Crimson;
            Exit.Location = new Point(611, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 25);
            Exit.TabIndex = 8;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // rbStakeholder
            // 
            rbStakeholder.AutoSize = true;
            rbStakeholder.Location = new Point(311, 256);
            rbStakeholder.Name = "rbStakeholder";
            rbStakeholder.Size = new Size(121, 22);
            rbStakeholder.TabIndex = 9;
            rbStakeholder.TabStop = true;
            rbStakeholder.Text = "Stackholder";
            rbStakeholder.UseVisualStyleBackColor = true;
            rbStakeholder.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbWorker
            // 
            rbWorker.AutoSize = true;
            rbWorker.Location = new Point(487, 256);
            rbWorker.Name = "rbWorker";
            rbWorker.Size = new Size(83, 22);
            rbWorker.TabIndex = 10;
            rbWorker.TabStop = true;
            rbWorker.Text = "Worker";
            rbWorker.UseVisualStyleBackColor = true;
            rbWorker.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 242, 232);
            ClientSize = new Size(649, 407);
            Controls.Add(rbWorker);
            Controls.Add(rbStakeholder);
            Controls.Add(Exit);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Label btnReset;
        private Label Exit;
        private PictureBox pictureBox1;
        private RadioButton rbStakeholder;
        private RadioButton rbWorker;
        private Label Back;
    }
}
