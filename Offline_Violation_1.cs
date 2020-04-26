using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsDashboardApp
{
    public partial class Offline_Violation_1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Offline_Violation_1()
        {
            InitializeComponent();
        }

        private void Offline_Violation_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet1.offline_violation_tbl' table. You can move, or remove it, as needed.
            var y = "";
            var m = "";
            var d = "";
            this.offline_violation_tblTableAdapter.Fill(this.dashboardDataSet1.offline_violation_tbl);
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlDataReader row2;
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            cnn.Open();

            string query_violation_calender = "SELECT violation_year, violation_month, violation_date from offline_violation_tbl;";
            //MessageBox.Show(query_config_type);
            cmd1 = new MySqlCommand(query_violation_calender, cnn);
            row = cmd1.ExecuteReader();

            while (row.Read())
            {
                y = row["violation_year"].ToString();
                m = row["violation_month"].ToString();
                d = row["violation_day"].ToString();
            }
            row.Close();
        }
    }
}
