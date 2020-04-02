using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDashboardApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Top = button1.Top;
            panelLeft.Height = button1.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Top = button2.Top;
            panelLeft.Height = button2.Height;
            this.Hide();
            Configurations frm = new Configurations();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Top = button3.Top;
            panelLeft.Height = button3.Height;
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            reports form = new reports();
            form.Show();
        }
    }
}
