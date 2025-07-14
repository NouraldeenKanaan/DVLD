namespace DVLD.Applications.LocalDrivingLicenseApplication
{
    partial class frmLocalDrivingLicenseApplicationsInfo
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
            this.ctrlLocalDrivingApplicationInfoCard1 = new DVLD.Applications.ApplicationControls.ctrlLocalDrivingApplicationInfoCard();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingApplicationInfoCard1
            // 
            this.ctrlLocalDrivingApplicationInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingApplicationInfoCard1.Location = new System.Drawing.Point(0, 41);
            this.ctrlLocalDrivingApplicationInfoCard1.Name = "ctrlLocalDrivingApplicationInfoCard1";
            this.ctrlLocalDrivingApplicationInfoCard1.Size = new System.Drawing.Size(793, 313);
            this.ctrlLocalDrivingApplicationInfoCard1.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(660, 355);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(129, 36);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(311, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(193, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Application Info";
            // 
            // frmShowLocalDrivingLicenseApplicationsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 397);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ctrlLocalDrivingApplicationInfoCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLocalDrivingLicenseApplicationsInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Info";
            this.Load += new System.EventHandler(this.frmShowLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationControls.ctrlLocalDrivingApplicationInfoCard ctrlLocalDrivingApplicationInfoCard1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbTitle;
    }
}