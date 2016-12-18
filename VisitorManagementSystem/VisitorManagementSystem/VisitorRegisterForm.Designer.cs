namespace VisitorManagementSystem
{
    partial class VisitorRegisterForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelNicNumber = new System.Windows.Forms.Label();
            this.lableDateOfBirth = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.textBoxCompanyAddress = new System.Windows.Forms.TextBox();
            this.textBoxPersonalAddress = new System.Windows.Forms.TextBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxWorkPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCompanyAddress = new System.Windows.Forms.Label();
            this.labelPersonalAddress = new System.Windows.Forms.Label();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNicNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveAndAddAppointment = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.photoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxContactDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(12, 40);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 0;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 62);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 86);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Location = new System.Drawing.Point(12, 109);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(66, 13);
            this.labelOrganization.TabIndex = 6;
            this.labelOrganization.Text = "Organization";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(12, 133);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 8;
            this.labelDesignation.Text = "Designation";
            // 
            // labelNicNumber
            // 
            this.labelNicNumber.AutoSize = true;
            this.labelNicNumber.Location = new System.Drawing.Point(269, 62);
            this.labelNicNumber.Name = "labelNicNumber";
            this.labelNicNumber.Size = new System.Drawing.Size(68, 13);
            this.labelNicNumber.TabIndex = 12;
            this.labelNicNumber.Text = "NIC Number ";
            // 
            // lableDateOfBirth
            // 
            this.lableDateOfBirth.AutoSize = true;
            this.lableDateOfBirth.Location = new System.Drawing.Point(263, 90);
            this.lableDateOfBirth.Name = "lableDateOfBirth";
            this.lableDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lableDateOfBirth.TabIndex = 14;
            this.lableDateOfBirth.Text = "Date Of Birth";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(282, 40);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(285, 116);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "Gender";
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.textBoxCompanyAddress);
            this.groupBoxContactDetails.Controls.Add(this.textBoxPersonalAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelOther);
            this.groupBoxContactDetails.Controls.Add(this.labelMobile);
            this.groupBoxContactDetails.Controls.Add(this.labelWork);
            this.groupBoxContactDetails.Controls.Add(this.textBoxOther);
            this.groupBoxContactDetails.Controls.Add(this.textBoxMobile);
            this.groupBoxContactDetails.Controls.Add(this.textBoxWorkPhone);
            this.groupBoxContactDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelPhone);
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelCompanyAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelPersonalAddress);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(15, 160);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new System.Drawing.Size(633, 175);
            this.groupBoxContactDetails.TabIndex = 18;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // textBoxCompanyAddress
            // 
            this.textBoxCompanyAddress.Location = new System.Drawing.Point(101, 59);
            this.textBoxCompanyAddress.Name = "textBoxCompanyAddress";
            this.textBoxCompanyAddress.Size = new System.Drawing.Size(526, 20);
            this.textBoxCompanyAddress.TabIndex = 3;
            // 
            // textBoxPersonalAddress
            // 
            this.textBoxPersonalAddress.Location = new System.Drawing.Point(101, 27);
            this.textBoxPersonalAddress.Name = "textBoxPersonalAddress";
            this.textBoxPersonalAddress.Size = new System.Drawing.Size(526, 20);
            this.textBoxPersonalAddress.TabIndex = 1;
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(526, 148);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(33, 13);
            this.labelOther.TabIndex = 12;
            this.labelOther.Text = "Other";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(336, 148);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(38, 13);
            this.labelMobile.TabIndex = 11;
            this.labelMobile.Text = "Mobile";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(166, 148);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(33, 13);
            this.labelWork.TabIndex = 10;
            this.labelWork.Text = "Work";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(453, 125);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(174, 20);
            this.textBoxOther.TabIndex = 9;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(273, 125);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(174, 20);
            this.textBoxMobile.TabIndex = 8;
            // 
            // textBoxWorkPhone
            // 
            this.textBoxWorkPhone.Location = new System.Drawing.Point(101, 125);
            this.textBoxWorkPhone.Name = "textBoxWorkPhone";
            this.textBoxWorkPhone.Size = new System.Drawing.Size(166, 20);
            this.textBoxWorkPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(101, 92);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(526, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(8, 121);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 95);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(6, 62);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(92, 13);
            this.labelCompanyAddress.TabIndex = 2;
            this.labelCompanyAddress.Text = "Company Address";
            // 
            // labelPersonalAddress
            // 
            this.labelPersonalAddress.AutoSize = true;
            this.labelPersonalAddress.Location = new System.Drawing.Point(6, 30);
            this.labelPersonalAddress.Name = "labelPersonalAddress";
            this.labelPersonalAddress.Size = new System.Drawing.Size(89, 13);
            this.labelPersonalAddress.TabIndex = 0;
            this.labelPersonalAddress.Text = "Personal Address";
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(77, 37);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(183, 20);
            this.textBoxVisitorId.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(77, 59);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(77, 83);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(183, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(77, 106);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(183, 20);
            this.textBoxOrganization.TabIndex = 7;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(77, 130);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(183, 20);
            this.textBoxDesignation.TabIndex = 9;
            // 
            // maskedTextBoxNicNumber
            // 
            this.maskedTextBoxNicNumber.Location = new System.Drawing.Point(337, 62);
            this.maskedTextBoxNicNumber.Mask = "000000000<L";
            this.maskedTextBoxNicNumber.Name = "maskedTextBoxNicNumber";
            this.maskedTextBoxNicNumber.Size = new System.Drawing.Size(183, 20);
            this.maskedTextBoxNicNumber.TabIndex = 13;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(337, 86);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 15;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(337, 113);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(183, 21);
            this.comboBoxGender.TabIndex = 17;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(542, 33);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(100, 101);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 19;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Regular",
            "Special"});
            this.comboBoxCategory.Location = new System.Drawing.Point(337, 37);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(183, 21);
            this.comboBoxCategory.TabIndex = 11;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPhoto.Location = new System.Drawing.Point(554, 140);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(75, 23);
            this.buttonPhoto.TabIndex = 19;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = false;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonViewHistory);
            this.groupBoxAction.Controls.Add(this.buttonViewAll);
            this.groupBoxAction.Controls.Add(this.buttonSearch);
            this.groupBoxAction.Controls.Add(this.buttonExit);
            this.groupBoxAction.Controls.Add(this.buttonAddAppointment);
            this.groupBoxAction.Controls.Add(this.buttonCancel);
            this.groupBoxAction.Controls.Add(this.buttonDelete);
            this.groupBoxAction.Controls.Add(this.buttonSaveAndAddAppointment);
            this.groupBoxAction.Controls.Add(this.buttonSave);
            this.groupBoxAction.Controls.Add(this.buttonAddNew);
            this.groupBoxAction.Location = new System.Drawing.Point(654, 24);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(127, 548);
            this.groupBoxAction.TabIndex = 20;
            this.groupBoxAction.TabStop = false;
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonViewHistory.Location = new System.Drawing.Point(27, 414);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonViewHistory.TabIndex = 9;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = false;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonViewAll.Location = new System.Drawing.Point(27, 460);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 8;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSearch.Location = new System.Drawing.Point(27, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonExit.Location = new System.Drawing.Point(27, 498);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddAppointment.Location = new System.Drawing.Point(27, 222);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(75, 48);
            this.buttonAddAppointment.TabIndex = 5;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonCancel.Location = new System.Drawing.Point(27, 288);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDelete.Location = new System.Drawing.Point(27, 329);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveAndAddAppointment
            // 
            this.buttonSaveAndAddAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSaveAndAddAppointment.Location = new System.Drawing.Point(27, 156);
            this.buttonSaveAndAddAppointment.Name = "buttonSaveAndAddAppointment";
            this.buttonSaveAndAddAppointment.Size = new System.Drawing.Size(75, 55);
            this.buttonSaveAndAddAppointment.TabIndex = 2;
            this.buttonSaveAndAddAppointment.Text = "Save And Add Appointment";
            this.buttonSaveAndAddAppointment.UseVisualStyleBackColor = false;
            this.buttonSaveAndAddAppointment.Click += new System.EventHandler(this.buttonSaveAndAddAppointment_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave.Location = new System.Drawing.Point(27, 79);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddNew.Location = new System.Drawing.Point(27, 116);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // photoOpenFileDialog
            // 
            this.photoOpenFileDialog.FileName = "photoOpenFileDialog";
            // 
            // VisitorRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(793, 587);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.maskedTextBoxNicNumber);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxOrganization);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.groupBoxContactDetails);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.lableDateOfBirth);
            this.Controls.Add(this.labelNicNumber);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelOrganization);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelVisitorId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisitorRegisterForm";
            this.Text = "Visitor";
            this.Load += new System.EventHandler(this.VisitorRegisterForm_Load);
            this.CursorChanged += new System.EventHandler(this.VisitorRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelNicNumber;
        private System.Windows.Forms.Label lableDateOfBirth;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxWorkPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCompanyAddress;
        private System.Windows.Forms.Label labelPersonalAddress;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNicNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonSaveAndAddAppointment;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.OpenFileDialog photoOpenFileDialog;
        private System.Windows.Forms.TextBox textBoxCompanyAddress;
        private System.Windows.Forms.TextBox textBoxPersonalAddress;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonViewHistory;
    }
}