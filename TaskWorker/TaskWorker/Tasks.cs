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
    public partial class wTasks : Form
    {
        public wTasks()
        {
            InitializeComponent();
        }

        private void Areabtn_Click(object sender, EventArgs e)
        {
            wChoceArea area = new wChoceArea();
            area.Show();
            this.Hide();
        }

        private void Requestbtn_Click(object sender, EventArgs e)
        {
            wRequest request = new wRequest();
            request.Show();
            this.Hide();
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots timeSlots = new wTimeSlots();
            timeSlots.Show();
            this.Hide();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            wUserProfile profile = new wUserProfile();
            profile.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
