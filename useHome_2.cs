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
    public partial class useHome_2 : DevExpress.XtraEditors.XtraForm
    {
        public useHome_2()
        {
            InitializeComponent();
        }

        private void useHome_2_Load(object sender, EventArgs e)
        {
            // 
            //Load buttons from Database
            //
            string connetionString = null;
            MySqlConnection cnn;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            string query = "SELECT * FROM configuration_type_tbl;";
            cmd = new MySqlCommand(query, cnn);
            row = cmd.ExecuteReader();
            var count_of_records = 0;
            List<string> buttons = new List<string>();
            List<string> images = new List<string>();

            while (row.Read())
            {
                string col1Value = row["configuration_description_fld"].ToString();
                string col2Value = row["image_path"].ToString();
                buttons.Add(col1Value);
                images.Add(col2Value);
                count_of_records += 1;
            }

            Console.WriteLine("==================================================================");
            foreach(string button in buttons)
            {
                Console.WriteLine(button);
            }

            foreach(string image_path in images)
            {
                Console.WriteLine(image_path);
            }
            Console.WriteLine(count_of_records);

            DevExpress.XtraEditors.PictureEdit[] UseCases = new DevExpress.XtraEditors.PictureEdit[count_of_records];
            DevExpress.Utils.ContextButton[] context_btns = new DevExpress.Utils.ContextButton[count_of_records * 2];
            Guid obj = Guid.NewGuid();
            Guid obj1 = Guid.NewGuid();

            int buttons_count = 0;
            for (int x = 0; x < count_of_records; x++)
            {
                UseCases[x] = new DevExpress.XtraEditors.PictureEdit();
                UseCases[x].Location = new System.Drawing.Point(x + 10, 3);
                UseCases[x].Name = buttons[x].ToString();

                obj = Guid.NewGuid();
                obj1 = Guid.NewGuid();

                //context_btns[buttons_count] = new DevExpress.Utils.ContextButton();
                //context_btns[buttons_count].AnchorAlignment = DevExpress.Utils.AnchorAlignment.Bottom;
                //context_btns[buttons_count].AnchorOffset = new System.Drawing.Point(0, 400);
                //context_btns[buttons_count].Caption = "Offline " + buttons[x].ToString();
                //context_btns[buttons_count].Height = 30;
                //context_btns[buttons_count].Id = new System.Guid(obj.ToString());
                //context_btns[buttons_count].Name = UseCases[x].Name.ToString() + "_Context_btn_1";
                ////context_btns[buttons_count].Padding = new System.Windows.Forms.Padding(0, 270, 0, 0);
                //context_btns[buttons_count].Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
                //context_btns[buttons_count].Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
                //context_btns[buttons_count].Width = 200;

                //context_btns[buttons_count + 1] = new DevExpress.Utils.ContextButton();
                //context_btns[buttons_count + 1].AnchorAlignment = DevExpress.Utils.AnchorAlignment.Bottom;
                //context_btns[buttons_count + 1].AnchorElementId = new System.Guid(obj.ToString());
                //context_btns[buttons_count + 1].Caption = "Live " + buttons[x].ToString();
                //context_btns[buttons_count + 1].Height = 30;
                //context_btns[buttons_count + 1].Id = new System.Guid(obj1.ToString());
                //context_btns[buttons_count + 1].Name = UseCases[x].Name.ToString() + "_Context_btn_2";
                //context_btns[buttons_count + 1].Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
                ////context_btns[buttons_count + 1].Padding = new System.Windows.Forms.Padding(150, 240, 0, 0);
                //context_btns[buttons_count + 1].Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
                //context_btns[buttons_count + 1].Width = 200;

                //UseCases[x].Properties.ContextButtons.Add(context_btns[buttons_count]);
                //UseCases[x].Properties.ContextButtons.Add(context_btns[buttons_count + 1]);
                UseCases[x].Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
                UseCases[x].Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                UseCases[x].Properties.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.UseCases_Properties_ContextButtonClick);
                UseCases[x].Size = new System.Drawing.Size(300, 300);
                UseCases[x].TabIndex = x;
                UseCases[x].Visible = true;
                UseCases[x].Parent = this.flowLayoutPanel1;
                UseCases[x].Image = Image.FromFile(images[x].ToString());
                buttons_count = buttons_count + 2;
            }

            
        }

        private void UseCases_Properties_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            MessageBox.Show(e.Item.Name);
        }
    }
}