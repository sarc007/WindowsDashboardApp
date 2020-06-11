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
        }
        public static int coordionWidth = 0;
        public static int size_width = 0;
        public static int size_height = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
            coordionWidth = accordionControl1.Size.Width;
            size_width = fluentDesignFormControl1.Size.Width;
            size_height = fluentDesignFormControl1.Size.Height;

            this.WindowState = FormWindowState.Maximized;
            if (!container.Controls.Contains(GBMIVA.Instance))
            {
                container.Controls.Add(GBMIVA.Instance);
                GBMIVA.Instance.Dock = DockStyle.Fill;
                GBMIVA.Instance.BringToFront();
            }
        }

        private void aceHome_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            GBMIVA gbm = new GBMIVA();
            gbm.Dock = DockStyle.Fill;
            container.Controls.Add(gbm);

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

        public static int height = SystemInformation.PrimaryMonitorSize.Height;
        public static int width = SystemInformation.PrimaryMonitorSize.Width;

        private void fluentDesignFormControl1_Resize(object sender, EventArgs e)
        {
            this.Height = height;
            this.Width = width;
            //MessageBox.Show(width + ", " + height);
        }

        private void container_Click(object sender, EventArgs e)
        {

        }
    }
}