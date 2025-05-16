namespace TaskWorker
{
    partial class wUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wUserProfile));
            panel3 = new Panel();
            Exit = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            Areabtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            Timebtn = new Button();
            Tasksbtn = new Button();
            Requestbtn = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            button15 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button16 = new Button();
            button17 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            panel3.TabIndex = 12;
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
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(Areabtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Timebtn);
            panel1.Controls.Add(Tasksbtn);
            panel1.Controls.Add(Requestbtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 528);
            panel1.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(248, 242, 232);
            button4.Location = new Point(3, 324);
            button4.Name = "button4";
            button4.Size = new Size(233, 37);
            button4.TabIndex = 6;
            button4.Text = "UserProfile";
            button4.UseVisualStyleBackColor = false;
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
            // Requestbtn
            // 
            Requestbtn.BackColor = Color.DarkCyan;
            Requestbtn.FlatAppearance.BorderColor = Color.White;
            Requestbtn.FlatAppearance.BorderSize = 0;
            Requestbtn.FlatStyle = FlatStyle.Flat;
            Requestbtn.ForeColor = Color.FromArgb(248, 242, 232);
            Requestbtn.Location = new Point(0, 132);
            Requestbtn.Name = "Requestbtn";
            Requestbtn.Size = new Size(233, 37);
            Requestbtn.TabIndex = 1;
            Requestbtn.Text = "Requests";
            Requestbtn.UseVisualStyleBackColor = false;
            Requestbtn.Click += Requestbtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(251, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F);
            label2.Location = new Point(640, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 13;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(555, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(253, 226);
            label6.Name = "label6";
            label6.Size = new Size(50, 18);
            label6.TabIndex = 19;
            label6.Text = "Reset";
            // 
            // button15
            // 
            button15.BackColor = Color.LightSeaGreen;
            button15.FlatAppearance.BorderColor = Color.White;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.FromArgb(248, 242, 232);
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(319, 215);
            button15.Name = "button15";
            button15.Size = new Size(148, 37);
            button15.TabIndex = 34;
            button15.Text = "Change Avatar";
            button15.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(743, 226);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 35;
            label7.Text = "Rating:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(815, 227);
            label8.Name = "label8";
            label8.Size = new Size(34, 18);
            label8.TabIndex = 36;
            label8.Text = "2.5";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 16F);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(489, 292);
            label9.Name = "label9";
            label9.Size = new Size(135, 26);
            label9.TabIndex = 37;
            label9.Text = "Specialities";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSeaGreen;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(765, 404);
            button11.Name = "button11";
            button11.Size = new Size(122, 26);
            button11.TabIndex = 45;
            button11.Text = "Cleaner ";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSeaGreen;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(600, 403);
            button12.Name = "button12";
            button12.Size = new Size(122, 26);
            button12.TabIndex = 44;
            button12.Text = "Mechanic ";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LightSeaGreen;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(432, 403);
            button13.Name = "button13";
            button13.Size = new Size(122, 26);
            button13.TabIndex = 43;
            button13.Text = "Welder ";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSeaGreen;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(264, 403);
            button14.Name = "button14";
            button14.Size = new Size(122, 26);
            button14.TabIndex = 42;
            button14.Text = "Mason ";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(765, 345);
            button10.Name = "button10";
            button10.Size = new Size(122, 26);
            button10.TabIndex = 41;
            button10.Text = "Painter ";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSeaGreen;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(600, 345);
            button9.Name = "button9";
            button9.Size = new Size(122, 26);
            button9.TabIndex = 40;
            button9.Text = "Electrician ";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(432, 345);
            button8.Name = "button8";
            button8.Size = new Size(122, 26);
            button8.TabIndex = 39;
            button8.Text = "Plumber";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(264, 345);
            button7.Name = "button7";
            button7.Size = new Size(122, 26);
            button7.TabIndex = 38;
            button7.Text = "Carpenter ";
            button7.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkRed;
            button16.FlatAppearance.BorderColor = Color.White;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.FromArgb(248, 242, 232);
            button16.ImageAlign = ContentAlignment.MiddleLeft;
            button16.Location = new Point(600, 485);
            button16.Name = "button16";
            button16.Size = new Size(110, 37);
            button16.TabIndex = 47;
            button16.Text = "Cancel";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.LightSeaGreen;
            button17.FlatAppearance.BorderColor = Color.White;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.FromArgb(248, 242, 232);
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(435, 485);
            button17.Name = "button17";
            button17.Size = new Size(110, 37);
            button17.TabIndex = 46;
            button17.Text = "Add";
            button17.UseVisualStyleBackColor = false;
            // 
            // wUserProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(909, 528);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button15);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "wUserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfile";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label Exit;
        private Label label1;
        private Panel panel1;
        private Button button4;
        private Button Areabtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button5;
        private PictureBox pictureBox2;
        private Button Timebtn;
        private Button Tasksbtn;
        private Button Requestbtn;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
        private Button button15;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button16;
        private Button button17;
    }
}