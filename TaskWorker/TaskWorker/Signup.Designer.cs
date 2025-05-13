namespace TaskWorker
{
    partial class Worker_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worker_Signup));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 512);
            panel1.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(355, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // textBox2
            // 
            textBox2.Location = new Point(355, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 27);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(355, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(435, 477);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 9;
            label4.Text = "Reset";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(389, 427);
            button1.Name = "button1";
            button1.Size = new Size(145, 35);
            button1.TabIndex = 8;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(636, 9);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 11;
            label5.Text = "X";
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(533, 359);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 22);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Worker";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(296, 359);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 22);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Stackholder";
            radioButton1.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            textBox4.Location = new Point(355, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 14;
            // 
            // Worker_Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 242, 232);
            ClientSize = new Size(674, 512);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Worker_Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private TextBox textBox4;
    }
}