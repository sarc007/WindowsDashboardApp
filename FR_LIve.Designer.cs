namespace WindowsDashboardApp
{
    partial class FR_LIve
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.flowLayout_sidepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayout_ip = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.dashboardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraconfigurationtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camera_configuration_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter();
            this.cameraconfigurationtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.flowLayout_sidepanel.SuspendLayout();
            this.flowLayout_ip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.splitContainer2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1453, 815);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayout_ip);
            this.splitContainer2.Panel2.Controls.Add(this.sidePanel1);
            this.splitContainer2.Size = new System.Drawing.Size(701, 550);
            this.splitContainer2.SplitterDistance = 45;
            this.splitContainer2.TabIndex = 5;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.flowLayout_sidepanel);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(348, 501);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // flowLayout_sidepanel
            // 
            this.flowLayout_sidepanel.Controls.Add(this.simpleButton3);
            this.flowLayout_sidepanel.Controls.Add(this.simpleButton4);
            this.flowLayout_sidepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_sidepanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_sidepanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayout_sidepanel.Name = "flowLayout_sidepanel";
            this.flowLayout_sidepanel.Size = new System.Drawing.Size(347, 501);
            this.flowLayout_sidepanel.TabIndex = 0;
            // 
            // flowLayout_ip
            // 
            this.flowLayout_ip.Controls.Add(this.simpleButton5);
            this.flowLayout_ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_ip.Location = new System.Drawing.Point(348, 0);
            this.flowLayout_ip.Name = "flowLayout_ip";
            this.flowLayout_ip.Size = new System.Drawing.Size(353, 501);
            this.flowLayout_ip.TabIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(3, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(115, 49);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Kurla Mall";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(3, 58);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(115, 49);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "Dubai DXB";
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dashboardDataSetBindingSource
            // 
            this.dashboardDataSetBindingSource.DataSource = this.dashboardDataSet;
            this.dashboardDataSetBindingSource.Position = 0;
            // 
            // cameraconfigurationtblBindingSource
            // 
            this.cameraconfigurationtblBindingSource.DataMember = "camera_configuration_tbl";
            this.cameraconfigurationtblBindingSource.DataSource = this.dashboardDataSetBindingSource;
            // 
            // camera_configuration_tblTableAdapter
            // 
            this.camera_configuration_tblTableAdapter.ClearBeforeFill = true;
            // 
            // cameraconfigurationtblBindingSource1
            // 
            this.cameraconfigurationtblBindingSource1.DataMember = "camera_configuration_tbl";
            this.cameraconfigurationtblBindingSource1.DataSource = this.dashboardDataSetBindingSource;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(3, 3);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(213, 125);
            this.simpleButton5.TabIndex = 1;
            this.simpleButton5.Text = "195.229.90.110\r\nadmin\r\nIndia12345\r\n4444\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(263, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face Recognition";
            // 
            // FR_LIve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 815);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FR_LIve";
            this.Text = "FR_LIve";
            this.Load += new System.EventHandler(this.FR_Live_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.flowLayout_sidepanel.ResumeLayout(false);
            this.flowLayout_ip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraconfigurationtblBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_ip;
        private System.Windows.Forms.BindingSource dashboardDataSetBindingSource;
        private dashboardDataSet dashboardDataSet;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_sidepanel;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.BindingSource cameraconfigurationtblBindingSource;
        private dashboardDataSetTableAdapters.camera_configuration_tblTableAdapter camera_configuration_tblTableAdapter;
        private System.Windows.Forms.BindingSource cameraconfigurationtblBindingSource1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label1;
    }
}