namespace DVLD.Licenses.LicenseControls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            this.ctrlDriverLicenseInfo1 = new DVLD.Licenses.LicenseControls.ctrlDriverLicenseInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.tbLicenseIDValue = new System.Windows.Forms.TextBox();
            this.btFindLicense = new System.Windows.Forms.Button();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(3, 80);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(888, 304);
            this.ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btFindLicense);
            this.gbFilter.Controls.Add(this.tbLicenseIDValue);
            this.gbFilter.Controls.Add(this.lbLicenseID);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(888, 72);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(23, 32);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(75, 15);
            this.lbLicenseID.TabIndex = 16;
            this.lbLicenseID.Text = "License ID";
            // 
            // tbLicenseIDValue
            // 
            this.tbLicenseIDValue.Location = new System.Drawing.Point(135, 32);
            this.tbLicenseIDValue.Name = "tbLicenseIDValue";
            this.tbLicenseIDValue.Size = new System.Drawing.Size(245, 20);
            this.tbLicenseIDValue.TabIndex = 17;
            this.tbLicenseIDValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicenseIDValue_KeyPress);
            // 
            // btFindLicense
            // 
            this.btFindLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindLicense.Image = global::DVLD.Properties.Resources.License_View_32;
            this.btFindLicense.Location = new System.Drawing.Point(406, 23);
            this.btFindLicense.Name = "btFindLicense";
            this.btFindLicense.Size = new System.Drawing.Size(41, 37);
            this.btFindLicense.TabIndex = 18;
            this.btFindLicense.UseVisualStyleBackColor = true;
            this.btFindLicense.Click += new System.EventHandler(this.btFindLicense_Click);
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(896, 387);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btFindLicense;
        private System.Windows.Forms.TextBox tbLicenseIDValue;
        private System.Windows.Forms.Label lbLicenseID;
    }
}
