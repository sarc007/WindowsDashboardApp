namespace WindowsDashboardApp
{
    partial class online_offline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(online_offline));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cameraconfigurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolder_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_ip_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_password_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_port_no_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_active_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dashboardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camera_configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.dashboardDataSet1 = new WindowsDashboardApp.dashboardDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1167, 718);
            this.splitContainerControl1.SplitterPosition = 45;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(102)))), ((int)(((byte)(168)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(0, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 45);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "HOME";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cameraconfigurationtblBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 9);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 631);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cameraconfigurationtblBindingSource
            // 
            this.cameraconfigurationtblBindingSource.DataMember = "camera_configuration_tbl";
            this.cameraconfigurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colfolder_fid,
            this.colcamera_ip_fid,
            this.colcamera_user_id,
            this.colcamera_password_fid,
            this.colcamera_port_no_fid,
            this.colcamera_active_fid});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.Click += new System.EventHandler(this.cardView1_Click);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colfolder_fid
            // 
            this.colfolder_fid.FieldName = "folder_fid";
            this.colfolder_fid.Name = "colfolder_fid";
            this.colfolder_fid.Visible = true;
            this.colfolder_fid.VisibleIndex = 1;
            // 
            // colcamera_ip_fid
            // 
            this.colcamera_ip_fid.FieldName = "camera_ip_fid";
            this.colcamera_ip_fid.Name = "colcamera_ip_fid";
            this.colcamera_ip_fid.Visible = true;
            this.colcamera_ip_fid.VisibleIndex = 2;
            // 
            // colcamera_user_id
            // 
            this.colcamera_user_id.FieldName = "camera_user_id";
            this.colcamera_user_id.Name = "colcamera_user_id";
            this.colcamera_user_id.Visible = true;
            this.colcamera_user_id.VisibleIndex = 3;
            // 
            // colcamera_password_fid
            // 
            this.colcamera_password_fid.FieldName = "camera_password_fid";
            this.colcamera_password_fid.Name = "colcamera_password_fid";
            this.colcamera_password_fid.Visible = true;
            this.colcamera_password_fid.VisibleIndex = 4;
            // 
            // colcamera_port_no_fid
            // 
            this.colcamera_port_no_fid.FieldName = "camera_port_no_fid";
            this.colcamera_port_no_fid.Name = "colcamera_port_no_fid";
            this.colcamera_port_no_fid.Visible = true;
            this.colcamera_port_no_fid.VisibleIndex = 5;
            // 
            // colcamera_active_fid
            // 
            this.colcamera_active_fid.FieldName = "camera_active_fid";
            this.colcamera_active_fid.Name = "colcamera_active_fid";
            this.colcamera_active_fid.Visible = true;
            this.colcamera_active_fid.VisibleIndex = 6;
            // 
            // dashboardDataSetBindingSource
            // 
            this.dashboardDataSetBindingSource.DataSource = this.dashboardDataSet;
            this.dashboardDataSetBindingSource.Position = 0;
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // dashboardDataSet1
            // 
            this.dashboardDataSet1.DataSetName = "dashboardDataSet";
            this.dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // online_offline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 762);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "online_offline";
            this.Text = "online_offline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.online_offline_FormClosed);
            this.Load += new System.EventHandler(this.online_offline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource dashboardDataSetBindingSource;
        private dashboardDataSet dashboardDataSet;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.BindingSource cameraconfigurationtblBindingSource;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colfolder_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_ip_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_user_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_password_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_port_no_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_active_fid;
        private dashboardDataSet dashboardDataSet1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}