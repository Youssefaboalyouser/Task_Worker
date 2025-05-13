namespace TaskWorker
{
    partial class Ctasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctasks));
            panel3 = new Panel();
            Exit = new Label();
            label1 = new Label();
            panel1 = new Panel();
            UProfilebtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            MRequestbtn = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel3.TabIndex = 11;
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
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(UProfilebtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(MRequestbtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 528);
            panel1.TabIndex = 10;
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
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(248, 242, 232);
            button2.Location = new Point(0, 227);
            button2.Name = "button2";
            button2.Size = new Size(233, 37);
            button2.TabIndex = 2;
            button2.Text = "Tasks";
            button2.UseVisualStyleBackColor = false;
            // 
            // MRequestbtn
            // 
            MRequestbtn.BackColor = Color.DarkCyan;
            MRequestbtn.FlatAppearance.BorderColor = Color.White;
            MRequestbtn.FlatAppearance.BorderSize = 0;
            MRequestbtn.FlatStyle = FlatStyle.Flat;
            MRequestbtn.ForeColor = Color.FromArgb(248, 242, 232);
            MRequestbtn.Location = new Point(0, 163);
            MRequestbtn.Name = "MRequestbtn";
            MRequestbtn.Size = new Size(233, 37);
            MRequestbtn.TabIndex = 1;
            MRequestbtn.Text = "Make Request";
            MRequestbtn.UseVisualStyleBackColor = false;
            MRequestbtn.Click += MRequestbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 18F);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(361, 58);
            label7.Name = "label7";
            label7.Size = new Size(430, 29);
            label7.TabIndex = 19;
            label7.Text = "History of previous Executed Tasks";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(673, 275);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(734, 476);
            button7.Name = "button7";
            button7.Size = new Size(154, 40);
            button7.TabIndex = 21;
            button7.Text = "Show Analytics";
            button7.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 424);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 427);
            label2.Name = "label2";
            label2.Size = new Size(270, 18);
            label2.TabIndex = 23;
            label2.Text = "Rating Worker for Selected Task";
            // 
            // Ctasks
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(909, 528);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Ctasks";
            Text = "Client_Tasks";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label Exit;
        private Label label1;
        private Panel panel1;
        private Button UProfilebtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button5;
        private PictureBox pictureBox2;
        private Button button2;
        private Button MRequestbtn;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button7;
        private TextBox textBox1;
        private Label label2;
    }
}