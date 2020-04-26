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
using System.IO;

namespace WindowsDashboardApp
{
    public partial class online_offline : DevExpress.XtraEditors.XtraForm
    {
        public online_offline()
        {
            InitializeComponent();
        }

        private void run_no_photo_script(string file, string filepath)
        {
            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = string.Format("/c python {0} --filepath {1}", file, filepath);
            //process.StartInfo = startInfo;
            //process.Start();
            var proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = string.Format("/c python {0} --filepath {1}", file, filepath);
            proc.Start();
            proc.WaitForExit();
            var exitcode = proc.ExitCode;
            proc.Close();
        }

        private void run_cmd(string cmd, string ip, string user, string password, string port)
        {
            //string strCmdText;
            //strCmdText = string.Format("python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //MessageBox.Show(strCmdText);
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = string.Format("/c python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //process.StartInfo = startInfo;
            //process.Start();

            //var proc = new Process();
            //proc.StartInfo.FileName = "cmd.exe";
            //proc.StartInfo.Arguments = string.Format("/c python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //proc.Start();
            //proc.WaitForExit();
            //var exitcode = proc.ExitCode;
            //proc.Close();

            //Console.WriteLine(cmd);
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = "C:\\Windows\\System32\\cmd.exe";
            //start.Arguments = string.Format("python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //start.UseShellExecute = true;
            //start.RedirectStandardOutput = true;
            ////start.CreateNoWindow = true;
            ////MessageBox.Show(string.Format("python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port));
            ////start.WindowStyle = ProcessWindowStyle.Hidden;
            //using (Process process = Process.Start(start))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //        Console.Write(result);
            //    }
            //}

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = string.Format("python {0} --ip {1} --user {2} --password {3} --port {4}", cmd, ip, user, password, port);
            //process.StartInfo = startInfo;
            //process.Start();
        }


        private void online_offline_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

    


        private void cardView1_Click(object sender, EventArgs e)
        {
            string ip, user, password, port;
            //MessageBox.Show(this.cardView1.GetFocusedRowCellDisplayText("ID"));
            ip = this.cardView1.GetFocusedRowCellDisplayText("camera_ip_fid");
            user = this.cardView1.GetFocusedRowCellDisplayText("camera_user_id");
            password = this.cardView1.GetFocusedRowCellDisplayText("camera_password_fid");
            port = this.cardView1.GetFocusedRowCellDisplayText("camera_port_no_fid");

            //run_cmd("ipcam_local_v2.py", ip, user, password, port);
        }

        private void online_offline_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4|mkv files (*.mkv)|*.mkv|mov files (*.mov)|*.mov";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            
            if(filePath == "")
            {
                MessageBox.Show("Please Choose a video file.");
            }
            else
            {
                run_no_photo_script("no_photo_zone.py", filePath);
            }

            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainForm form = new MainForm();
            //form.Show();
        }
    }
}