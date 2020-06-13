namespace WindowsDashboardApp
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.configurationtypetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconfiguration_description_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.configuration_type_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_type_tblTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.configurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconfiguaration_description_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_tblTableAdapter();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.cameraconfigurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcamera_ip_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.camera_configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videosTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.videosTableAdapter();
            this.colvideo_name_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_datetime_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.configurationtypetblBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(305, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // configurationtypetblBindingSource
            // 
            this.configurationtypetblBindingSource.DataMember = "configuration_type_tbl";
            this.configurationtypetblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconfiguration_description_fld});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colconfiguration_description_fld
            // 
            this.colconfiguration_description_fld.Caption = "Application List";
            this.colconfiguration_description_fld.FieldName = "configuration_description_fld";
            this.colconfiguration_description_fld.Name = "colconfiguration_description_fld";
            this.colconfiguration_description_fld.Visible = true;
            this.colconfiguration_description_fld.VisibleIndex = 1;
            this.colconfiguration_description_fld.Width = 205;
            // 
            // configuration_type_tblTableAdapter
            // 
            this.configuration_type_tblTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.configurationtblBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(313, 12);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(273, 200);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // configurationtblBindingSource
            // 
            this.configurationtblBindingSource.DataMember = "configuration_tbl";
            this.configurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconfiguaration_description_fld});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView2.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // colconfiguaration_description_fld
            // 
            this.colconfiguaration_description_fld.Caption = "Site List";
            this.colconfiguaration_description_fld.FieldName = "configuaration_description_fld";
            this.colconfiguaration_description_fld.Name = "colconfiguaration_description_fld";
            this.colconfiguaration_description_fld.Visible = true;
            this.colconfiguaration_description_fld.VisibleIndex = 1;
            // 
            // configuration_tblTableAdapter
            // 
            this.configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.cameraconfigurationtblBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(592, 12);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(273, 200);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // cameraconfigurationtblBindingSource
            // 
            this.cameraconfigurationtblBindingSource.DataMember = "camera_configuration_tbl";
            this.cameraconfigurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcamera_ip_fid});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView3.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowDetailButtons = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colcamera_ip_fid
            // 
            this.colcamera_ip_fid.FieldName = "camera_ip_fid";
            this.colcamera_ip_fid.Name = "colcamera_ip_fid";
            this.colcamera_ip_fid.Visible = true;
            this.colcamera_ip_fid.VisibleIndex = 1;
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.videosBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(884, 12);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(273, 200);
            this.gridControl4.TabIndex = 3;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvideo_name_fld,
            this.colvideo_datetime_fld});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView4.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView4.OptionsSelection.MultiSelect = true;
            this.gridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowDetailButtons = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "videos";
            this.videosBindingSource.DataSource = this.dashboardDataSet;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // colvideo_name_fld
            // 
            this.colvideo_name_fld.FieldName = "video_name_fld";
            this.colvideo_name_fld.Name = "colvideo_name_fld";
            this.colvideo_name_fld.Visible = true;
            this.colvideo_name_fld.VisibleIndex = 2;
            // 
            // colvideo_datetime_fld
            // 
            this.colvideo_datetime_fld.FieldName = "video_datetime_fld";
            this.colvideo_datetime_fld.Name = "colvideo_datetime_fld";
            this.colvideo_datetime_fld.Visible = true;
            this.colvideo_datetime_fld.VisibleIndex = 1;
            // 
            // gridControl5
            // 
            this.gridControl5.DataSource = this.videosBindingSource;
            this.gridControl5.Location = new System.Drawing.Point(2, 218);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(584, 394);
            this.gridControl5.TabIndex = 4;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView5.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView5.OptionsSelection.MultiSelect = true;
            this.gridView5.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowDetailButtons = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "video_name_fld";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "video_datetime_fld";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 605);
            this.Controls.Add(this.gridControl5);
            this.Controls.Add(this.gridControl4);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource configurationtypetblBindingSource;
        private dashboardDataSetTableAdapters.configuration_type_tblTableAdapter configuration_type_tblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguration_description_fld;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguaration_description_fld;
        private System.Windows.Forms.BindingSource configurationtblBindingSource;
        private dashboardDataSetTableAdapters.configuration_tblTableAdapter configuration_tblTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource cameraconfigurationtblBindingSource;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_ip_fid;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private dashboardDataSetTableAdapters.videosTableAdapter videosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_name_fld;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_datetime_fld;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}