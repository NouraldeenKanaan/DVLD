namespace DVLD.Licenses.DetainedLicenses
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.LicenseControls.ctrlDriverLicenseInfoWithFilter();
            this.gbApplicationInfoForLicenseReplacement = new System.Windows.Forms.GroupBox();
            this.tbFineFeesValue = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbDetainIDValue = new System.Windows.Forms.Label();
            this.lbLicenseIDValue = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbDetainDateValue = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.linkLabelLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btDetain = new System.Windows.Forms.Button();
            this.gbApplicationInfoForLicenseReplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(337, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(222, 33);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Detain License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(2, 58);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(896, 387);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 13;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbApplicationInfoForLicenseReplacement
            // 
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.tbFineFeesValue);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox4);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbDetainIDValue);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbLicenseIDValue);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbCreatedByValue);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbDetainDateValue);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbCreatedBy);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox9);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox5);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox6);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox7);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbDetainDate);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbLicenseID);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbFineFees);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbDetainID);
            this.gbApplicationInfoForLicenseReplacement.Location = new System.Drawing.Point(6, 442);
            this.gbApplicationInfoForLicenseReplacement.Name = "gbApplicationInfoForLicenseReplacement";
            this.gbApplicationInfoForLicenseReplacement.Size = new System.Drawing.Size(879, 107);
            this.gbApplicationInfoForLicenseReplacement.TabIndex = 22;
            this.gbApplicationInfoForLicenseReplacement.TabStop = false;
            this.gbApplicationInfoForLicenseReplacement.Text = "Application Info For License Replacement";
            // 
            // tbFineFeesValue
            // 
            this.tbFineFeesValue.Location = new System.Drawing.Point(174, 75);
            this.tbFineFeesValue.Name = "tbFineFeesValue";
            this.tbFineFeesValue.Size = new System.Drawing.Size(159, 20);
            this.tbFineFeesValue.TabIndex = 47;
            this.tbFineFeesValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFineFeesValue_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(645, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // lbDetainIDValue
            // 
            this.lbDetainIDValue.AutoSize = true;
            this.lbDetainIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainIDValue.Location = new System.Drawing.Point(171, 23);
            this.lbDetainIDValue.Name = "lbDetainIDValue";
            this.lbDetainIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbDetainIDValue.TabIndex = 35;
            this.lbDetainIDValue.Text = "N/A";
            // 
            // lbLicenseIDValue
            // 
            this.lbLicenseIDValue.AutoSize = true;
            this.lbLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseIDValue.Location = new System.Drawing.Point(682, 23);
            this.lbLicenseIDValue.Name = "lbLicenseIDValue";
            this.lbLicenseIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbLicenseIDValue.TabIndex = 33;
            this.lbLicenseIDValue.Text = "N/A";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(682, 53);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(29, 15);
            this.lbCreatedByValue.TabIndex = 31;
            this.lbCreatedByValue.Text = "N/A";
            // 
            // lbDetainDateValue
            // 
            this.lbDetainDateValue.AutoSize = true;
            this.lbDetainDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDateValue.Location = new System.Drawing.Point(171, 49);
            this.lbDetainDateValue.Name = "lbDetainDateValue";
            this.lbDetainDateValue.Size = new System.Drawing.Size(29, 15);
            this.lbDetainDateValue.TabIndex = 29;
            this.lbDetainDateValue.Text = "N/A";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(500, 49);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(76, 15);
            this.lbCreatedBy.TabIndex = 24;
            this.lbCreatedBy.Text = "Created By";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox9.Location = new System.Drawing.Point(646, 49);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(19, 19);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(137, 49);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(137, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox7.Location = new System.Drawing.Point(136, 75);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(15, 49);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(83, 15);
            this.lbDetainDate.TabIndex = 16;
            this.lbDetainDate.Text = "Detain Date";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(500, 23);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(75, 15);
            this.lbLicenseID.TabIndex = 14;
            this.lbLicenseID.Text = "License ID";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(14, 75);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(70, 15);
            this.lbFineFees.TabIndex = 13;
            this.lbFineFees.Text = "Fine Fees";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(15, 23);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(67, 15);
            this.lbDetainID.TabIndex = 11;
            this.lbDetainID.Text = "Detain ID";
            // 
            // linkLabelLicensesInfo
            // 
            this.linkLabelLicensesInfo.AutoSize = true;
            this.linkLabelLicensesInfo.Enabled = false;
            this.linkLabelLicensesInfo.Location = new System.Drawing.Point(186, 566);
            this.linkLabelLicensesInfo.Name = "linkLabelLicensesInfo";
            this.linkLabelLicensesInfo.Size = new System.Drawing.Size(95, 13);
            this.linkLabelLicensesInfo.TabIndex = 21;
            this.linkLabelLicensesInfo.TabStop = true;
            this.linkLabelLicensesInfo.Text = "Show License Info";
            this.linkLabelLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicensesInfo_LinkClicked);
            // 
            // linkLabelLicensesHistory
            // 
            this.linkLabelLicensesHistory.AutoSize = true;
            this.linkLabelLicensesHistory.Enabled = false;
            this.linkLabelLicensesHistory.Location = new System.Drawing.Point(38, 566);
            this.linkLabelLicensesHistory.Name = "linkLabelLicensesHistory";
            this.linkLabelLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.linkLabelLicensesHistory.TabIndex = 20;
            this.linkLabelLicensesHistory.TabStop = true;
            this.linkLabelLicensesHistory.Text = "Show Licenses History";
            this.linkLabelLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicensesHistory_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(567, 555);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(118, 34);
            this.btClose.TabIndex = 18;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDetain
            // 
            this.btDetain.Enabled = false;
            this.btDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetain.Image = global::DVLD.Properties.Resources.International_32;
            this.btDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDetain.Location = new System.Drawing.Point(691, 555);
            this.btDetain.Name = "btDetain";
            this.btDetain.Size = new System.Drawing.Size(194, 34);
            this.btDetain.TabIndex = 19;
            this.btDetain.Text = "Detain";
            this.btDetain.UseVisualStyleBackColor = true;
            this.btDetain.Click += new System.EventHandler(this.btDetain_Click);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 596);
            this.Controls.Add(this.gbApplicationInfoForLicenseReplacement);
            this.Controls.Add(this.linkLabelLicensesInfo);
            this.Controls.Add(this.linkLabelLicensesHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDetain);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gbApplicationInfoForLicenseReplacement.ResumeLayout(false);
            this.gbApplicationInfoForLicenseReplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private LicenseControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbApplicationInfoForLicenseReplacement;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbDetainIDValue;
        private System.Windows.Forms.Label lbLicenseIDValue;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbDetainDateValue;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.LinkLabel linkLabelLicensesInfo;
        private System.Windows.Forms.LinkLabel linkLabelLicensesHistory;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDetain;
        private System.Windows.Forms.TextBox tbFineFeesValue;
    }
}