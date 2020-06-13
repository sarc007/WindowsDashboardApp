﻿using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDashboardApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<int> applist = new List<int>();
        List<int> sitelist = new List<int>();
        List<int> camlist = new List<int>();
        List<int> vidlist = new List<int>();
        List<int> violist = new List<int>();

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.violation_tbl' table. You can move, or remove it, as needed.
            this.violation_tblTableAdapter.Fill(this.dashboardDataSet.violation_tbl);
            ArrayList rows = new ArrayList();
            // TODO: This line of code loads data into the 'dashboardDataSet.videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.Fill(this.dashboardDataSet.videos);
            // TODO: This line of code loads data into the 'dashboardDataSet.camera_configuration_tbl' table. You can move, or remove it, as needed.
            this.camera_configuration_tblTableAdapter.Fill(this.dashboardDataSet.camera_configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_tbl' table. You can move, or remove it, as needed.
            this.configuration_tblTableAdapter.Fill(this.dashboardDataSet.configuration_tbl);
            // TODO: This line of code loads data into the 'dashboardDataSet.configuration_type_tbl' table. You can move, or remove it, as needed.
            this.configuration_type_tblTableAdapter.Fill(this.dashboardDataSet.configuration_type_tbl);


           
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
          
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            
            string str_config_type_id="";
            getlistofAppID();
            for (int i=0;i<applist.Count;i++)
            {
                if (i == 0)
                {
                    str_config_type_id = applist[i].ToString();
                }
                else
                {
                    str_config_type_id = str_config_type_id + ", " + applist[i].ToString() ;
                }

            }
            
            ColumnView view = gridView2;
            /*            if (gridView2.ActiveFilterString.Length > 0)
                        {
                            gridView2.ActiveFilterString = "";
                        }
            */
            //            gridView2.ActiveFilterString = "[config_type_id] in (" + str_config_type_id + ")";
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_type_id"]);
            }
            view.ActiveFilter.Add(view.Columns["config_type_id"],
              new ColumnFilterInfo("[config_type_id] in ("+ str_config_type_id + ")", ""));
        }
        private void getlistofAppID()
        {
            ArrayList rows = new ArrayList();
            applist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
                    DataRow row = rows[i] as DataRow;
                    applist.Add((int)row[0]);

            }
            
        }
        private void getlistofSiteID()
        {
            ArrayList rows = new ArrayList();
            sitelist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView2.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                sitelist.Add((int)row[0]);

            }

        }

        private void getlistofCameraID()
        {
            ArrayList rows = new ArrayList();
            camlist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView3.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView3.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                camlist.Add((int)row[0]);

            }

        }
        private void getlistofVideoID()
        {
            ArrayList rows = new ArrayList();
            vidlist.Clear();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView4.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView4.GetDataRow(selectedRowHandle));
                DataRow row = rows[i] as DataRow;
                vidlist.Add((int)row[0]);

            }

        }
        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            string str_config_id = "";
            getlistofSiteID();
            for (int i = 0; i < sitelist.Count; i++)
            {
                if (i == 0)
                {
                    str_config_id = sitelist[i].ToString();
                }
                else
                {
                    str_config_id = str_config_id + ", " + sitelist[i].ToString();
                }

            }

            ColumnView view = gridView3;
            /*            if (gridView2.ActiveFilterString.Length > 0)
                        {
                            gridView2.ActiveFilterString = "";
                        }
            */
            //            gridView2.ActiveFilterString = "[config_type_id] in (" + str_config_type_id + ")";
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["config_id_fld"]);
            }
            view.ActiveFilter.Add(view.Columns["config_id_fld"],
              new ColumnFilterInfo("[config_id_fld] in (" + str_config_id + ")", ""));

        }
        private void gridView3_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            string str_camera_config_id = "";
            getlistofCameraID();
            for (int i = 0; i < camlist.Count; i++)
            {
                if (i == 0)
                {
                    str_camera_config_id = camlist[i].ToString();
                }
                else
                {
                    str_camera_config_id = str_camera_config_id + ", " + camlist[i].ToString();
                }

            }

            ColumnView view = gridView4;
            /*            if (gridView2.ActiveFilterString.Length > 0)
                        {
                            gridView2.ActiveFilterString = "";
                        }
            */
            //            gridView2.ActiveFilterString = "[config_type_id] in (" + str_config_type_id + ")";
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["camera_config_id"]);
            }
            view.ActiveFilter.Add(view.Columns["camera_config_id"],
              new ColumnFilterInfo("[camera_config_id] in (" + str_camera_config_id + ")", ""));

        }

        private void gridView4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            string str_fk_video_id = "";
            getlistofVideoID();
            for (int i = 0; i < vidlist.Count; i++)
            {
                if (i == 0)
                {
                    str_fk_video_id = vidlist[i].ToString();
                }
                else
                {
                    str_fk_video_id = str_fk_video_id + ", " + vidlist[i].ToString();
                }

            }

            ColumnView view = gridView5;
            /*            if (gridView2.ActiveFilterString.Length > 0)
                        {
                            gridView2.ActiveFilterString = "";
                        }
            */
            //            gridView2.ActiveFilterString = "[config_type_id] in (" + str_config_type_id + ")";
            if (view.ActiveFilterString.Length > 0)
            {
                view.ActiveFilter.Remove(view.Columns["fk_video_id"]);
            }
            view.ActiveFilter.Add(view.Columns["fk_video_id"],
              new ColumnFilterInfo("[fk_video_id] in (" + str_fk_video_id + ")", ""));
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
         
            gridView1.SelectAll();
          
        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
            gridView2.SelectAll();
        }

        private void gridControl3_Load(object sender, EventArgs e)
        {
            gridView3.SelectAll();
        }

        private void gridControl4_Load(object sender, EventArgs e)
        {
            gridView4.SelectAll();
        }

        private void gridControl5_Load(object sender, EventArgs e)
        {
            gridView5.SelectAll();
        }

       
    }
}
