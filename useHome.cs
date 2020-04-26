using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class useHome : DevExpress.XtraEditors.XtraUserControl
    {
        private static useHome _instance;
        public static useHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new useHome();
                return _instance;
            }
        }
        public useHome()
        {
            InitializeComponent();
        }

        private void useHome_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //MainForm form1 = new MainForm();
            //form1.Hide();
            //this.Hide();
            online_offline form = new online_offline();
            form.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //MainForm form1 = new MainForm();
            //form1.Hide();
            //this.Hide();
            Object_Detectioncs form = new Object_Detectioncs();
            form.Show();
        }
    }
}
