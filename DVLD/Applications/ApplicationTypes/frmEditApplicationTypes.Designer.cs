namespace DVLD.Applications
{
    partial class frmEditApplicationTypes
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbApplicationTypeID = new System.Windows.Forms.Label();
            this.lbApplicationTypeIDValue = new System.Windows.Forms.Label();
            this.lbApplicationTypeFees = new System.Windows.Forms.Label();
            this.lbApplicationTypeName = new System.Windows.Forms.Label();
            this.tbApplicationTypeNameValue = new System.Windows.Forms.TextBox();
            this.tbApplicationTypeFeesValue = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(86, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(270, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Update Application Type";
            // 
            // lbApplicationTypeID
            // 
            this.lbApplicationTypeID.AutoSize = true;
            this.lbApplicationTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeID.Location = new System.Drawing.Point(15, 71);
            this.lbApplicationTypeID.Name = "lbApplicationTypeID";
            this.lbApplicationTypeID.Size = new System.Drawing.Size(130, 15);
            this.lbApplicationTypeID.TabIndex = 1;
            this.lbApplicationTypeID.Text = "Application Type ID";
            // 
            // lbApplicationTypeIDValue
            // 
            this.lbApplicationTypeIDValue.AutoSize = true;
            this.lbApplicationTypeIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeIDValue.Location = new System.Drawing.Point(214, 71);
            this.lbApplicationTypeIDValue.Name = "lbApplicationTypeIDValue";
            this.lbApplicationTypeIDValue.Size = new System.Drawing.Size(29, 15);
            this.lbApplicationTypeIDValue.TabIndex = 2;
            this.lbApplicationTypeIDValue.Text = "N/A";
            // 
            // lbApplicationTypeFees
            // 
            this.lbApplicationTypeFees.AutoSize = true;
            this.lbApplicationTypeFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeFees.Location = new System.Drawing.Point(15, 133);
            this.lbApplicationTypeFees.Name = "lbApplicationTypeFees";
            this.lbApplicationTypeFees.Size = new System.Drawing.Size(147, 15);
            this.lbApplicationTypeFees.TabIndex = 3;
            this.lbApplicationTypeFees.Text = "Application Type Fees";
            // 
            // lbApplicationTypeName
            // 
            this.lbApplicationTypeName.AutoSize = true;
            this.lbApplicationTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeName.Location = new System.Drawing.Point(15, 102);
            this.lbApplicationTypeName.Name = "lbApplicationTypeName";
            this.lbApplicationTypeName.Size = new System.Drawing.Size(154, 15);
            this.lbApplicationTypeName.TabIndex = 4;
            this.lbApplicationTypeName.Text = "Application Type Name";
            // 
            // tbApplicationTypeNameValue
            // 
            this.tbApplicationTypeNameValue.Location = new System.Drawing.Point(217, 102);
            this.tbApplicationTypeNameValue.Name = "tbApplicationTypeNameValue";
            this.tbApplicationTypeNameValue.Size = new System.Drawing.Size(215, 20);
            this.tbApplicationTypeNameValue.TabIndex = 7;
            this.tbApplicationTypeNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApplicationTypeNameValue_KeyPress);
            // 
            // tbApplicationTypeFeesValue
            // 
            this.tbApplicationTypeFeesValue.Location = new System.Drawing.Point(217, 133);
            this.tbApplicationTypeFeesValue.Name = "tbApplicationTypeFeesValue";
            this.tbApplicationTypeFeesValue.Size = new System.Drawing.Size(215, 20);
            this.tbApplicationTypeFeesValue.TabIndex = 8;
            this.tbApplicationTypeFeesValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApplicationTypeFeesValue_KeyPress);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(217, 179);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(103, 36);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(326, 179);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(106, 36);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(175, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ApplicationTitle;
            this.pictureBox1.Location = new System.Drawing.Point(175, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 221);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbApplicationTypeFeesValue);
            this.Controls.Add(this.tbApplicationTypeNameValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbApplicationTypeName);
            this.Controls.Add(this.lbApplicationTypeFees);
            this.Controls.Add(this.lbApplicationTypeIDValue);
            this.Controls.Add(this.lbApplicationTypeID);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditApplicationTypes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmEditApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbApplicationTypeID;
        private System.Windows.Forms.Label lbApplicationTypeIDValue;
        private System.Windows.Forms.Label lbApplicationTypeFees;
        private System.Windows.Forms.Label lbApplicationTypeName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbApplicationTypeNameValue;
        private System.Windows.Forms.TextBox tbApplicationTypeFeesValue;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
    }
}