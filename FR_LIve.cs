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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsDashboardApp
{
    public partial class FR_LIve : DevExpress.XtraEditors.XtraForm
    {
        public FR_LIve()
        {
            InitializeComponent();
        }

        private void FR_Live_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);

            string connetionString = null;
            MySqlConnection cnn;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string query = "SELECT * FROM configuration_tbl WHERE config_type_id = 1;";
            cmd = new MySqlCommand(query, cnn);
            row = cmd.ExecuteReader();
            var rows = 0;
            List<string> buttons = new List<string>();
            int count_of_records = 3;
            DevExpress.XtraEditors.PictureEdit[] UseCases = new DevExpress.XtraEditors.PictureEdit[count_of_records];
            SimpleButton[] simple_btns = new SimpleButton[count_of_records * 2];
            Guid obj = Guid.NewGuid();
            Guid obj1 = Guid.NewGuid();

            int buttons_count = 0;
            for (int x=0;x<count_of_records;x++) {
                UseCases[x] = new DevExpress.XtraEditors.PictureEdit();
                UseCases[x].Location = new System.Drawing.Point(x+10, 3);
                simple_btns[buttons_count] = new SimpleButton();
                simple_btns[buttons_count+1] = new SimpleButton();
                UseCases[x].Name = "Face Recognition_UseCase_" + ((x+1).ToString());
                simple_btns[buttons_count].Text = "Offline Face Recognition";
                simple_btns[buttons_count+1].Text = "Live Face Recognition";
                obj = Guid.NewGuid();
                obj1 = Guid.NewGuid();
             /*   simple_btns[buttons_count].Id = new System.Guid(obj.ToString());
                simple_btns[buttons_count+1].Id = new System.Guid(obj1.ToString());*/
                simple_btns[buttons_count].Name = UseCases[x].Name.ToString() + "_Context_btn_1";
                simple_btns[buttons_count+1].Name = UseCases[x].Name.ToString() + "_Context_btn_2";
                
                /*UseCases[x].Properties.ContextButtons.Add(simple_btns[buttons_count]);
                UseCases[x].Properties.ContextButtons.Add(simple_btns[buttons_count+1]);
                */
                UseCases[x].Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
                UseCases[x].Size = new System.Drawing.Size(100, 96);
                UseCases[x].TabIndex = x;
                
                UseCases[x].Visible = true;
                UseCases[x].Parent = this.flowLayoutPanel1;
                UseCases[x].Image = Image.FromFile("E:\\WindowsDashboardApp_sarc\\WindowsDashboardApp\\fr_img.jpg");
                UseCases[x].Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                simple_btns[buttons_count].Parent = this.flowLayoutPanel1;
                simple_btns[buttons_count + 1].Parent = this.flowLayoutPanel1;
                simple_btns[buttons_count].Left = UseCases[x].Left;
                simple_btns[buttons_count+1].Left = UseCases[x].Left;
                simple_btns[buttons_count].Height = 50;
                simple_btns[buttons_count + 1].Height = 50;
                simple_btns[buttons_count].Top = UseCases[x].Top+UseCases[x].Height+5;
                simple_btns[buttons_count + 1].Top = simple_btns[buttons_count].Top+ simple_btns[buttons_count].Height+3;


                simple_btns[buttons_count + 1].Visible = true;
                simple_btns[buttons_count].Visible = true;
                simple_btns[buttons_count + 1].Visible = true;
                //simple_btns[buttons_count].Click += new SimpleButton.EventHandler(this.UseCases_Properties_ContextButtonClick);
                simple_btns[buttons_count].Click += new EventHandler(this.UseCases_Properties_ContextButtonClick);
                buttons_count = buttons_count + 2;
            }

            while (row.Read())
            {
                string col1Value = row["configuaration_description_fld"].ToString();
                buttons.Add(col1Value);
                rows += 1;
            }

            //Console.WriteLine("[INFO] " + rows.ToString());
            //MessageBox.Show("[INFO] " + rows.ToString());

            //foreach (string btn in buttons)
            //{

            //    Button b = addbutton(btn);
            //    flowLayoutPanel1.Controls.Add(b);
            //}
        }
       
        Button addbutton(string name)
        {
            Button b = new Button();
            b.Name = name;
            b.Text = name;
            b.ForeColor = Color.Gray;
            b.BackColor = Color.Black;
            b.Width = 300;
            b.Height = 60;
            b.Font = new Font("Serif", 24, FontStyle.Italic);
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Margin = new Padding(5);

            return b;
        }

        private void pictureEdit1_Properties_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            MessageBox.Show(e.Item.Name);
        }

        private void UseCases_Properties_ContextButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("working");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Paint(object sender, PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}