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
    public partial class wUserProfile : Form
    {
        public wUserProfile()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Requestbtn_Click(object sender, EventArgs e)
        {
            wRequest request = new wRequest();
            request.Show();
            this.Hide();
        }

        private void Timebtn_Click(object sender, EventArgs e)
        {
            wTimeSlots time = new wTimeSlots();
            time.Show();
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
            wTasks tasks = new wTasks();
            tasks.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
