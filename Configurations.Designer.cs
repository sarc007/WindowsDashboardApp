namespace WindowsDashboardApp
{
    partial class Configurations
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.configurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.configurationtypetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_tblTableAdapter();
            this.configuration_type_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_type_tblTableAdapter();
            this.fkcameraconfigtblconfigtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camera_configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfiguration_description_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfiguration_remarks_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage_path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfig_type_id = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfiguaration_description_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfiguration_remarks_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def1_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def2_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def3_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def4_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def5_fld = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.controlNavigator2 = new DevExpress.XtraEditors.ControlNavigator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolder_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_ip_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_password_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_port_no_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_active_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfig_id_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dashboardDataSet1 = new WindowsDashboardApp.dashboardDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcameraconfigtblconfigtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // configurationtblBindingSource
            // 
            this.configurationtblBindingSource.DataMember = "configuration_tbl";
            this.configurationtblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationtypetblBindingSource
            // 
            this.configurationtypetblBindingSource.DataMember = "configuration_type_tbl";
            this.configurationtypetblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // configuration_tblTableAdapter
            // 
            this.configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // configuration_type_tblTableAdapter
            // 
            this.configuration_type_tblTableAdapter.ClearBeforeFill = true;
            // 
            // fkcameraconfigtblconfigtblBindingSource
            // 
            this.fkcameraconfigtblconfigtblBindingSource.DataMember = "fk_camera_config_tbl_config_tbl";
            this.fkcameraconfigtblconfigtblBindingSource.DataSource = this.configurationtblBindingSource;
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainerControl1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.controlNavigator1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(897, 753);
            this.splitContainerControl1.SplitterPosition = 112;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlNavigator1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.controlNavigator1.Appearance.Options.UseBorderColor = true;
            this.controlNavigator1.Appearance.Options.UseForeColor = true;
            this.controlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gridControl2;
            this.controlNavigator1.Size = new System.Drawing.Size(893, 112);
            this.controlNavigator1.TabIndex = 2;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            this.controlNavigator1.Click += new System.EventHandler(this.controlNavigator1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.configurationtypetblBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(893, 191);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colconfiguration_description_fld,
            this.colconfiguration_remarks_fld,
            this.colimage_path,
            this.colactive_fld});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colconfiguration_description_fld
            // 
            this.colconfiguration_description_fld.FieldName = "configuration_description_fld";
            this.colconfiguration_description_fld.Name = "colconfiguration_description_fld";
            this.colconfiguration_description_fld.Visible = true;
            this.colconfiguration_description_fld.VisibleIndex = 1;
            // 
            // colconfiguration_remarks_fld
            // 
            this.colconfiguration_remarks_fld.FieldName = "configuration_remarks_fld";
            this.colconfiguration_remarks_fld.Name = "colconfiguration_remarks_fld";
            this.colconfiguration_remarks_fld.Visible = true;
            this.colconfiguration_remarks_fld.VisibleIndex = 2;
            // 
            // colimage_path
            // 
            this.colimage_path.FieldName = "image_path";
            this.colimage_path.Name = "colimage_path";
            this.colimage_path.Visible = true;
            this.colimage_path.VisibleIndex = 3;
            // 
            // colactive_fld
            // 
            this.colactive_fld.FieldName = "active_fld";
            this.colactive_fld.Name = "colactive_fld";
            this.colactive_fld.Visible = true;
            this.colactive_fld.VisibleIndex = 4;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.dataNavigator1);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Controls.Add(this.vGridControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.controlNavigator2);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(893, 627);
            this.splitContainerControl2.SplitterPosition = 280;
            this.splitContainerControl2.TabIndex = 2;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Location = new System.Drawing.Point(371, 113);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(160, 24);
            this.dataNavigator1.TabIndex = 8;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vGridControl1.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.White;
            this.vGridControl1.Appearance.RowHeaderPanel.Options.UseBackColor = true;
            this.vGridControl1.Appearance.RowHeaderPanel.Options.UseForeColor = true;
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.vGridControl1.CustomizationFormBounds = new System.Drawing.Rectangle(457, 176, 214, 258);
            this.vGridControl1.DataSource = this.configurationtblBindingSource;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vGridControl1.Location = new System.Drawing.Point(0, 191);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsBehavior.AutoFocusNewRecord = true;
            this.vGridControl1.OptionsBehavior.PreserveChildRows = true;
            this.vGridControl1.OptionsBehavior.RecordsMouseWheel = true;
            this.vGridControl1.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.vGridControl1.OptionsView.AllowGlyphSkinning = true;
            this.vGridControl1.OptionsView.AllowHtmlText = true;
            this.vGridControl1.OptionsView.AutoScaleBands = true;
            this.vGridControl1.OptionsView.ShowEmptyRowImage = true;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.vGridControl1.RowHeaderWidth = 192;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowconfig_type_id,
            this.rowconfiguaration_description_fld,
            this.rowconfiguration_remarks_fld,
            this.rowuser_def1_fld,
            this.rowuser_def2_fld,
            this.rowuser_def3_fld,
            this.rowuser_def4_fld,
            this.rowuser_def5_fld});
            this.vGridControl1.Size = new System.Drawing.Size(893, 89);
            this.vGridControl1.TabIndex = 5;
            this.vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar;
            this.vGridControl1.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_EditorKeyPress);
            this.vGridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.configurationtypetblBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "configuration_description_fld";
            this.repositoryItemGridLookUpEdit1.KeyMember = "ID";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView1;
            this.repositoryItemGridLookUpEdit1.ValueMember = "ID";
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // rowID
            // 
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "ID";
            this.rowID.Properties.FieldName = "ID";
            this.rowID.Visible = false;
            // 
            // rowconfig_type_id
            // 
            this.rowconfig_type_id.Name = "rowconfig_type_id";
            this.rowconfig_type_id.Properties.Caption = "Config Type";
            this.rowconfig_type_id.Properties.FieldName = "config_type_id";
            this.rowconfig_type_id.Properties.RowEdit = this.repositoryItemGridLookUpEdit1;
            // 
            // rowconfiguaration_description_fld
            // 
            this.rowconfiguaration_description_fld.Name = "rowconfiguaration_description_fld";
            this.rowconfiguaration_description_fld.Properties.Caption = "Descriptiom";
            this.rowconfiguaration_description_fld.Properties.FieldName = "configuaration_description_fld";
            // 
            // rowconfiguration_remarks_fld
            // 
            this.rowconfiguration_remarks_fld.Name = "rowconfiguration_remarks_fld";
            this.rowconfiguration_remarks_fld.Properties.Caption = "Remarks";
            this.rowconfiguration_remarks_fld.Properties.FieldName = "configuration_remarks_fld";
            // 
            // rowuser_def1_fld
            // 
            this.rowuser_def1_fld.Name = "rowuser_def1_fld";
            this.rowuser_def1_fld.Properties.Caption = "user_def1_fld";
            this.rowuser_def1_fld.Properties.FieldName = "user_def1_fld";
            this.rowuser_def1_fld.Visible = false;
            // 
            // rowuser_def2_fld
            // 
            this.rowuser_def2_fld.Name = "rowuser_def2_fld";
            this.rowuser_def2_fld.Properties.Caption = "user_def2_fld";
            this.rowuser_def2_fld.Properties.FieldName = "user_def2_fld";
            this.rowuser_def2_fld.Visible = false;
            // 
            // rowuser_def3_fld
            // 
            this.rowuser_def3_fld.Name = "rowuser_def3_fld";
            this.rowuser_def3_fld.Properties.Caption = "user_def3_fld";
            this.rowuser_def3_fld.Properties.FieldName = "user_def3_fld";
            this.rowuser_def3_fld.Visible = false;
            // 
            // rowuser_def4_fld
            // 
            this.rowuser_def4_fld.Name = "rowuser_def4_fld";
            this.rowuser_def4_fld.Properties.Caption = "user_def4_fld";
            this.rowuser_def4_fld.Properties.FieldName = "user_def4_fld";
            this.rowuser_def4_fld.Visible = false;
            // 
            // rowuser_def5_fld
            // 
            this.rowuser_def5_fld.Name = "rowuser_def5_fld";
            this.rowuser_def5_fld.Properties.Caption = "user_def5_fld";
            this.rowuser_def5_fld.Properties.FieldName = "user_def5_fld";
            this.rowuser_def5_fld.Visible = false;
            // 
            // controlNavigator2
            // 
            this.controlNavigator2.Location = new System.Drawing.Point(211, 267);
            this.controlNavigator2.Name = "controlNavigator2";
            this.controlNavigator2.Size = new System.Drawing.Size(167, 24);
            this.controlNavigator2.TabIndex = 7;
            this.controlNavigator2.Text = "controlNavigator2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fkcameraconfigtblconfigtblBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(893, 337);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cardView1
            // 
            this.cardView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.CardCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardView1.Appearance.FieldValue.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.cardView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.cardView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.cardView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.cardView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.cardView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.cardView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.cardView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardView1.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.cardView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.cardView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colfolder_fid,
            this.colcamera_ip_fid,
            this.colcamera_user_id,
            this.colcamera_password_fid,
            this.colcamera_port_no_fid,
            this.colcamera_active_fid,
            this.colconfig_id_fld});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colfolder_fid
            // 
            this.colfolder_fid.Caption = "Data Folder";
            this.colfolder_fid.FieldName = "folder_fid";
            this.colfolder_fid.Name = "colfolder_fid";
            this.colfolder_fid.Visible = true;
            this.colfolder_fid.VisibleIndex = 0;
            // 
            // colcamera_ip_fid
            // 
            this.colcamera_ip_fid.Caption = "IP";
            this.colcamera_ip_fid.FieldName = "camera_ip_fid";
            this.colcamera_ip_fid.Name = "colcamera_ip_fid";
            this.colcamera_ip_fid.Visible = true;
            this.colcamera_ip_fid.VisibleIndex = 1;
            // 
            // colcamera_user_id
            // 
            this.colcamera_user_id.Caption = "User ID";
            this.colcamera_user_id.FieldName = "camera_user_id";
            this.colcamera_user_id.Name = "colcamera_user_id";
            this.colcamera_user_id.Visible = true;
            this.colcamera_user_id.VisibleIndex = 2;
            // 
            // colcamera_password_fid
            // 
            this.colcamera_password_fid.Caption = "Password";
            this.colcamera_password_fid.FieldName = "camera_password_fid";
            this.colcamera_password_fid.Name = "colcamera_password_fid";
            this.colcamera_password_fid.Visible = true;
            this.colcamera_password_fid.VisibleIndex = 3;
            // 
            // colcamera_port_no_fid
            // 
            this.colcamera_port_no_fid.Caption = "Port #";
            this.colcamera_port_no_fid.FieldName = "camera_port_no_fid";
            this.colcamera_port_no_fid.Name = "colcamera_port_no_fid";
            this.colcamera_port_no_fid.Visible = true;
            this.colcamera_port_no_fid.VisibleIndex = 4;
            // 
            // colcamera_active_fid
            // 
            this.colcamera_active_fid.Caption = "Active";
            this.colcamera_active_fid.FieldName = "camera_active_fid";
            this.colcamera_active_fid.Name = "colcamera_active_fid";
            this.colcamera_active_fid.Visible = true;
            this.colcamera_active_fid.VisibleIndex = 5;
            this.colcamera_active_fid.Width = 80;
            // 
            // colconfig_id_fld
            // 
            this.colconfig_id_fld.FieldName = "config_id_fld";
            this.colconfig_id_fld.Name = "colconfig_id_fld";
            // 
            // dashboardDataSet1
            // 
            this.dashboardDataSet1.DataSetName = "dashboardDataSet";
            this.dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Configurations
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Configurations";
            this.Size = new System.Drawing.Size(897, 753);
            this.Load += new System.EventHandler(this.Configurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcameraconfigtblconfigtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        
        
        private dashboardDataSetTableAdapters.configuration_type_tblTableAdapter configuaration_type_tblTableAdapter;
        
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource configurationtblBindingSource;
        private dashboardDataSetTableAdapters.configuration_tblTableAdapter configuration_tblTableAdapter;
        private System.Windows.Forms.BindingSource configurationtypetblBindingSource;
        private dashboardDataSetTableAdapters.configuration_type_tblTableAdapter configuration_type_tblTableAdapter;
        private System.Windows.Forms.BindingSource fkcameraconfigtblconfigtblBindingSource;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colfolder_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_ip_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_user_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_password_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_port_no_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_active_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colconfig_id_fld;
        private dashboardDataSet dashboardDataSet1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfig_type_id;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfiguaration_description_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfiguration_remarks_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def1_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def2_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def3_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def4_fld;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def5_fld;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguration_description_fld;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguration_remarks_fld;
        private DevExpress.XtraGrid.Columns.GridColumn colimage_path;
        private DevExpress.XtraGrid.Columns.GridColumn colactive_fld;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator2;
    }
}