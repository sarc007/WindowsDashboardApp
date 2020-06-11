namespace WindowsDashboardApp
{
    partial class Offline_Violation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offline_Violation));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.show_violation = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayout_video = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.flow_layout_camera = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.sidePanel_violation = new DevExpress.XtraEditors.SidePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.frame = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.side_panel_flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.process1 = new System.Diagnostics.Process();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sidePanel_violation.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.splitContainer1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1167, 698);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.show_violation);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.toDate);
            this.splitContainer1.Panel1.Controls.Add(this.fromDate);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayout_video);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.flow_layout_camera);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.sidePanel_violation);
            this.splitContainer1.Panel2.Controls.Add(this.sidePanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 698);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // show_violation
            // 
            this.show_violation.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_violation.Appearance.Options.UseFont = true;
            this.show_violation.Location = new System.Drawing.Point(824, 67);
            this.show_violation.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.show_violation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.show_violation.Name = "show_violation";
            this.show_violation.Size = new System.Drawing.Size(134, 37);
            this.show_violation.TabIndex = 6;
            this.show_violation.Text = "SHOW VIOLATIONS";
            this.show_violation.Click += new System.EventHandler(this.show_violation_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 41);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "BACK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(257, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(617, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO DATE";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(620, 77);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(124, 20);
            this.toDate.TabIndex = 1;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(260, 77);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(140, 20);
            this.fromDate.TabIndex = 0;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // flowLayout_video
            // 
            this.flowLayout_video.AutoScroll = true;
            this.flowLayout_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayout_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_video.Location = new System.Drawing.Point(165, 427);
            this.flowLayout_video.Name = "flowLayout_video";
            this.flowLayout_video.Size = new System.Drawing.Size(77, 170);
            this.flowLayout_video.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(165, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 36);
            this.label11.TabIndex = 4;
            this.label11.Text = "SELECT VIDEO";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flow_layout_camera
            // 
            this.flow_layout_camera.AutoScroll = true;
            this.flow_layout_camera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flow_layout_camera.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_layout_camera.Location = new System.Drawing.Point(165, 36);
            this.flow_layout_camera.Name = "flow_layout_camera";
            this.flow_layout_camera.Size = new System.Drawing.Size(77, 355);
            this.flow_layout_camera.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(165, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "SELECT CAMERA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidePanel_violation
            // 
            this.sidePanel_violation.Controls.Add(this.panel2);
            this.sidePanel_violation.Controls.Add(this.frame);
            this.sidePanel_violation.Controls.Add(this.tablePanel1);
            this.sidePanel_violation.Controls.Add(this.label5);
            this.sidePanel_violation.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel_violation.Location = new System.Drawing.Point(242, 0);
            this.sidePanel_violation.Name = "sidePanel_violation";
            this.sidePanel_violation.Size = new System.Drawing.Size(925, 597);
            this.sidePanel_violation.TabIndex = 1;
            this.sidePanel_violation.Text = "sidePanel2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(440, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 206);
            this.panel2.TabIndex = 4;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(485, 206);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.LightSkyBlue;
            this.frame.Dock = System.Windows.Forms.DockStyle.Left;
            this.frame.Location = new System.Drawing.Point(1, 391);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(439, 206);
            this.frame.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.AllowTouchScroll = true;
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.04F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.96F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(1, 36);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(924, 355);
            this.tablePanel1.TabIndex = 2;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(924, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "VIOLATION LIST";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.side_panel_flow_layout);
            this.sidePanel1.Controls.Add(this.label4);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(165, 597);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // side_panel_flow_layout
            // 
            this.side_panel_flow_layout.AutoScroll = true;
            this.side_panel_flow_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.side_panel_flow_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.side_panel_flow_layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.side_panel_flow_layout.Location = new System.Drawing.Point(0, 36);
            this.side_panel_flow_layout.Name = "side_panel_flow_layout";
            this.side_panel_flow_layout.Size = new System.Drawing.Size(164, 561);
            this.side_panel_flow_layout.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECT SITE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1167, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Offline_Violation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 729);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Offline_Violation";
            this.Text = "Offline_Violation";
            this.Load += new System.EventHandler(this.Offline_Violation_Load);
            this.SizeChanged += new System.EventHandler(this.Offline_Violation_SizeChanged);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sidePanel_violation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.FlowLayoutPanel side_panel_flow_layout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flow_layout_camera;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SidePanel sidePanel_violation;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton show_violation;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_video;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Diagnostics.Process process1;
    }
}