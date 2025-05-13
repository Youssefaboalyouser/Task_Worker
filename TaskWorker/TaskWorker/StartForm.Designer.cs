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
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(136, 44);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our program";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 41);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSeaGreen;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(619, 7);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 14;
            label5.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(211, 18);
            label2.TabIndex = 13;
            label2.Text = "TaskWorker ProgramV1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(76, 115);
            label3.Name = "label3";
            label3.Size = new Size(503, 18);
            label3.TabIndex = 10;
            label3.Text = "Whether you're building your career or finding the right help";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(27, 149);
            label4.Name = "label4";
            label4.Size = new Size(610, 18);
            label4.TabIndex = 11;
            label4.Text = "TaskWorker is your launchpad to progress, performance, and real results.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(197, 188);
            label6.Name = "label6";
            label6.Size = new Size(213, 18);
            label6.TabIndex = 12;
            label6.Text = "Start your journey today.";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(81, 279);
            button1.Name = "button1";
            button1.Size = new Size(163, 53);
            button1.TabIndex = 13;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(362, 279);
            button2.Name = "button2";
            button2.Size = new Size(153, 53);
            button2.TabIndex = 14;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(649, 407);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}