using Microsoft.Data.SqlClient;
using System.Data;
namespace TaskWorker
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            Back = new Label();
            pictureBox1 = new PictureBox();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            Resetbtn = new Label();
            SignUpbtn = new Button();
            Exit = new Label();
            label6 = new Label();
            rbWorker = new RadioButton();
            rbStakeholder = new RadioButton();
            label7 = new Label();
            txtConfirm = new TextBox();
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
            panel1.Size = new Size(201, 512);
            panel1.TabIndex = 0;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 9);
            Back.Name = "Back";
            Back.Size = new Size(62, 25);
            Back.TabIndex = 16;
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(355, 90);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(262, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 90);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 151);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 4;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 205);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(355, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 5;
            // 
            // Resetbtn
            // 
            Resetbtn.AutoSize = true;
            Resetbtn.FlatStyle = FlatStyle.Flat;
            Resetbtn.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Resetbtn.ForeColor = Color.Crimson;
            Resetbtn.Location = new Point(435, 477);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(50, 18);
            Resetbtn.TabIndex = 9;
            Resetbtn.Text = "Reset";
            Resetbtn.Click += Resetbtn_Click;
            // 
            // SignUpbtn
            // 
            SignUpbtn.BackColor = Color.Teal;
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.ForeColor = Color.White;
            SignUpbtn.Location = new Point(389, 427);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(145, 35);
            SignUpbtn.TabIndex = 8;
            SignUpbtn.Text = "SignUp";
            SignUpbtn.UseVisualStyleBackColor = false;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Crimson;
            Exit.Location = new Point(636, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 25);
            Exit.TabIndex = 11;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 16F);
            label6.Location = new Point(372, 39);
            label6.Name = "label6";
            label6.Size = new Size(138, 26);
            label6.TabIndex = 10;
            label6.Text = "TaskWorker";
            // 
            // rbWorker
            // 
            rbWorker.AutoSize = true;
            rbWorker.Location = new Point(533, 359);
            rbWorker.Name = "rbWorker";
            rbWorker.Size = new Size(83, 22);
            rbWorker.TabIndex = 13;
            rbWorker.TabStop = true;
            rbWorker.Text = "Worker";
            rbWorker.UseVisualStyleBackColor = true;
            rbWorker.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbStakeholder
            // 
            rbStakeholder.AutoSize = true;
            rbStakeholder.Location = new Point(296, 359);
            rbStakeholder.Name = "rbStakeholder";
            rbStakeholder.Size = new Size(121, 22);
            rbStakeholder.TabIndex = 12;
            rbStakeholder.TabStop = true;
            rbStakeholder.Text = "Stackholder";
            rbStakeholder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 271);
            label7.Name = "label7";
            label7.Size = new Size(71, 18);
            label7.TabIndex = 15;
            label7.Text = "Confirm";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(355, 268);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(261, 27);
            txtConfirm.TabIndex = 14;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 242, 232);
            ClientSize = new Size(674, 512);
            Controls.Add(label7);
            Controls.Add(txtConfirm);
            Controls.Add(rbWorker);
            Controls.Add(rbStakeholder);
            Controls.Add(Exit);
            Controls.Add(label6);
            Controls.Add(Resetbtn);
            Controls.Add(SignUpbtn);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label Resetbtn;
        private Button SignUpbtn;
        private Label Exit;
        private Label label6;
        private RadioButton rbWorker;
        private RadioButton rbStakeholder;
        private Label label7;
        private TextBox txtConfirm;
        private Label Back;
    }
}