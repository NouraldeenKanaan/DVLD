namespace DVLD.Controls
{
    partial class ctrlPersonCardInfoWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btAddNewPerson = new System.Windows.Forms.Button();
            this.btFindPerson = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFindBy = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardInfo1 = new DVLD.People.ctrlPersonCardInfo();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btAddNewPerson);
            this.gbFilter.Controls.Add(this.btFindPerson);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.lbFindBy);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(776, 81);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btAddNewPerson
            // 
            this.btAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNewPerson.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.btAddNewPerson.Location = new System.Drawing.Point(494, 17);
            this.btAddNewPerson.Name = "btAddNewPerson";
            this.btAddNewPerson.Size = new System.Drawing.Size(36, 37);
            this.btAddNewPerson.TabIndex = 1;
            this.btAddNewPerson.UseVisualStyleBackColor = true;
            this.btAddNewPerson.Click += new System.EventHandler(this.btAddNewPerson_Click);
            // 
            // btFindPerson
            // 
            this.btFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindPerson.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btFindPerson.Location = new System.Drawing.Point(452, 17);
            this.btFindPerson.Name = "btFindPerson";
            this.btFindPerson.Size = new System.Drawing.Size(36, 37);
            this.btFindPerson.TabIndex = 0;
            this.btFindPerson.UseVisualStyleBackColor = true;
            this.btFindPerson.Click += new System.EventHandler(this.btFindPerson_Click);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(243, 26);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(187, 20);
            this.tbFilterValue.TabIndex = 1;
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            this.tbFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbFilterValue_Validating);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cbFilter.Location = new System.Drawing.Point(72, 25);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(165, 21);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lbFindBy
            // 
            this.lbFindBy.AutoSize = true;
            this.lbFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindBy.Location = new System.Drawing.Point(17, 28);
            this.lbFindBy.Name = "lbFindBy";
            this.lbFindBy.Size = new System.Drawing.Size(49, 13);
            this.lbFindBy.TabIndex = 2;
            this.lbFindBy.Text = "Find By";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardInfo1
            // 
            this.ctrlPersonCardInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardInfo1.Location = new System.Drawing.Point(4, 84);
            this.ctrlPersonCardInfo1.Name = "ctrlPersonCardInfo1";
            this.ctrlPersonCardInfo1.Size = new System.Drawing.Size(782, 245);
            this.ctrlPersonCardInfo1.TabIndex = 2;
            // 
            // ctrlPersonCardInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonCardInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlPersonCardInfoWithFilter";
            this.Size = new System.Drawing.Size(786, 332);
            this.Load += new System.EventHandler(this.ucPersonCardInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lbFindBy;
        private System.Windows.Forms.Button btAddNewPerson;
        private System.Windows.Forms.Button btFindPerson;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private People.ctrlPersonCardInfo ctrlPersonCardInfo1;
    }
}
