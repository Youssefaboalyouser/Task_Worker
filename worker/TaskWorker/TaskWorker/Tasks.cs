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
        private int workerId;
        public wTasks(int workerid)
        {
            this.workerId = workerid;
            InitializeComponent();
        }

        private void Areabtn_Click(object sender, EventArgs e)
        {
            wChoceArea area = new wChoceArea(workerId);
            area.Show();
            this.Hide();
        }

        private void Requestbtn_Click(object sender, EventArgs e)
        {
            wRequest request = new wRequest(workerId);
            request.Show();
            this.Hide();
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots timeSlots = new wTimeSlots(workerId);
            timeSlots.Show();
            this.Hide();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            wUserProfile profile = new wUserProfile(workerId);
            profile.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
