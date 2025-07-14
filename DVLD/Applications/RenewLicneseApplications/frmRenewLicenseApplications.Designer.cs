namespace DVLD.Applications.LocalDrivingLicenseApplication
{
    partial class frmRenewLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicenseApplications));
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.LicenseControls.ctrlDriverLicenseInfoWithFilter();
            this.gbApplicationRenewLicenseInfo = new System.Windows.Forms.GroupBox();
            this.pbRenewedLicenseID = new System.Windows.Forms.PictureBox();
            this.lbTotalFeesValue = new System.Windows.Forms.Label();
            this.pbTotalFees = new System.Windows.Forms.PictureBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.tbNotesValue = new System.Windows.Forms.TextBox();
            this.pbNotes = new System.Windows.Forms.PictureBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbLicenseFeesValue = new System.Windows.Forms.Label();
            this.pbLicenseFees = new System.Windows.Forms.PictureBox();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.lbR_L_ApplicationIDValue = new System.Windows.Forms.Label();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.lbRenewedLicenseIDValue = new System.Windows.Forms.Label();
            this.lbExpirationDateValue = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbIssueDateValue = new System.Windows.Forms.Label();
            this.lbApplicationDateValue = new System.Windows.Forms.Label();
            this.pbOldLicenseID = new System.Windows.Forms.PictureBox();
            this.pbExpirationDate = new System.Windows.Forms.PictureBox();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.pbR_L_ApplicationID = new System.Windows.Forms.PictureBox();
            this.pbApplicationFees = new System.Windows.Forms.PictureBox();
            this.pbIssueDate = new System.Windows.Forms.PictureBox();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbRenewedLicenseID = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lbR_L_ApplicationID = new System.Windows.Forms.Label();
            this.linkLabelRenewLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btRenew = new System.Windows.Forms.Button();
            this.gbApplicationRenewLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenewedLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpirationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR_L_ApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssueDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(247, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(390, 33);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Renew License Application";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(4, 45);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(896, 389);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 3;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbApplicationRenewLicenseInfo
            // 
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbRenewedLicenseID);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbTotalFeesValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbTotalFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbTotalFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.tbNotesValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbNotes);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbNotes);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbLicenseFeesValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbLicenseFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbLicenseFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbR_L_ApplicationIDValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbApplicationFeesValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbRenewedLicenseIDValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbExpirationDateValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbCreatedByValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbIssueDateValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbApplicationDateValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbOldLicenseID);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbExpirationDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbOldLicenseID);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbCreatedBy);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbExpirationDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbCreatedBy);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbApplicationDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbR_L_ApplicationID);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbApplicationFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.pbIssueDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbApplicationDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbIssueDate);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbRenewedLicenseID);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbApplicationFees);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbOldLicenseIDValue);
            this.gbApplicationRenewLicenseInfo.Controls.Add(this.lbR_L_ApplicationID);
            this.gbApplicationRenewLicenseInfo.Location = new System.Drawing.Point(8, 428);
            this.gbApplicationRenewLicenseInfo.Name = "gbApplicationRenewLicenseInfo";
            this.gbApplicationRenewLicenseInfo.Size = new System.Drawing.Size(879, 216);
            this.gbApplicationRenewLicenseInfo.TabIndex = 10;
            this.gbApplicationRenewLicenseInfo.TabStop = false;
            this.gbApplicationRenewLicenseInfo.Text = "Application Renew License Info";
            // 
            // pbRenewedLicenseID
            // 
            this.pbRenewedLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbRenewedLicenseID.Image")));
            this.pbRenewedLicenseID.Location = new System.Drawing.Point(645, 23);
            this.pbRenewedLicenseID.Name = "pbRenewedLicenseID";
            this.pbRenewedLicenseID.Size = new System.Drawing.Size(19, 19);
            this.pbRenewedLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRenewedLicenseID.TabIndex = 46;
            this.pbRenewedLicenseID.TabStop = false;
            // 
            // lbTotalFeesValue
            // 
            this.lbTotalFeesValue.AutoSize = true;
            this.lbTotalFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFeesValue.Location = new System.Drawing.Point(682, 132);
            this.lbTotalFeesValue.Name = "lbTotalFeesValue";
            this.lbTotalFeesValue.Size = new System.Drawing.Size(29, 15);
            this.lbTotalFeesValue.TabIndex = 45;
            this.lbTotalFeesValue.Text = "N/A";
            // 
            // pbTotalFees
            // 
            this.pbTotalFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pbTotalFees.Location = new System.Drawing.Point(645, 132);
            this.pbTotalFees.Name = "pbTotalFees";
            this.pbTotalFees.Size = new System.Drawing.Size(19, 19);
            this.pbTotalFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTotalFees.TabIndex = 44;
            this.pbTotalFees.TabStop = false;
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(501, 132);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(74, 15);
            this.lbTotalFees.TabIndex = 43;
            this.lbTotalFees.Text = "Total Fees";
            // 
            // tbNotesValue
            // 
            this.tbNotesValue.Location = new System.Drawing.Point(174, 161);
            this.tbNotesValue.Multiline = true;
            this.tbNotesValue.Name = "tbNotesValue";
            this.tbNotesValue.Size = new System.Drawing.Size(537, 49);
            this.tbNotesValue.TabIndex = 42;
            // 
            // pbNotes
            // 
            this.pbNotes.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pbNotes.Location = new System.Drawing.Point(137, 161);
            this.pbNotes.Name = "pbNotes";
            this.pbNotes.Size = new System.Drawing.Size(19, 19);
            this.pbNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotes.TabIndex = 41;
            this.pbNotes.TabStop = false;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(15, 161);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(44, 15);
            this.lbNotes.TabIndex = 40;
            this.lbNotes.Text = "Notes";
            // 
            // lbLicenseFeesValue
            // 
            this.lbLicenseFeesValue.AutoSize = true;
            this.lbLicenseFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFeesValue.Location = new System.Drawing.Point(171, 132);
            this.lbLicenseFeesValue.Name = "lbLicenseFeesValue";
            this.lbLicenseFeesValue.Size = new System.Drawing.Size(29, 15);
            this.lbLicenseFeesValue.TabIndex = 39;
            this.lbLicenseFeesValue.Text = "N/A";
            // 
            // pbLicenseFees
            // 
            this.pbLicenseFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pbLicenseFees.Location = new System.Drawing.Point(137, 132);
            this.pbLicenseFees.Name = "pbLicenseFees";
            this.pbLicenseFees.Size = new System.Drawing.Size(19, 19);
            this.pbLicenseFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseFees.TabIndex = 38;
            this.pbLicenseFees.TabStop = false;
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFees.Location = new System.Drawing.Point(15, 132);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(92, 15);
            this.lbLicenseFees.TabIndex = 36;
            this.lbLicenseFees.Text = "License Fees";
            // 
            // lbR_L_ApplicationIDValue
            // 
            this.lbR_L_ApplicationIDValue.AutoSize = true;
            this.lbR_L_ApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR_L_ApplicationIDValue.Location = new System.Drawing.Point(171, 23);
            this.lbR_L_ApplicationIDValue.Name = "lbR_L_ApplicationIDValue";
            this.lbR_L_ApplicationIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbR_L_ApplicationIDValue.TabIndex = 35;
            this.lbR_L_ApplicationIDValue.Text = "N/A";
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
            // lbRenewedLicenseIDValue
            // 
            this.lbRenewedLicenseIDValue.AutoSize = true;
            this.lbRenewedLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewedLicenseIDValue.Location = new System.Drawing.Point(682, 23);
            this.lbRenewedLicenseIDValue.Name = "lbRenewedLicenseIDValue";
            this.lbRenewedLicenseIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbRenewedLicenseIDValue.TabIndex = 33;
            this.lbRenewedLicenseIDValue.Text = "N/A";
            // 
            // lbExpirationDateValue
            // 
            this.lbExpirationDateValue.AutoSize = true;
            this.lbExpirationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDateValue.Location = new System.Drawing.Point(682, 75);
            this.lbExpirationDateValue.Name = "lbExpirationDateValue";
            this.lbExpirationDateValue.Size = new System.Drawing.Size(29, 15);
            this.lbExpirationDateValue.TabIndex = 32;
            this.lbExpirationDateValue.Text = "N/A";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(682, 101);
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
            // pbOldLicenseID
            // 
            this.pbOldLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("pbOldLicenseID.Image")));
            this.pbOldLicenseID.Location = new System.Drawing.Point(646, 49);
            this.pbOldLicenseID.Name = "pbOldLicenseID";
            this.pbOldLicenseID.Size = new System.Drawing.Size(19, 19);
            this.pbOldLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOldLicenseID.TabIndex = 28;
            this.pbOldLicenseID.TabStop = false;
            // 
            // pbExpirationDate
            // 
            this.pbExpirationDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbExpirationDate.Location = new System.Drawing.Point(646, 75);
            this.pbExpirationDate.Name = "pbExpirationDate";
            this.pbExpirationDate.Size = new System.Drawing.Size(19, 19);
            this.pbExpirationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExpirationDate.TabIndex = 26;
            this.pbExpirationDate.TabStop = false;
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(500, 49);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(105, 15);
            this.lbOldLicenseID.TabIndex = 25;
            this.lbOldLicenseID.Text = "Old  License ID";
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
            // pbCreatedBy
            // 
            this.pbCreatedBy.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pbCreatedBy.Location = new System.Drawing.Point(646, 101);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(19, 19);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedBy.TabIndex = 22;
            this.pbCreatedBy.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(137, 49);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(19, 19);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 20;
            this.pbApplicationDate.TabStop = false;
            // 
            // pbR_L_ApplicationID
            // 
            this.pbR_L_ApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("pbR_L_ApplicationID.Image")));
            this.pbR_L_ApplicationID.Location = new System.Drawing.Point(137, 23);
            this.pbR_L_ApplicationID.Name = "pbR_L_ApplicationID";
            this.pbR_L_ApplicationID.Size = new System.Drawing.Size(19, 19);
            this.pbR_L_ApplicationID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbR_L_ApplicationID.TabIndex = 19;
            this.pbR_L_ApplicationID.TabStop = false;
            // 
            // pbApplicationFees
            // 
            this.pbApplicationFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pbApplicationFees.Location = new System.Drawing.Point(137, 101);
            this.pbApplicationFees.Name = "pbApplicationFees";
            this.pbApplicationFees.Size = new System.Drawing.Size(19, 19);
            this.pbApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationFees.TabIndex = 18;
            this.pbApplicationFees.TabStop = false;
            // 
            // pbIssueDate
            // 
            this.pbIssueDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbIssueDate.Location = new System.Drawing.Point(137, 75);
            this.pbIssueDate.Name = "pbIssueDate";
            this.pbIssueDate.Size = new System.Drawing.Size(19, 19);
            this.pbIssueDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIssueDate.TabIndex = 17;
            this.pbIssueDate.TabStop = false;
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
            // lbRenewedLicenseID
            // 
            this.lbRenewedLicenseID.AutoSize = true;
            this.lbRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewedLicenseID.Location = new System.Drawing.Point(500, 23);
            this.lbRenewedLicenseID.Name = "lbRenewedLicenseID";
            this.lbRenewedLicenseID.Size = new System.Drawing.Size(139, 15);
            this.lbRenewedLicenseID.TabIndex = 14;
            this.lbRenewedLicenseID.Text = "Renewed License ID";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(15, 101);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(113, 15);
            this.lbApplicationFees.TabIndex = 13;
            this.lbApplicationFees.Text = "Application Fees";
            // 
            // lbOldLicenseIDValue
            // 
            this.lbOldLicenseIDValue.AutoSize = true;
            this.lbOldLicenseIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseIDValue.Location = new System.Drawing.Point(682, 49);
            this.lbOldLicenseIDValue.Name = "lbOldLicenseIDValue";
            this.lbOldLicenseIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbOldLicenseIDValue.TabIndex = 12;
            this.lbOldLicenseIDValue.Text = "N/A";
            // 
            // lbR_L_ApplicationID
            // 
            this.lbR_L_ApplicationID.AutoSize = true;
            this.lbR_L_ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR_L_ApplicationID.Location = new System.Drawing.Point(15, 23);
            this.lbR_L_ApplicationID.Name = "lbR_L_ApplicationID";
            this.lbR_L_ApplicationID.Size = new System.Drawing.Size(122, 15);
            this.lbR_L_ApplicationID.TabIndex = 11;
            this.lbR_L_ApplicationID.Text = "R.L.Application ID";
            // 
            // linkLabelRenewLicensesInfo
            // 
            this.linkLabelRenewLicensesInfo.AutoSize = true;
            this.linkLabelRenewLicensesInfo.Enabled = false;
            this.linkLabelRenewLicensesInfo.Location = new System.Drawing.Point(179, 663);
            this.linkLabelRenewLicensesInfo.Name = "linkLabelRenewLicensesInfo";
            this.linkLabelRenewLicensesInfo.Size = new System.Drawing.Size(125, 13);
            this.linkLabelRenewLicensesInfo.TabIndex = 9;
            this.linkLabelRenewLicensesInfo.TabStop = true;
            this.linkLabelRenewLicensesInfo.Text = "Show New Licenses Info";
            this.linkLabelRenewLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRenewLicensesInfo_LinkClicked);
            // 
            // linkLabelLicensesHistory
            // 
            this.linkLabelLicensesHistory.AutoSize = true;
            this.linkLabelLicensesHistory.Enabled = false;
            this.linkLabelLicensesHistory.Location = new System.Drawing.Point(31, 663);
            this.linkLabelLicensesHistory.Name = "linkLabelLicensesHistory";
            this.linkLabelLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.linkLabelLicensesHistory.TabIndex = 8;
            this.linkLabelLicensesHistory.TabStop = true;
            this.linkLabelLicensesHistory.Text = "Show Licenses History";
            this.linkLabelLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicensesHistory_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(610, 652);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(109, 34);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRenew
            // 
            this.btRenew.Enabled = false;
            this.btRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenew.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.btRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRenew.Location = new System.Drawing.Point(725, 652);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(162, 34);
            this.btRenew.TabIndex = 7;
            this.btRenew.Text = "Renew";
            this.btRenew.UseVisualStyleBackColor = true;
            this.btRenew.Click += new System.EventHandler(this.btRenew_Click);
            // 
            // frmRenewLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 695);
            this.Controls.Add(this.gbApplicationRenewLicenseInfo);
            this.Controls.Add(this.linkLabelRenewLicensesInfo);
            this.Controls.Add(this.linkLabelLicensesHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRenew);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLicenseApplications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew License Application";
            this.Load += new System.EventHandler(this.frmRenewLicenseApplication_Load);
            this.gbApplicationRenewLicenseInfo.ResumeLayout(false);
            this.gbApplicationRenewLicenseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenewedLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpirationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR_L_ApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssueDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Licenses.LicenseControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbApplicationRenewLicenseInfo;
        private System.Windows.Forms.Label lbR_L_ApplicationIDValue;
        private System.Windows.Forms.Label lbApplicationFeesValue;
        private System.Windows.Forms.Label lbRenewedLicenseIDValue;
        private System.Windows.Forms.Label lbExpirationDateValue;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbIssueDateValue;
        private System.Windows.Forms.Label lbApplicationDateValue;
        private System.Windows.Forms.PictureBox pbOldLicenseID;
        private System.Windows.Forms.PictureBox pbExpirationDate;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.PictureBox pbR_L_ApplicationID;
        private System.Windows.Forms.PictureBox pbApplicationFees;
        private System.Windows.Forms.PictureBox pbIssueDate;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbRenewedLicenseID;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbOldLicenseIDValue;
        private System.Windows.Forms.Label lbR_L_ApplicationID;
        private System.Windows.Forms.LinkLabel linkLabelRenewLicensesInfo;
        private System.Windows.Forms.LinkLabel linkLabelLicensesHistory;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRenew;
        private System.Windows.Forms.Label lbLicenseFeesValue;
        private System.Windows.Forms.PictureBox pbLicenseFees;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label lbTotalFeesValue;
        private System.Windows.Forms.PictureBox pbTotalFees;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.TextBox tbNotesValue;
        private System.Windows.Forms.PictureBox pbNotes;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.PictureBox pbRenewedLicenseID;
    }
}