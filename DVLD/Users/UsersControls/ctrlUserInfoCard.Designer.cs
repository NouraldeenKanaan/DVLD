namespace DVLD.Controls
{
    partial class ctrlUserInfoCard
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
            this.ucPersonCardInfo1 = new DVLD.People.ctrlPersonCardInfo();
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbIsActiveValue = new System.Windows.Forms.Label();
            this.lbUsernameValue = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbUserIDValue = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonCardInfo1
            // 
            this.ucPersonCardInfo1.BackColor = System.Drawing.Color.White;
            this.ucPersonCardInfo1.Location = new System.Drawing.Point(3, 3);
            this.ucPersonCardInfo1.Name = "ucPersonCardInfo1";
            this.ucPersonCardInfo1.Size = new System.Drawing.Size(782, 245);
            this.ucPersonCardInfo1.TabIndex = 0;
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLoginInfo.Controls.Add(this.lbIsActive);
            this.gbLoginInfo.Controls.Add(this.lbIsActiveValue);
            this.gbLoginInfo.Controls.Add(this.lbUsernameValue);
            this.gbLoginInfo.Controls.Add(this.lbUsername);
            this.gbLoginInfo.Controls.Add(this.lbUserIDValue);
            this.gbLoginInfo.Controls.Add(this.lbUserID);
            this.gbLoginInfo.Location = new System.Drawing.Point(8, 247);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(770, 80);
            this.gbLoginInfo.TabIndex = 1;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Login Information";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(547, 39);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(67, 15);
            this.lbIsActive.TabIndex = 5;
            this.lbIsActive.Text = "Is Active :";
            // 
            // lbIsActiveValue
            // 
            this.lbIsActiveValue.AutoSize = true;
            this.lbIsActiveValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActiveValue.Location = new System.Drawing.Point(611, 39);
            this.lbIsActiveValue.Name = "lbIsActiveValue";
            this.lbIsActiveValue.Size = new System.Drawing.Size(29, 15);
            this.lbIsActiveValue.TabIndex = 4;
            this.lbIsActiveValue.Text = "N/A";
            // 
            // lbUsernameValue
            // 
            this.lbUsernameValue.AutoSize = true;
            this.lbUsernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameValue.Location = new System.Drawing.Point(367, 39);
            this.lbUsernameValue.Name = "lbUsernameValue";
            this.lbUsernameValue.Size = new System.Drawing.Size(29, 15);
            this.lbUsernameValue.TabIndex = 3;
            this.lbUsernameValue.Text = "N/A";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(289, 39);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 15);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username :";
            // 
            // lbUserIDValue
            // 
            this.lbUserIDValue.AutoSize = true;
            this.lbUserIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDValue.Location = new System.Drawing.Point(162, 39);
            this.lbUserIDValue.Name = "lbUserIDValue";
            this.lbUserIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbUserIDValue.TabIndex = 1;
            this.lbUserIDValue.Text = "N/A";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(102, 39);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(63, 15);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID :";
            // 
            // ctrlUserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ucPersonCardInfo1);
            this.Name = "ctrlUserInfoCard";
            this.Size = new System.Drawing.Size(786, 330);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.ctrlPersonCardInfo ucPersonCardInfo1;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbIsActiveValue;
        private System.Windows.Forms.Label lbUsernameValue;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUserIDValue;
    }
}
