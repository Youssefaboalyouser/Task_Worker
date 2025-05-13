using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWorker
{
    public partial class wRequest : Form
    {
        public wRequest()
        {
            InitializeComponent();
        }

        private void Worker_Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots timeSlots = new wTimeSlots();
            timeSlots.Show();
            this.Hide();
        }

        private void Areabtn_Click(object sender, EventArgs e)
        {
            wChoceArea area = new wChoceArea();
            area.Show();
            this.Hide();
        }

        private void Tasksbtn_Click(object sender, EventArgs e)
        {
            wTasks area = new wTasks();
            area.Show();
            this.Hide();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            wUserProfile profile = new wUserProfile();
            profile.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
