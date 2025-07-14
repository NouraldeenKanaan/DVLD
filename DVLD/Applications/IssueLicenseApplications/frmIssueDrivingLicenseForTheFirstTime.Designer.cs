namespace DVLD.Licenses
{
    partial class frmIssueDrivingLicenseForTheFirstTime
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
            this.btIssue = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tbNotesValue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.ctrlLocalDrivingApplicationInfoCard1 = new DVLD.Applications.ApplicationControls.ctrlLocalDrivingApplicationInfoCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btIssue
            // 
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(600, 420);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(185, 39);
            this.btIssue.TabIndex = 28;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = true;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(488, 420);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(106, 39);
            this.btClose.TabIndex = 27;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tbNotesValue
            // 
            this.tbNotesValue.Location = new System.Drawing.Point(132, 321);
            this.tbNotesValue.Multiline = true;
            this.tbNotesValue.Name = "tbNotesValue";
            this.tbNotesValue.Size = new System.Drawing.Size(653, 93);
            this.tbNotesValue.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(106, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(52, 322);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(48, 16);
            this.lbNotes.TabIndex = 24;
            this.lbNotes.Text = "Notes";
            // 
            // ctrlLocalDrivingApplicationInfoCard1
            // 
            this.ctrlLocalDrivingApplicationInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingApplicationInfoCard1.Location = new System.Drawing.Point(2, 2);
            this.ctrlLocalDrivingApplicationInfoCard1.Name = "ctrlLocalDrivingApplicationInfoCard1";
            this.ctrlLocalDrivingApplicationInfoCard1.Size = new System.Drawing.Size(793, 313);
            this.ctrlLocalDrivingApplicationInfoCard1.TabIndex = 0;
            // 
            // frmIssueDrivingLicenseForTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 463);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbNotesValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.ctrlLocalDrivingApplicationInfoCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLicenseForTheFirstTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License ForThe First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForTheFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.ApplicationControls.ctrlLocalDrivingApplicationInfoCard ctrlLocalDrivingApplicationInfoCard1;
        private System.Windows.Forms.Button btIssue;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbNotesValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNotes;
    }
}