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
    public partial class Cprofile : Form
    {
        public Cprofile()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MRequestbtn_Click(object sender, EventArgs e)
        {
            int clientId = 1;
            Crequest cr = new Crequest(clientId);
            cr.Show();
            this.Hide();
        }

        private void Tasksbtn_Click(object sender, EventArgs e)
        {
            Ctasks ct = new Ctasks();
            ct.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cprofile_Load(object sender, EventArgs e)
        {

        }
    }
}
