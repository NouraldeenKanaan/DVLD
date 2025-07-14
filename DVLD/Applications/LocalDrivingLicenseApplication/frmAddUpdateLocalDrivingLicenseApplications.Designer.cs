namespace DVLD.Applications
{
    partial class frmAddUpdateLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicenseApplications));
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpagePersonalInfo = new System.Windows.Forms.TabPage();
            this.btNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardInfoWithFilter1 = new DVLD.Controls.ctrlPersonCardInfoWithFilter();
            this.tabpageApplicationInfo = new System.Windows.Forms.TabPage();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.pbApplicationFees = new System.Windows.Forms.PictureBox();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.pbApplicationID = new System.Windows.Forms.PictureBox();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationIDValue = new System.Windows.Forms.Label();
            this.lbApplicationDateValue = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbLicenseClass = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpagePersonalInfo.SuspendLayout();
            this.tabpageApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(175, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(511, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpagePersonalInfo);
            this.tabControl1.Controls.Add(this.tabpageApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(2, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 420);
            this.tabControl1.TabIndex = 2;
            // 
            // tabpagePersonalInfo
            // 
            this.tabpagePersonalInfo.Controls.Add(this.btNext);
            this.tabpagePersonalInfo.Controls.Add(this.ctrlPersonCardInfoWithFilter1);
            this.tabpagePersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpagePersonalInfo.Name = "tabpagePersonalInfo";
            this.tabpagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePersonalInfo.Size = new System.Drawing.Size(801, 394);
            this.tabpagePersonalInfo.TabIndex = 0;
            this.tabpagePersonalInfo.Text = "Personal Information";
            this.tabpagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNext.Location = new System.Drawing.Point(629, 344);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(154, 35);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // ctrlPersonCardInfoWithFilter1
            // 
            this.ctrlPersonCardInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardInfoWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardInfoWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonCardInfoWithFilter1.Name = "ctrlPersonCardInfoWithFilter1";
            this.ctrlPersonCardInfoWithFilter1.ShowAddNewPerson = true;
            this.ctrlPersonCardInfoWithFilter1.Size = new System.Drawing.Size(786, 332);
            this.ctrlPersonCardInfoWithFilter1.TabIndex = 0;
            this.ctrlPersonCardInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ucPersonCardInfoWithFilter1_OnPersonSelected);
            // 
            // tabpageApplicationInfo
            // 
            this.tabpageApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationFeesValue);
            this.tabpageApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tabpageApplicationInfo.Controls.Add(this.pbApplicationFees);
            this.tabpageApplicationInfo.Controls.Add(this.pbLicenseClass);
            this.tabpageApplicationInfo.Controls.Add(this.pbApplicationDate);
            this.tabpageApplicationInfo.Controls.Add(this.pbApplicationID);
            this.tabpageApplicationInfo.Controls.Add(this.pbCreatedBy);
            this.tabpageApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationIDValue);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationDateValue);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tabpageApplicationInfo.Controls.Add(this.lbLicenseClass);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tabpageApplicationInfo.Controls.Add(this.lbApplicationID);
            this.tabpageApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpageApplicationInfo.Name = "tabpageApplicationInfo";
            this.tabpageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageApplicationInfo.Size = new System.Drawing.Size(801, 394);
            this.tabpageApplicationInfo.TabIndex = 1;
            this.tabpageApplicationInfo.Text = "Application Information";
            this.tabpageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(337, 260);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(41, 16);
            this.lbCreatedByValue.TabIndex = 14;
            this.lbCreatedByValue.Text = "[???]";
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.AutoSize = true;
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(337, 214);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(31, 16);
            this.lbApplicationFeesValue.TabIndex = 13;
            this.lbApplicationFeesValue.Text = "000";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(340, 163);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(200, 21);
            this.cbLicenseClasses.TabIndex = 12;
            // 
            // pbApplicationFees
            // 
            this.pbApplicationFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pbApplicationFees.Location = new System.Drawing.Point(289, 214);
            this.pbApplicationFees.Name = "pbApplicationFees";
            this.pbApplicationFees.Size = new System.Drawing.Size(20, 16);
            this.pbApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationFees.TabIndex = 11;
            this.pbApplicationFees.TabStop = false;
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.pbLicenseClass.Location = new System.Drawing.Point(289, 168);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(20, 16);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 10;
            this.pbLicenseClass.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(289, 122);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(20, 16);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 9;
            this.pbApplicationDate.TabStop = false;
            // 
            // pbApplicationID
            // 
            this.pbApplicationID.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbApplicationID.Location = new System.Drawing.Point(289, 76);
            this.pbApplicationID.Name = "pbApplicationID";
            this.pbApplicationID.Size = new System.Drawing.Size(20, 16);
            this.pbApplicationID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationID.TabIndex = 8;
            this.pbApplicationID.TabStop = false;
            // 
            // pbCreatedBy
            // 
            this.pbCreatedBy.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pbCreatedBy.Location = new System.Drawing.Point(289, 260);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(20, 16);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedBy.TabIndex = 7;
            this.pbCreatedBy.TabStop = false;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(91, 260);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(84, 16);
            this.lbCreatedBy.TabIndex = 6;
            this.lbCreatedBy.Text = "Created By";
            // 
            // lbApplicationIDValue
            // 
            this.lbApplicationIDValue.AutoSize = true;
            this.lbApplicationIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationIDValue.Location = new System.Drawing.Point(337, 76);
            this.lbApplicationIDValue.Name = "lbApplicationIDValue";
            this.lbApplicationIDValue.Size = new System.Drawing.Size(41, 16);
            this.lbApplicationIDValue.TabIndex = 5;
            this.lbApplicationIDValue.Text = "[???]";
            // 
            // lbApplicationDateValue
            // 
            this.lbApplicationDateValue.AutoSize = true;
            this.lbApplicationDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateValue.Location = new System.Drawing.Point(337, 122);
            this.lbApplicationDateValue.Name = "lbApplicationDateValue";
            this.lbApplicationDateValue.Size = new System.Drawing.Size(81, 16);
            this.lbApplicationDateValue.TabIndex = 4;
            this.lbApplicationDateValue.Text = "00/00/0000";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(91, 214);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(124, 16);
            this.lbApplicationFees.TabIndex = 3;
            this.lbApplicationFees.Text = "Application Fees";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.AutoSize = true;
            this.lbLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClass.Location = new System.Drawing.Point(91, 168);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(104, 16);
            this.lbLicenseClass.TabIndex = 2;
            this.lbLicenseClass.Text = "License Class";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(91, 122);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(122, 16);
            this.lbApplicationDate.TabIndex = 1;
            this.lbApplicationDate.Text = "Application Date";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(90, 76);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(131, 16);
            this.lbApplicationID.TabIndex = 0;
            this.lbApplicationID.Text = "D.L Application ID";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(491, 505);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(154, 35);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(653, 505);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(154, 35);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(814, 545);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateLocalDrivingLicenseApplications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpagePersonalInfo.ResumeLayout(false);
            this.tabpageApplicationInfo.ResumeLayout(false);
            this.tabpageApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpagePersonalInfo;
        private Controls.ctrlPersonCardInfoWithFilter ctrlPersonCardInfoWithFilter1;
        private System.Windows.Forms.TabPage tabpageApplicationInfo;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationIDValue;
        private System.Windows.Forms.Label lbApplicationDateValue;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbLicenseClass;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.PictureBox pbApplicationFees;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.PictureBox pbApplicationID;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbApplicationFeesValue;
    }
}