namespace WindowsDashboardApp
{
    partial class Dummy_Form
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dashboardDataSet = new WindowsDashboardApp.dashboardDataSet();
            this.configurationtypetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuration_type_tblTableAdapter = new WindowsDashboardApp.dashboardDataSetTableAdapters.configuration_type_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Dummy"});
            this.checkedListBox1.Location = new System.Drawing.Point(468, 82);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(93, 82);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DataSource = this.configurationtypetblBindingSource;
            this.checkedComboBoxEdit1.Properties.DisplayMember = "configuration_description_fld";
            this.checkedComboBoxEdit1.Properties.ValueMember = "ID";
            this.checkedComboBoxEdit1.Properties.MouseHover += new System.EventHandler(this.checkedComboBoxEdit1_Properties_MouseHover);
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit1.TabIndex = 1;
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
            // configuration_type_tblTableAdapter
            // 
            this.configuration_type_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Dummy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 512);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Dummy_Form";
            this.Text = "Dummy_Form";
            this.Load += new System.EventHandler(this.Dummy_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationtypetblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private dashboardDataSet dashboardDataSet;
        private System.Windows.Forms.BindingSource configurationtypetblBindingSource;
        private dashboardDataSetTableAdapters.configuration_type_tblTableAdapter configuration_type_tblTableAdapter;
    }
}