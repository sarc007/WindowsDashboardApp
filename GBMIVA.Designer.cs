namespace WindowsDashboardApp
{
    partial class GBMIVA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbmlogo = new System.Windows.Forms.PictureBox();
            this.gbm_usecases_flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbmlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.gbmlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 103);
            this.panel1.TabIndex = 0;
            // 
            // gbmlogo
            // 
            this.gbmlogo.Location = new System.Drawing.Point(0, 0);
            this.gbmlogo.Name = "gbmlogo";
            this.gbmlogo.Size = new System.Drawing.Size(217, 100);
            this.gbmlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gbmlogo.TabIndex = 0;
            this.gbmlogo.TabStop = false;
            // 
            // gbm_usecases_flow_layout
            // 
            this.gbm_usecases_flow_layout.AccessibleName = "gbm_usecases_flow_layout";
            this.gbm_usecases_flow_layout.AutoScroll = true;
            this.gbm_usecases_flow_layout.BackColor = System.Drawing.Color.Black;
            this.gbm_usecases_flow_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbm_usecases_flow_layout.Location = new System.Drawing.Point(0, 103);
            this.gbm_usecases_flow_layout.Name = "gbm_usecases_flow_layout";
            this.gbm_usecases_flow_layout.Size = new System.Drawing.Size(965, 455);
            this.gbm_usecases_flow_layout.TabIndex = 1;
            this.gbm_usecases_flow_layout.Resize += new System.EventHandler(this.gbm_usecases_flow_layout_Resize);
            // 
            // GBMIVA
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbm_usecases_flow_layout);
            this.Controls.Add(this.panel1);
            this.Name = "GBMIVA";
            this.Size = new System.Drawing.Size(965, 558);
            this.Load += new System.EventHandler(this.GBMIVA_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbmlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gbmlogo;
        private System.Windows.Forms.FlowLayoutPanel gbm_usecases_flow_layout;
        //private System.Windows.Forms.Label label1;

    }
}