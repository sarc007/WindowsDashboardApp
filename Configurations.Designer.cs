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
            this.configurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.configuarationtypetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_tblTableAdapter();
            this.configuaration_type_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuaration_type_tblTableAdapter();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.camera_configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfig_type_id = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfig_description = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowconfig_remarks = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowuser_def5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fkcameraconfigtblconfigtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolder_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_ip_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_password_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_port_no_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcamera_active_fid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfig_id_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuarationtypetblBindingSource)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcameraconfigtblconfigtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
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
            // configuarationtypetblBindingSource
            // 
            this.configuarationtypetblBindingSource.DataMember = "configuaration_type_tbl";
            this.configuarationtypetblBindingSource.DataSource = this.dashboardDataSet;
            // 
            // TabControl1
            // 
            this.TabControl1.AccessibleName = "";
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Location = new System.Drawing.Point(32, -1);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(522, 704);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidentified Faces";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "User ID for Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Live Camera Feed IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder Location";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 363);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 31);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(215, 285);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 31);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 31);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "No Camera";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(514, 678);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "No Kids";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // configuration_tblTableAdapter
            // 
            this.configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // configuaration_type_tblTableAdapter
            // 
            this.configuaration_type_tblTableAdapter.ClearBeforeFill = true;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Location = new System.Drawing.Point(586, -1);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.vGridControl1;
            this.controlNavigator1.Size = new System.Drawing.Size(563, 46);
            this.controlNavigator1.TabIndex = 2;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.configurationtblBindingSource;
            this.vGridControl1.Location = new System.Drawing.Point(560, 80);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.vGridControl1.RowHeaderWidth = 192;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowconfig_type_id,
            this.rowconfig_description,
            this.rowconfig_remarks,
            this.rowuser_def1,
            this.rowuser_def2,
            this.rowuser_def3,
            this.rowuser_def4,
            this.rowuser_def5});
            this.vGridControl1.Size = new System.Drawing.Size(614, 106);
            this.vGridControl1.TabIndex = 3;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.CascadingMember = "configuaration_description;configuration_remarks_fld";
            this.repositoryItemGridLookUpEdit1.DataSource = this.configuarationtypetblBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "configuaration_description";
            this.repositoryItemGridLookUpEdit1.KeyMember = "ID";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "ID";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.rowconfig_type_id.Properties.Caption = "Configuration Type";
            this.rowconfig_type_id.Properties.FieldName = "config_type_id";
            this.rowconfig_type_id.Properties.RowEdit = this.repositoryItemGridLookUpEdit1;
            // 
            // rowconfig_description
            // 
            this.rowconfig_description.Name = "rowconfig_description";
            this.rowconfig_description.Properties.Caption = "Description";
            this.rowconfig_description.Properties.FieldName = "config_description";
            // 
            // rowconfig_remarks
            // 
            this.rowconfig_remarks.Name = "rowconfig_remarks";
            this.rowconfig_remarks.Properties.Caption = "Remarks";
            this.rowconfig_remarks.Properties.FieldName = "config_remarks";
            // 
            // rowuser_def1
            // 
            this.rowuser_def1.Name = "rowuser_def1";
            this.rowuser_def1.Properties.Caption = "user_def1";
            this.rowuser_def1.Properties.FieldName = "user_def1";
            this.rowuser_def1.Visible = false;
            // 
            // rowuser_def2
            // 
            this.rowuser_def2.Name = "rowuser_def2";
            this.rowuser_def2.Properties.Caption = "user_def2";
            this.rowuser_def2.Properties.FieldName = "user_def2";
            this.rowuser_def2.Visible = false;
            // 
            // rowuser_def3
            // 
            this.rowuser_def3.Name = "rowuser_def3";
            this.rowuser_def3.Properties.Caption = "user_def3";
            this.rowuser_def3.Properties.FieldName = "user_def3";
            this.rowuser_def3.Visible = false;
            // 
            // rowuser_def4
            // 
            this.rowuser_def4.Name = "rowuser_def4";
            this.rowuser_def4.Properties.Caption = "user_def4";
            this.rowuser_def4.Properties.FieldName = "user_def4";
            this.rowuser_def4.Visible = false;
            // 
            // rowuser_def5
            // 
            this.rowuser_def5.Name = "rowuser_def5";
            this.rowuser_def5.Properties.Caption = "user_def5";
            this.rowuser_def5.Properties.FieldName = "user_def5";
            this.rowuser_def5.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fkcameraconfigtblconfigtblBindingSource;
            this.gridControl1.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            this.gridControl1.Location = new System.Drawing.Point(560, 192);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(614, 200);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // fkcameraconfigtblconfigtblBindingSource
            // 
            this.fkcameraconfigtblconfigtblBindingSource.DataMember = "fk_camera_config_tbl_config_tbl";
            this.fkcameraconfigtblconfigtblBindingSource.DataSource = this.configurationtblBindingSource;
            // 
            // cardView1
            // 
            this.cardView1.Appearance.Card.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cardView1.Appearance.Card.Options.UseFont = true;
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
            // 
            // colconfig_id_fld
            // 
            this.colconfig_id_fld.FieldName = "config_id_fld";
            this.colconfig_id_fld.Name = "colconfig_id_fld";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 753);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.TabControl1);
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configurations_FormClosed);
            this.Load += new System.EventHandler(this.Configurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuarationtypetblBindingSource)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcameraconfigtblconfigtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource configurationtblBindingSource;
        private dashboardDataSetTableAdapters.configuration_tblTableAdapter configuration_tblTableAdapter;
        private System.Windows.Forms.BindingSource configuarationtypetblBindingSource;
        private dashboardDataSetTableAdapters.configuaration_type_tblTableAdapter configuaration_type_tblTableAdapter;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfig_type_id;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfig_description;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowconfig_remarks;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowuser_def5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource fkcameraconfigtblconfigtblBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colfolder_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_ip_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_user_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_password_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_port_no_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colcamera_active_fid;
        private DevExpress.XtraGrid.Columns.GridColumn colconfig_id_fld;
    }
}