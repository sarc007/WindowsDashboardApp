using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class Configurations : Form
    {
        public Configurations()
        {
            InitializeComponent();
        }
        private void update_db()
        {
            this.Validate();
            this.configuration_tblTableAdapter.Update(this.dashboardDataSet);
            this.camera_configuration_tblTableAdapter.Update(this.dashboardDataSet);
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=app_user_ks;pwd=App_user_dxb_ks2020;";
            cnn = new MySqlConnection(connetionString);
            string insertSQL = "INSERT INTO camera_configurations (folder_fid, camera_ip_fid, camera_user_id, camera_password_fid, camera_active_id) VALUES () ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Configurations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.configuaration_type_tbl' table. You can move, or remove it, as needed.
            this.configuaration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuaration_type_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuaration_type_tbl' table. You can move, or remove it, as needed.

            //// TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            //  this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuaration_type_tbl' table. You can move, or remove it, as needed.
            /*this.configuaration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuaration_type_tbl);
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);*/

        }

        private void Configurations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void controlNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType.ToString() != "Append")
            {
                update_db();
            }
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
                || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown)
            {
                update_db();
            }
            if (e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                update_db();
            }
        }

        private void gridControl1_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
                || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown)
            {
                update_db();
            }
            if (e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                update_db();
            }
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
              || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                update_db();
            }
            if (e.KeyCode == Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyCode.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                update_db();
            }
        }

        private void repositoryItemGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
          /*  using (DevExpress.XtraGrid.Views.Grid.GridView view =
                repositoryItemGridLookUpEdit1.Properties as DevExpress.XtraGrid.Views.Grid.GridView)
            {
                object val = view.GetRowCellValue(view.FocusedRowHandle, "column name");
            }*/
        }

        private void gridControl1_EmbeddedNavigator_Leave(object sender, EventArgs e)
        {
            update_db();
        }

        private void configView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            update_db();
        }
    }
}
