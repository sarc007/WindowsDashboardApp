using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class GBMIVA : DevExpress.XtraEditors.XtraUserControl
    {
        private static GBMIVA _instance;
        public static GBMIVA Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GBMIVA();
                return _instance;
            }
        }
        public GBMIVA()
        {
            InitializeComponent();
        }

        private void GBMIVA_Load(object sender, EventArgs e)
        {
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string query_to_get_btn = "SELECT * FROM gbm_iva where active_fld = 1;";
            cmd = new MySqlCommand(query_to_get_btn, cnn);
            row = cmd.ExecuteReader();

            List<string> gbm_iva_name = new List<string>();
            List<string> gbm_iva_img_path = new List<string>();


            while (row.Read())
            {
                //MessageBox.Show(row["Name"].ToString());
                gbm_iva_name.Add(row["Name"].ToString());
                gbm_iva_img_path.Add(row["Image_path"].ToString());
            }
            row.Close();

            Panel[] use_case_panels = new Panel[gbm_iva_name.Count];
            PictureBox[] use_case_pictures = new PictureBox[gbm_iva_name.Count];

            for (int i  = 0; i < gbm_iva_name.Count; i++)
            {
                use_case_panels[i] = new Panel();
                use_case_panels[i].Margin = new System.Windows.Forms.Padding(50);
                use_case_panels[i].Name = gbm_iva_name[i].ToString();
                use_case_panels[i].Size = new System.Drawing.Size(175, 140);
                use_case_panels[i].TabIndex = i;
                //
                //
                use_case_pictures[i] = new PictureBox();
                use_case_pictures[i].Dock = System.Windows.Forms.DockStyle.Top;
                use_case_pictures[i].Image = Image.FromFile(gbm_iva_img_path[i]);
                use_case_pictures[i].Name = gbm_iva_name[i].ToString();
                use_case_pictures[i].Size = new System.Drawing.Size(175, 100);
                use_case_pictures[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                //use_case_pictures[i].TabIndex = 0;
                use_case_pictures[i].TabStop = false;
                use_case_pictures[i].Click += new System.EventHandler(this.gbm_picture_click);
                use_case_pictures[i].MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
                use_case_pictures[i].MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);


                //
                //
                var temp = new Label();
                temp.Dock = System.Windows.Forms.DockStyle.Bottom;
                temp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                temp.Location = new System.Drawing.Point(0, 98);
                temp.Name = gbm_iva_name[i].ToString();
                temp.Size = new System.Drawing.Size(175, 40);
                temp.Text = gbm_iva_name[i].ToUpper();
                temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                temp.UseMnemonic = false;
                temp.Click += new System.EventHandler(this.gbm_label_click);
                temp.MouseHover += new System.EventHandler(this.label2_MouseHover);
                temp.MouseLeave += new System.EventHandler(this.label2_MouseLeave);


                use_case_panels[i].Controls.Add(use_case_pictures[i]);
                use_case_panels[i].Controls.Add(temp);

                this.gbm_usecases_flow_layout.Controls.Add(use_case_panels[i]);
            }

            //this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.Black;
            (sender as Label).ForeColor = Color.Aqua;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(150, Color.BlueViolet);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString());
            (sender as Label).BackColor = Color.LightYellow;
            (sender as Label).ForeColor = Color.Black;
        }

        private void gbm_label_click(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as Label).Name.ToString());
            UseCases_Form = (sender as Label).Name;
            UseCases_Form ucf = new UseCases_Form();
            ucf.Show();
        }

        public static string UseCases_Form = "";

        private void gbm_picture_click(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as PictureBox).Name.ToString()
            UseCases_Form = (sender as PictureBox).Name;
            UseCases_Form usecases_form = new UseCases_Form();
            usecases_form.Show();

        }



    }
}