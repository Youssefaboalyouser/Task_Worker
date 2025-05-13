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
    public partial class Ctasks : Form
    {
        public Ctasks()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MRequestbtn_Click(object sender, EventArgs e)
        {
            Crequest cr = new Crequest();
            cr.Show();
            this.Hide();
        }

        private void UProfilebtn_Click(object sender, EventArgs e)
        {
            Cprofile cp = new Cprofile();
            cp.Show();
            this.Hide();
        }
    }
}
