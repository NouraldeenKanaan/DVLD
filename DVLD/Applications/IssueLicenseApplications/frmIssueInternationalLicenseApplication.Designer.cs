namespace DVLD.Applications.InternationalLicenseApplication
{
    partial class frmAddInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInternationalLicense));
            this.lbTitle = new System.Windows.Forms.Label();
            this.btIssue = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.linkLabelLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabelLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.gbInternationalLicenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.lbI_L_ApplicationIDValue = new System.Windows.Forms.Label();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.lbI_LicenseIDValue = new System.Windows.Forms.Label();
            this.lbExpirationDateValue = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbIssueDateValue = new System.Windows.Forms.Label();
            this.lbApplicationDateValue = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lbLocalLicenseID = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbI_LicenseID = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbLocalLicenseIDValue = new System.Windows.Forms.Label();
            this.lbI_L_ApplicationID = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.LicenseControls.ctrlDriverLicenseInfoWithFilter();
            this.gbInternationalLicenseApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(216, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(468, 33);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "International License Application";
            // 
            // btIssue
            // 
            this.btIssue.Enabled = false;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIssue.Image = global::DVLD.Properties.Resources.International_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(722, 582);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(169, 34);
            this.btIssue.TabIndex = 1;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = true;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(602, 582);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(114, 34);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // linkLabelLicensesHistory
            // 
            this.linkLabelLicensesHistory.AutoSize = true;
            this.linkLabelLicensesHistory.Enabled = false;
            this.linkLabelLicensesHistory.Location = new System.Drawing.Point(12, 593);
            this.linkLabelLicensesHistory.Name = "linkLabelLicensesHistory";
            this.linkLabelLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.linkLabelLicensesHistory.TabIndex = 3;
            this.linkLabelLicensesHistory.TabStop = true;
            this.linkLabelLicensesHistory.Text = "Show Licenses History";
            this.linkLabelLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicensesHistory_LinkClicked);
            // 
            // linkLabelLicensesInfo
            // 
            this.linkLabelLicensesInfo.AutoSize = true;
            this.linkLabelLicensesInfo.Enabled = false;
            this.linkLabelLicensesInfo.Location = new System.Drawing.Point(173, 593);
            this.linkLabelLicensesInfo.Name = "linkLabelLicensesInfo";
            this.linkLabelLicensesInfo.Size = new System.Drawing.Size(100, 13);
            this.linkLabelLicensesInfo.TabIndex = 4;
            this.linkLabelLicensesInfo.TabStop = true;
            this.linkLabelLicensesInfo.Text = "Show Licenses Info";
            this.linkLabelLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicensesInfo_LinkClicked);
            // 
            // gbInternationalLicenseApplicationInfo
            // 
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbI_L_ApplicationIDValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbApplicationFeesValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbI_LicenseIDValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbExpirationDateValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbIssueDateValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbApplicationDateValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox10);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox11);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox12);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbLocalLicenseID);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbExpirationDate);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox9);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox5);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox6);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox7);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.pictureBox8);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbIssueDate);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbI_LicenseID);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbLocalLicenseIDValue);
            this.gbInternationalLicenseApplicationInfo.Controls.Add(this.lbI_L_ApplicationID);
            this.gbInternationalLicenseApplicationInfo.Location = new System.Drawing.Point(12, 446);
            this.gbInternationalLicenseApplicationInfo.Name = "gbInternationalLicenseApplicationInfo";
            this.gbInternationalLicenseApplicationInfo.Size = new System.Drawing.Size(879, 130);
            this.gbInternationalLicenseApplicationInfo.TabIndex = 5;
            this.gbInternationalLicenseApplicationInfo.TabStop = false;
            this.gbInternationalLicenseApplicationInfo.Text = "I.L.Application ID";
            // 
            // lbI_L_ApplicationIDValue
            // 
            this.lbI_L_ApplicationIDValue.AutoSize = true;
            this.lbI_L_ApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI_L_ApplicationIDValue.Location = new System.Drawing.Point(171, 23);
            this.lbI_L_ApplicationIDValue.Name = "lbI_L_ApplicationIDValue";
            this.lbI_L_ApplicationIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbI_L_ApplicationIDValue.TabIndex = 35;
            this.lbI_L_ApplicationIDValue.Text = "N/A";
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.AutoSize = true;
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(171, 101);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(29, 15);
            this.lbApplicationFeesValue.TabIndex = 34;
            this.lbApplicationFeesValue.Text = "N/A";
            // 
            // lbI_LicenseIDValue
            // 
            this.lbI_LicenseIDValue.AutoSize = true;
            this.lbI_LicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI_LicenseIDValue.Location = new System.Drawing.Point(660, 23);
            this.lbI_LicenseIDValue.Name = "lbI_LicenseIDValue";
            this.lbI_LicenseIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbI_LicenseIDValue.TabIndex = 33;
            this.lbI_LicenseIDValue.Text = "N/A";
            // 
            // lbExpirationDateValue
            // 
            this.lbExpirationDateValue.AutoSize = true;
            this.lbExpirationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDateValue.Location = new System.Drawing.Point(660, 75);
            this.lbExpirationDateValue.Name = "lbExpirationDateValue";
            this.lbExpirationDateValue.Size = new System.Drawing.Size(29, 15);
            this.lbExpirationDateValue.TabIndex = 32;
            this.lbExpirationDateValue.Text = "N/A";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(660, 101);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(29, 15);
            this.lbCreatedByValue.TabIndex = 31;
            this.lbCreatedByValue.Text = "N/A";
            // 
            // lbIssueDateValue
            // 
            this.lbIssueDateValue.AutoSize = true;
            this.lbIssueDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDateValue.Location = new System.Drawing.Point(171, 75);
            this.lbIssueDateValue.Name = "lbIssueDateValue";
            this.lbIssueDateValue.Size = new System.Drawing.Size(29, 15);
            this.lbIssueDateValue.TabIndex = 30;
            this.lbIssueDateValue.Text = "N/A";
            // 
            // lbApplicationDateValue
            // 
            this.lbApplicationDateValue.AutoSize = true;
            this.lbApplicationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateValue.Location = new System.Drawing.Point(171, 49);
            this.lbApplicationDateValue.Name = "lbApplicationDateValue";
            this.lbApplicationDateValue.Size = new System.Drawing.Size(29, 15);
            this.lbApplicationDateValue.TabIndex = 29;
            this.lbApplicationDateValue.Text = "N/A";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(624, 49);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(19, 19);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(624, 23);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(19, 19);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 27;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox12.Location = new System.Drawing.Point(624, 75);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(19, 19);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 26;
            this.pictureBox12.TabStop = false;
            // 
            // lbLocalLicenseID
            // 
            this.lbLocalLicenseID.AutoSize = true;
            this.lbLocalLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseID.Location = new System.Drawing.Point(500, 49);
            this.lbLocalLicenseID.Name = "lbLocalLicenseID";
            this.lbLocalLicenseID.Size = new System.Drawing.Size(114, 15);
            this.lbLocalLicenseID.TabIndex = 25;
            this.lbLocalLicenseID.Text = "Local License ID";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(500, 101);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(76, 15);
            this.lbCreatedBy.TabIndex = 24;
            this.lbCreatedBy.Text = "Created By";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(500, 75);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(106, 15);
            this.lbExpirationDate.TabIndex = 23;
            this.lbExpirationDate.Text = "Expiration Date";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pictureBox9.Location = new System.Drawing.Point(624, 101);
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
            this.pictureBox7.Location = new System.Drawing.Point(137, 101);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pictureBox8.Location = new System.Drawing.Point(137, 75);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(15, 49);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(112, 15);
            this.lbApplicationDate.TabIndex = 16;
            this.lbApplicationDate.Text = "Application Date";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(15, 75);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(75, 15);
            this.lbIssueDate.TabIndex = 15;
            this.lbIssueDate.Text = "Issue Date";
            // 
            // lbI_LicenseID
            // 
            this.lbI_LicenseID.AutoSize = true;
            this.lbI_LicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI_LicenseID.Location = new System.Drawing.Point(500, 23);
            this.lbI_LicenseID.Name = "lbI_LicenseID";
            this.lbI_LicenseID.Size = new System.Drawing.Size(83, 15);
            this.lbI_LicenseID.TabIndex = 14;
            this.lbI_LicenseID.Text = "I.License ID";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(15, 101);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(38, 15);
            this.lbApplicationFees.TabIndex = 13;
            this.lbApplicationFees.Text = "Fees";
            // 
            // lbLocalLicenseIDValue
            // 
            this.lbLocalLicenseIDValue.AutoSize = true;
            this.lbLocalLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseIDValue.Location = new System.Drawing.Point(660, 49);
            this.lbLocalLicenseIDValue.Name = "lbLocalLicenseIDValue";
            this.lbLocalLicenseIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbLocalLicenseIDValue.TabIndex = 12;
            this.lbLocalLicenseIDValue.Text = "N/A";
            // 
            // lbI_L_ApplicationID
            // 
            this.lbI_L_ApplicationID.AutoSize = true;
            this.lbI_L_ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI_L_ApplicationID.Location = new System.Drawing.Point(15, 23);
            this.lbI_L_ApplicationID.Name = "lbI_L_ApplicationID";
            this.lbI_L_ApplicationID.Size = new System.Drawing.Size(116, 15);
            this.lbI_L_ApplicationID.TabIndex = 11;
            this.lbI_L_ApplicationID.Text = "I.L.Application ID";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(3, 56);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(896, 387);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 623);
            this.Controls.Add(this.gbInternationalLicenseApplicationInfo);
            this.Controls.Add(this.linkLabelLicensesInfo);
            this.Controls.Add(this.linkLabelLicensesHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddInternationalLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.frmAddInternationalLicense_Load);
            this.gbInternationalLicenseApplicationInfo.ResumeLayout(false);
            this.gbInternationalLicenseApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.LicenseControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel linkLabelLicensesHistory;
        private System.Windows.Forms.LinkLabel linkLabelLicensesInfo;
        private System.Windows.Forms.GroupBox gbInternationalLicenseApplicationInfo;
        private System.Windows.Forms.Label lbI_L_ApplicationIDValue;
        private System.Windows.Forms.Label lbApplicationFeesValue;
        private System.Windows.Forms.Label lbI_LicenseIDValue;
        private System.Windows.Forms.Label lbExpirationDateValue;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbIssueDateValue;
        private System.Windows.Forms.Label lbApplicationDateValue;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lbLocalLicenseID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbI_LicenseID;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbLocalLicenseIDValue;
        private System.Windows.Forms.Label lbI_L_ApplicationID;
    }
}