namespace DVLD.Licenses.LicenseControls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDriverLicense = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbLocal = new System.Windows.Forms.TabPage();
            this.lbLocalRecordsValue = new System.Windows.Forms.Label();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbLocalRecords = new System.Windows.Forms.Label();
            this.lbLocalLicenseHistory = new System.Windows.Forms.Label();
            this.tbInternational = new System.Windows.Forms.TabPage();
            this.lbInternationalRecordsValue = new System.Windows.Forms.Label();
            this.lbInternationalRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbInternationalLicenseHistory = new System.Windows.Forms.Label();
            this.gbDriverLicense.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.cmsLocalLicenses.SuspendLayout();
            this.tbInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicense
            // 
            this.gbDriverLicense.Controls.Add(this.tabControl1);
            this.gbDriverLicense.Location = new System.Drawing.Point(3, 3);
            this.gbDriverLicense.Name = "gbDriverLicense";
            this.gbDriverLicense.Size = new System.Drawing.Size(987, 267);
            this.gbDriverLicense.TabIndex = 4;
            this.gbDriverLicense.TabStop = false;
            this.gbDriverLicense.Text = "Driver License";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbLocal);
            this.tabControl1.Controls.Add(this.tbInternational);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 242);
            this.tabControl1.TabIndex = 0;
            // 
            // tbLocal
            // 
            this.tbLocal.Controls.Add(this.lbLocalRecordsValue);
            this.tbLocal.Controls.Add(this.dgvLocalLicenses);
            this.tbLocal.Controls.Add(this.lbLocalRecords);
            this.tbLocal.Controls.Add(this.lbLocalLicenseHistory);
            this.tbLocal.Location = new System.Drawing.Point(4, 22);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocal.Size = new System.Drawing.Size(966, 216);
            this.tbLocal.TabIndex = 0;
            this.tbLocal.Text = "Local";
            this.tbLocal.UseVisualStyleBackColor = true;
            // 
            // lbLocalRecordsValue
            // 
            this.lbLocalRecordsValue.AutoSize = true;
            this.lbLocalRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecordsValue.Location = new System.Drawing.Point(89, 191);
            this.lbLocalRecordsValue.Name = "lbLocalRecordsValue";
            this.lbLocalRecordsValue.Size = new System.Drawing.Size(15, 15);
            this.lbLocalRecordsValue.TabIndex = 5;
            this.lbLocalRecordsValue.Text = "0";
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.cmsLocalLicenses;
            this.dgvLocalLicenses.GridColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(10, 38);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(950, 150);
            this.dgvLocalLicenses.TabIndex = 6;
            // 
            // cmsLocalLicenses
            // 
            this.cmsLocalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenses.Name = "cmsLocalLicenses";
            this.cmsLocalLicenses.Size = new System.Drawing.Size(170, 26);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // lbLocalRecords
            // 
            this.lbLocalRecords.AutoSize = true;
            this.lbLocalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecords.Location = new System.Drawing.Point(7, 191);
            this.lbLocalRecords.Name = "lbLocalRecords";
            this.lbLocalRecords.Size = new System.Drawing.Size(76, 15);
            this.lbLocalRecords.TabIndex = 4;
            this.lbLocalRecords.Text = "# Records:";
            // 
            // lbLocalLicenseHistory
            // 
            this.lbLocalLicenseHistory.AutoSize = true;
            this.lbLocalLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseHistory.Location = new System.Drawing.Point(7, 12);
            this.lbLocalLicenseHistory.Name = "lbLocalLicenseHistory";
            this.lbLocalLicenseHistory.Size = new System.Drawing.Size(144, 15);
            this.lbLocalLicenseHistory.TabIndex = 5;
            this.lbLocalLicenseHistory.Text = "Local License History";
            // 
            // tbInternational
            // 
            this.tbInternational.Controls.Add(this.lbInternationalRecordsValue);
            this.tbInternational.Controls.Add(this.lbInternationalRecords);
            this.tbInternational.Controls.Add(this.label1);
            this.tbInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tbInternational.Controls.Add(this.lbInternationalLicenseHistory);
            this.tbInternational.Location = new System.Drawing.Point(4, 22);
            this.tbInternational.Name = "tbInternational";
            this.tbInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternational.Size = new System.Drawing.Size(966, 216);
            this.tbInternational.TabIndex = 1;
            this.tbInternational.Text = "International";
            this.tbInternational.UseVisualStyleBackColor = true;
            // 
            // lbInternationalRecordsValue
            // 
            this.lbInternationalRecordsValue.AutoSize = true;
            this.lbInternationalRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecordsValue.Location = new System.Drawing.Point(89, 190);
            this.lbInternationalRecordsValue.Name = "lbInternationalRecordsValue";
            this.lbInternationalRecordsValue.Size = new System.Drawing.Size(15, 15);
            this.lbInternationalRecordsValue.TabIndex = 11;
            this.lbInternationalRecordsValue.Text = "0";
            // 
            // lbInternationalRecords
            // 
            this.lbInternationalRecords.AutoSize = true;
            this.lbInternationalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecords.Location = new System.Drawing.Point(7, 190);
            this.lbInternationalRecords.Name = "lbInternationalRecords";
            this.lbInternationalRecords.Size = new System.Drawing.Size(76, 15);
            this.lbInternationalRecords.TabIndex = 10;
            this.lbInternationalRecords.Text = "# Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "# Records:";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicenses;
            this.dgvInternationalLicenses.GridColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(7, 37);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(950, 150);
            this.dgvInternationalLicenses.TabIndex = 9;
            // 
            // cmsInternationalLicenses
            // 
            this.cmsInternationalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternationalLicenseInfoToolStripMenuItem});
            this.cmsInternationalLicenses.Name = "cmsInternationalLicenses";
            this.cmsInternationalLicenses.Size = new System.Drawing.Size(240, 26);
            // 
            // showInternationalLicenseInfoToolStripMenuItem
            // 
            this.showInternationalLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showInternationalLicenseInfoToolStripMenuItem.Name = "showInternationalLicenseInfoToolStripMenuItem";
            this.showInternationalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.showInternationalLicenseInfoToolStripMenuItem.Text = "Show International License Info";
            this.showInternationalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showInternationalLicenseInfoToolStripMenuItem_Click);
            // 
            // lbInternationalLicenseHistory
            // 
            this.lbInternationalLicenseHistory.AutoSize = true;
            this.lbInternationalLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalLicenseHistory.Location = new System.Drawing.Point(7, 11);
            this.lbInternationalLicenseHistory.Name = "lbInternationalLicenseHistory";
            this.lbInternationalLicenseHistory.Size = new System.Drawing.Size(190, 15);
            this.lbInternationalLicenseHistory.TabIndex = 8;
            this.lbInternationalLicenseHistory.Text = "International License History";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicense);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(995, 273);
            this.gbDriverLicense.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbLocal.ResumeLayout(false);
            this.tbLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.cmsLocalLicenses.ResumeLayout(false);
            this.tbInternational.ResumeLayout(false);
            this.tbInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicense;
        private System.Windows.Forms.Label lbLocalRecordsValue;
        private System.Windows.Forms.Label lbLocalRecords;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbLocal;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.Label lbLocalLicenseHistory;
        private System.Windows.Forms.TabPage tbInternational;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lbInternationalLicenseHistory;
        private System.Windows.Forms.Label lbInternationalRecordsValue;
        private System.Windows.Forms.Label lbInternationalRecords;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseInfoToolStripMenuItem;
    }
}
