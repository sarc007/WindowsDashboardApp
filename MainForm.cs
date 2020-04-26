using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public MainForm()
        {
            InitializeComponent();
            if (!container.Controls.Contains(UseCases_Form.Instance))
            {
                container.Controls.Add(UseCases_Form.Instance);
                UseCases_Form.Instance.Dock = DockStyle.Fill;
                UseCases_Form.Instance.BringToFront();
            }
        }

        private void aceHome_Click(object sender, EventArgs e)
        {
            if(!container.Controls.Contains(UseCases_Form.Instance))
            {
                container.Controls.Add(UseCases_Form.Instance);
                UseCases_Form.Instance.Dock = DockStyle.Fill;
                UseCases_Form.Instance.BringToFront();
            }
            container.Controls.Add(UseCases_Form.Instance);
            UseCases_Form.Instance.Dock = DockStyle.Fill;
            UseCases_Form.Instance.BringToFront();
        }

        private void aceConfig_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Form2.Instance))
            {
                container.Controls.Add(Form2.Instance);
                Form2.Instance.Dock = DockStyle.Fill;
                Form2.Instance.BringToFront();
            }
            Form2.Instance.BringToFront();


        }

        private void aceReports_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(useReports.Instance))
            {
                container.Controls.Add(useReports.Instance);
                useReports.Instance.Dock = DockStyle.Fill;
                useReports.Instance.BringToFront();
            }
            useReports.Instance.BringToFront();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}