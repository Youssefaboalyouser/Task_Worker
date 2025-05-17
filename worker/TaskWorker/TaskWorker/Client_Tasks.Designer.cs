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
            Logoutbtn = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            MRequestbtn = new Button();
            label7 = new Label();
            dgvTasks = new DataGridView();
            Updatebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbStatus = new ComboBox();
            btnDelete = new Button();
            cmbRating = new ComboBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
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
            panel3.Size = new Size(800, 41);
            panel3.TabIndex = 11;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.LightSeaGreen;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(764, 7);
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
            panel2.Controls.Add(Logoutbtn);
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
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Crimson;
            Logoutbtn.FlatAppearance.BorderColor = Color.White;
            Logoutbtn.FlatAppearance.BorderSize = 0;
            Logoutbtn.FlatStyle = FlatStyle.Flat;
            Logoutbtn.ForeColor = Color.FromArgb(248, 242, 232);
            Logoutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Logoutbtn.Location = new Point(75, 26);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(110, 37);
            Logoutbtn.TabIndex = 4;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
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
            button2.Click += button2_Click;
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
            label7.Location = new Point(449, 58);
            label7.Name = "label7";
            label7.Size = new Size(336, 29);
            label7.TabIndex = 19;
            label7.Text = "Published Tasks and Status";
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(236, 112);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.Size = new Size(800, 225);
            dgvTasks.TabIndex = 20;
            dgvTasks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.LightSeaGreen;
            Updatebtn.FlatAppearance.BorderSize = 0;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Location = new Point(446, 481);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(154, 40);
            Updatebtn.TabIndex = 21;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 356);
            label2.Name = "label2";
            label2.Size = new Size(270, 18);
            label2.TabIndex = 23;
            label2.Text = "Rating Worker for Selected Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 401);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 24;
            label3.Text = "Status of Task";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Need Worker", "Finished" });
            cmbStatus.Location = new Point(630, 401);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(235, 26);
            cmbStatus.TabIndex = 43;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(711, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 40);
            btnDelete.TabIndex = 44;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "Excellent", "Very Good", "Good", "Bad", "Very Bad" });
            cmbRating.Location = new Point(630, 348);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(235, 26);
            cmbRating.TabIndex = 45;
            // 
            // Ctasks
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 232);
            ClientSize = new Size(1036, 528);
            Controls.Add(cmbRating);
            Controls.Add(btnDelete);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Updatebtn);
            Controls.Add(dgvTasks);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Ctasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client_Tasks";
            Load += Ctasks_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
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
        private Button Logoutbtn;
        private PictureBox pictureBox2;
        private Button button2;
        private Button MRequestbtn;
        private Label label7;
        private DataGridView dgvTasks;
        private Button Updatebtn;
        private Label label2;
        private Label label3;
        private ComboBox cmbStatus;
        private Button btnDelete;
        private ComboBox cmbRating;
    }
}