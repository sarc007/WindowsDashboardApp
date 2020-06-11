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
    public partial class Dummy_Form : DevExpress.XtraEditors.XtraForm
    {
        public Dummy_Form()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedComboBoxEdit1_Properties_MouseHover(object sender, EventArgs e)
        {
            //checkedListBox1.SetItemChecked(checkedComboBoxEdit1);
        }

        private void Dummy_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_type_tbl' table. You can move, or remove it, as needed.
            this.configuration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuration_type_tbl);

        }
    }
}