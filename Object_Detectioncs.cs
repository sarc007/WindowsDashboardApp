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
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace WindowsDashboardApp
{
    public partial class Object_Detectioncs : DevExpress.XtraEditors.XtraForm
    {
        public Object_Detectioncs()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);

        private void Object_Detectioncs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            // this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
        }

        private void run_cmd(string cmd, string ip, string user, string password, string port)
        {
            //var proc = new Process();
            //proc.StartInfo.FileName = "cmd.exe";
            //proc.StartInfo.Arguments = string.Format("/c python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //proc.Start();
            //proc.WaitForExit();
            //var exitcode = proc.ExitCode;
            //proc.Close();

            
            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //process1.StartInfo.FileName = "C:\\Python37\\python.exe";
            process1.StartInfo.FileName = "ipcam_local_v2.py";
            process1.StartInfo.Arguments = string.Format(" --ip {0} --user {1} --password {2} --port {3}", ip, user, password, port);
            //process1.StartInfo = startInfo;
            process1.Start();
            Thread.Sleep(500);
            //process1.WaitForInputIdle(300);
            SetParent(process1.MainWindowHandle,this.splitContainerControl1.Panel2.Handle);
        }

        private void cardView1_Click(object sender, EventArgs e)
        {
            string ip, user, password, port;
            //MessageBox.Show(this.cardView1.GetFocusedRowCellDisplayText("ID"));
            ip = this.cardView1.GetFocusedRowCellDisplayText("camera_ip_fid");
            user = this.cardView1.GetFocusedRowCellDisplayText("camera_user_id");
            password = this.cardView1.GetFocusedRowCellDisplayText("camera_password_fid");
            port = this.cardView1.GetFocusedRowCellDisplayText("camera_port_no_fid");

            run_cmd("ipcam_local_v2.py", ip, user, password, port);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}