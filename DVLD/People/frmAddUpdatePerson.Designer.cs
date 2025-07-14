namespace DVLD.People
{
    partial class frmAddUpdatePerson
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.linklabelRemove = new System.Windows.Forms.LinkLabel();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbThirdName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbPersonIDValue = new System.Windows.Forms.Label();
            this.linklabelSetImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNationalNumber = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbNationalNumber = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbNationality = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbNationalNumber = new System.Windows.Forms.PictureBox();
            this.pbMale = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbAddress = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbFemale = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTitle.Location = new System.Drawing.Point(285, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(209, 29);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add New Person";
            // 
            // linklabelRemove
            // 
            this.linklabelRemove.AutoSize = true;
            this.linklabelRemove.Location = new System.Drawing.Point(661, 362);
            this.linklabelRemove.Name = "linklabelRemove";
            this.linklabelRemove.Size = new System.Drawing.Size(47, 13);
            this.linklabelRemove.TabIndex = 61;
            this.linklabelRemove.TabStop = true;
            this.linklabelRemove.Text = "Remove";
            this.linklabelRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelRemove_LinkClicked);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(667, 128);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(27, 13);
            this.lbLastName.TabIndex = 60;
            this.lbLastName.Text = "Last";
            // 
            // lbThirdName
            // 
            this.lbThirdName.AutoSize = true;
            this.lbThirdName.Location = new System.Drawing.Point(503, 128);
            this.lbThirdName.Name = "lbThirdName";
            this.lbThirdName.Size = new System.Drawing.Size(31, 13);
            this.lbThirdName.TabIndex = 59;
            this.lbThirdName.Text = "Third";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Location = new System.Drawing.Point(341, 128);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(44, 13);
            this.lbSecondName.TabIndex = 58;
            this.lbSecondName.Text = "Second";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(197, 128);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(26, 13);
            this.lbFirstName.TabIndex = 57;
            this.lbFirstName.Text = "First";
            // 
            // lbPersonIDValue
            // 
            this.lbPersonIDValue.AutoSize = true;
            this.lbPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDValue.Location = new System.Drawing.Point(111, 88);
            this.lbPersonIDValue.Name = "lbPersonIDValue";
            this.lbPersonIDValue.Size = new System.Drawing.Size(30, 13);
            this.lbPersonIDValue.TabIndex = 56;
            this.lbPersonIDValue.Text = "N/A";
            // 
            // linklabelSetImage
            // 
            this.linklabelSetImage.AutoSize = true;
            this.linklabelSetImage.Location = new System.Drawing.Point(653, 333);
            this.linklabelSetImage.Name = "linklabelSetImage";
            this.linklabelSetImage.Size = new System.Drawing.Size(55, 13);
            this.linklabelSetImage.TabIndex = 55;
            this.linklabelSetImage.TabStop = true;
            this.linklabelSetImage.Text = "Set Image";
            this.linklabelSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelSetImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.pbImage.Location = new System.Drawing.Point(609, 172);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(136, 148);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 54;
            this.pbImage.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(144, 211);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 53;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(221, 211);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 52;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(454, 173);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(136, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(454, 235);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(136, 21);
            this.cbCountry.TabIndex = 10;
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(365, 381);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(107, 33);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(484, 381);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 33);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(144, 271);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(446, 104);
            this.tbAddress.TabIndex = 9;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(454, 204);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(136, 20);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(609, 144);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(136, 20);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(454, 144);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(136, 20);
            this.tbThirdName.TabIndex = 3;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(300, 144);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(136, 20);
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecondName_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 236);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(136, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbNationalNumber
            // 
            this.tbNationalNumber.Location = new System.Drawing.Point(144, 176);
            this.tbNationalNumber.Name = "tbNationalNumber";
            this.tbNationalNumber.Size = new System.Drawing.Size(136, 20);
            this.tbNationalNumber.TabIndex = 5;
            this.tbNationalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNumber_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(144, 144);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(136, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 243);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(37, 13);
            this.lbEmail.TabIndex = 47;
            this.lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(12, 278);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(52, 13);
            this.lbAddress.TabIndex = 46;
            this.lbAddress.Text = "Address";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(318, 179);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(81, 13);
            this.lbDateOfBirth.TabIndex = 44;
            this.lbDateOfBirth.Text = "Date Of Birth";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(318, 211);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(43, 13);
            this.lbPhone.TabIndex = 41;
            this.lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(12, 211);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(48, 13);
            this.lbGender.TabIndex = 39;
            this.lbGender.Text = "Gender";
            // 
            // lbNationalNumber
            // 
            this.lbNationalNumber.AutoSize = true;
            this.lbNationalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNumber.Location = new System.Drawing.Point(12, 179);
            this.lbNationalNumber.Name = "lbNationalNumber";
            this.lbNationalNumber.Size = new System.Drawing.Size(101, 13);
            this.lbNationalNumber.TabIndex = 37;
            this.lbNationalNumber.Text = "National Number";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(318, 243);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(67, 13);
            this.lbCountry.TabIndex = 35;
            this.lbCountry.Text = "Nationality";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(12, 88);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(63, 13);
            this.lbPersonID.TabIndex = 34;
            this.lbPersonID.Text = "Person ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 147);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 13);
            this.lbName.TabIndex = 31;
            this.lbName.Text = "Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbDateOfBirth
            // 
            this.pbDateOfBirth.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbDateOfBirth.Location = new System.Drawing.Point(412, 176);
            this.pbDateOfBirth.Name = "pbDateOfBirth";
            this.pbDateOfBirth.Size = new System.Drawing.Size(24, 20);
            this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateOfBirth.TabIndex = 62;
            this.pbDateOfBirth.TabStop = false;
            // 
            // pbPhone
            // 
            this.pbPhone.Image = global::DVLD.Properties.Resources.Phone_32;
            this.pbPhone.Location = new System.Drawing.Point(412, 211);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(24, 20);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhone.TabIndex = 63;
            this.pbPhone.TabStop = false;
            // 
            // pbNationality
            // 
            this.pbNationality.Image = global::DVLD.Properties.Resources.Country_32;
            this.pbNationality.Location = new System.Drawing.Point(412, 243);
            this.pbNationality.Name = "pbNationality";
            this.pbNationality.Size = new System.Drawing.Size(24, 20);
            this.pbNationality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNationality.TabIndex = 64;
            this.pbNationality.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.Image = global::DVLD.Properties.Resources.Person_32;
            this.pbName.Location = new System.Drawing.Point(114, 144);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(24, 20);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbName.TabIndex = 65;
            this.pbName.TabStop = false;
            // 
            // pbNationalNumber
            // 
            this.pbNationalNumber.Image = global::DVLD.Properties.Resources.International_32;
            this.pbNationalNumber.Location = new System.Drawing.Point(114, 176);
            this.pbNationalNumber.Name = "pbNationalNumber";
            this.pbNationalNumber.Size = new System.Drawing.Size(24, 20);
            this.pbNationalNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNationalNumber.TabIndex = 66;
            this.pbNationalNumber.TabStop = false;
            // 
            // pbMale
            // 
            this.pbMale.Image = global::DVLD.Properties.Resources.Man_32;
            this.pbMale.Location = new System.Drawing.Point(114, 208);
            this.pbMale.Name = "pbMale";
            this.pbMale.Size = new System.Drawing.Size(24, 20);
            this.pbMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMale.TabIndex = 67;
            this.pbMale.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.Image = global::DVLD.Properties.Resources.Email_32;
            this.pbEmail.Location = new System.Drawing.Point(114, 236);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(24, 20);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 68;
            this.pbEmail.TabStop = false;
            // 
            // pbAddress
            // 
            this.pbAddress.Image = global::DVLD.Properties.Resources.Address_32;
            this.pbAddress.Location = new System.Drawing.Point(114, 271);
            this.pbAddress.Name = "pbAddress";
            this.pbAddress.Size = new System.Drawing.Size(24, 20);
            this.pbAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddress.TabIndex = 69;
            this.pbAddress.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbFemale
            // 
            this.pbFemale.Image = global::DVLD.Properties.Resources.Woman_32;
            this.pbFemale.Location = new System.Drawing.Point(191, 208);
            this.pbFemale.Name = "pbFemale";
            this.pbFemale.Size = new System.Drawing.Size(24, 20);
            this.pbFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFemale.TabIndex = 70;
            this.pbFemale.TabStop = false;
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(758, 419);
            this.Controls.Add(this.pbFemale);
            this.Controls.Add(this.pbAddress);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.pbMale);
            this.Controls.Add(this.pbNationalNumber);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.pbNationality);
            this.Controls.Add(this.pbPhone);
            this.Controls.Add(this.pbDateOfBirth);
            this.Controls.Add(this.linklabelRemove);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbThirdName);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbPersonIDValue);
            this.Controls.Add(this.linklabelSetImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNationalNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbNationalNumber);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel linklabelRemove;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbThirdName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbPersonIDValue;
        private System.Windows.Forms.LinkLabel linklabelSetImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNationalNumber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbNationalNumber;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbAddress;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbMale;
        private System.Windows.Forms.PictureBox pbNationalNumber;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbNationality;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbDateOfBirth;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbFemale;
    }
}