namespace DVLD.Tests.TestAppointments
{
    partial class frmTestAppointments
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAppointments = new System.Windows.Forms.Label();
            this.lbRecordsValue = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btAddAppointment = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTestEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLocalDrivingApplicationInfoCard1 = new DVLD.Applications.ApplicationControls.ctrlLocalDrivingApplicationInfoCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(337, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(252, 90);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(310, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Vision Test Appointments";
            // 
            // lbAppointments
            // 
            this.lbAppointments.AutoSize = true;
            this.lbAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointments.Location = new System.Drawing.Point(9, 450);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(101, 16);
            this.lbAppointments.TabIndex = 3;
            this.lbAppointments.Text = "Appointments";
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.AutoSize = true;
            this.lbRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(108, 623);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(15, 16);
            this.lbRecordsValue.TabIndex = 4;
            this.lbRecordsValue.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(12, 623);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(90, 16);
            this.lbRecords.TabIndex = 5;
            this.lbRecords.Text = "# Records : ";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(666, 616);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 34);
            this.btClose.TabIndex = 1;
            this.btClose.Text = " Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAddAppointment
            // 
            this.btAddAppointment.BackgroundImage = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddAppointment.Location = new System.Drawing.Point(750, 441);
            this.btAddAppointment.Name = "btAddAppointment";
            this.btAddAppointment.Size = new System.Drawing.Size(37, 34);
            this.btAddAppointment.TabIndex = 0;
            this.btAddAppointment.UseVisualStyleBackColor = true;
            this.btAddAppointment.Click += new System.EventHandler(this.btAddAppointment_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 481);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(775, 129);
            this.dgvAppointments.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTestEdit,
            this.tsmTakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 78);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmTestEdit
            // 
            this.tsmTestEdit.Image = global::DVLD.Properties.Resources.edit_32;
            this.tsmTestEdit.Name = "tsmTestEdit";
            this.tsmTestEdit.Size = new System.Drawing.Size(184, 26);
            this.tsmTestEdit.Text = "Edit";
            this.tsmTestEdit.Click += new System.EventHandler(this.tsmTestEdit_Click);
            // 
            // tsmTakeTest
            // 
            this.tsmTakeTest.Image = global::DVLD.Properties.Resources.Test_32;
            this.tsmTakeTest.Name = "tsmTakeTest";
            this.tsmTakeTest.Size = new System.Drawing.Size(184, 26);
            this.tsmTakeTest.Text = "Take Test";
            this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
            // 
            // ctrlLocalDrivingApplicationInfoCard1
            // 
            this.ctrlLocalDrivingApplicationInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingApplicationInfoCard1.Location = new System.Drawing.Point(0, 122);
            this.ctrlLocalDrivingApplicationInfoCard1.Name = "ctrlLocalDrivingApplicationInfoCard1";
            this.ctrlLocalDrivingApplicationInfoCard1.Size = new System.Drawing.Size(793, 313);
            this.ctrlLocalDrivingApplicationInfoCard1.TabIndex = 8;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 654);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.ctrlLocalDrivingApplicationInfoCard1);
            this.Controls.Add(this.btAddAppointment);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbAppointments);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmTestAppointments";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAppointments;
        private System.Windows.Forms.Label lbRecordsValue;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAddAppointment;
        private Applications.ApplicationControls.ctrlLocalDrivingApplicationInfoCard ctrlLocalDrivingApplicationInfoCard1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTestEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
    }
}