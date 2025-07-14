namespace DVLD.Licenses
{
    partial class frmDriverInternationalLicenseInfo
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
            this.ctrlDriverInternationalLicenseInfo1 = new DVLD.Licenses.LicenseControls.ctrlDriverInternationalLicenseInfo();
            this.pbLicenseView = new System.Windows.Forms.PictureBox();
            this.pbInternational = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternational)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            this.ctrlDriverInternationalLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(3, 156);
            this.ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            this.ctrlDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(855, 233);
            this.ctrlDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // pbLicenseView
            // 
            this.pbLicenseView.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pbLicenseView.Location = new System.Drawing.Point(352, 12);
            this.pbLicenseView.Name = "pbLicenseView";
            this.pbLicenseView.Size = new System.Drawing.Size(150, 98);
            this.pbLicenseView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseView.TabIndex = 1;
            this.pbLicenseView.TabStop = false;
            // 
            // pbInternational
            // 
            this.pbInternational.Image = global::DVLD.Properties.Resources.International_32;
            this.pbInternational.Location = new System.Drawing.Point(481, 33);
            this.pbInternational.Name = "pbInternational";
            this.pbInternational.Size = new System.Drawing.Size(31, 32);
            this.pbInternational.TabIndex = 2;
            this.pbInternational.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(214, 122);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(431, 31);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Driver International License Info";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(717, 395);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 37);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmDriverInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 441);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbInternational);
            this.Controls.Add(this.pbLicenseView);
            this.Controls.Add(this.ctrlDriverInternationalLicenseInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDriverInternationalLicenseInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver International License Info";
            this.Load += new System.EventHandler(this.frmDriverInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternational)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LicenseControls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private System.Windows.Forms.PictureBox pbLicenseView;
        private System.Windows.Forms.PictureBox pbInternational;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btClose;
    }
}