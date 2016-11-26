namespace VisitorManagementSystem
{
    partial class EmployeeForm
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
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelNicNumber = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxWorkPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPersonalAddress = new System.Windows.Forms.TextBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPersonalAddress = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNicNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.photoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxContactDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(13, 39);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.labelEmployeeId.TabIndex = 0;
            this.labelEmployeeId.Text = "Employee Id";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 66);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(13, 92);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelNicNumber
            // 
            this.labelNicNumber.AutoSize = true;
            this.labelNicNumber.Location = new System.Drawing.Point(285, 39);
            this.labelNicNumber.Name = "labelNicNumber";
            this.labelNicNumber.Size = new System.Drawing.Size(65, 13);
            this.labelNicNumber.TabIndex = 10;
            this.labelNicNumber.Text = "NIC Number";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(12, 119);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 6;
            this.labelDesignation.Text = "Designation";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(12, 144);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 8;
            this.labelDepartment.Text = "Department";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(285, 66);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 12;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(285, 92);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Gender";
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.textBoxOther);
            this.groupBoxContactDetails.Controls.Add(this.textBoxMobile);
            this.groupBoxContactDetails.Controls.Add(this.textBoxWorkPhone);
            this.groupBoxContactDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxContactDetails.Controls.Add(this.textBoxPersonalAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelOther);
            this.groupBoxContactDetails.Controls.Add(this.labelMobile);
            this.groupBoxContactDetails.Controls.Add(this.labelWork);
            this.groupBoxContactDetails.Controls.Add(this.labelPhone);
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelPersonalAddress);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(12, 171);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new System.Drawing.Size(654, 150);
            this.groupBoxContactDetails.TabIndex = 16;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(463, 85);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(174, 20);
            this.textBoxOther.TabIndex = 7;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(282, 85);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(174, 20);
            this.textBoxMobile.TabIndex = 6;
            // 
            // textBoxWorkPhone
            // 
            this.textBoxWorkPhone.Location = new System.Drawing.Point(102, 85);
            this.textBoxWorkPhone.Name = "textBoxWorkPhone";
            this.textBoxWorkPhone.Size = new System.Drawing.Size(174, 20);
            this.textBoxWorkPhone.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 59);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(535, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPersonalAddress
            // 
            this.textBoxPersonalAddress.Location = new System.Drawing.Point(102, 31);
            this.textBoxPersonalAddress.Name = "textBoxPersonalAddress";
            this.textBoxPersonalAddress.Size = new System.Drawing.Size(535, 20);
            this.textBoxPersonalAddress.TabIndex = 1;
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(536, 108);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(33, 13);
            this.labelOther.TabIndex = 5;
            this.labelOther.Text = "Other";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(350, 108);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(38, 13);
            this.labelMobile.TabIndex = 4;
            this.labelMobile.Text = "Mobile";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(167, 108);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(33, 13);
            this.labelWork.TabIndex = 3;
            this.labelWork.Text = "Work";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(7, 88);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(7, 62);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelPersonalAddress
            // 
            this.labelPersonalAddress.AutoSize = true;
            this.labelPersonalAddress.Location = new System.Drawing.Point(7, 34);
            this.labelPersonalAddress.Name = "labelPersonalAddress";
            this.labelPersonalAddress.Size = new System.Drawing.Size(89, 13);
            this.labelPersonalAddress.TabIndex = 0;
            this.labelPersonalAddress.Text = "Personal Address";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(91, 36);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(188, 20);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 63);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(188, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(91, 89);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(188, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(91, 116);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(188, 20);
            this.textBoxDesignation.TabIndex = 7;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(91, 141);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(188, 20);
            this.textBoxDepartment.TabIndex = 9;
            // 
            // maskedTextBoxNicNumber
            // 
            this.maskedTextBoxNicNumber.Location = new System.Drawing.Point(356, 36);
            this.maskedTextBoxNicNumber.Mask = "000000000<L";
            this.maskedTextBoxNicNumber.Name = "maskedTextBoxNicNumber";
            this.maskedTextBoxNicNumber.Size = new System.Drawing.Size(160, 20);
            this.maskedTextBoxNicNumber.TabIndex = 11;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(356, 63);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(356, 89);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(160, 21);
            this.comboBoxGender.TabIndex = 15;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(532, 36);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(134, 103);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 17;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPhoto.Location = new System.Drawing.Point(562, 144);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(75, 23);
            this.buttonPhoto.TabIndex = 17;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = false;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonSearch);
            this.groupBoxAction.Controls.Add(this.buttonViewAll);
            this.groupBoxAction.Controls.Add(this.buttonExit);
            this.groupBoxAction.Controls.Add(this.buttonSave);
            this.groupBoxAction.Controls.Add(this.buttonCancel);
            this.groupBoxAction.Controls.Add(this.buttonDelete);
            this.groupBoxAction.Controls.Add(this.buttonEdit);
            this.groupBoxAction.Controls.Add(this.buttonAddEmployee);
            this.groupBoxAction.Location = new System.Drawing.Point(672, 28);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(175, 293);
            this.groupBoxAction.TabIndex = 18;
            this.groupBoxAction.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSearch.Location = new System.Drawing.Point(52, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonViewAll.Location = new System.Drawing.Point(52, 221);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 6;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonExit.Location = new System.Drawing.Point(52, 251);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave.Location = new System.Drawing.Point(52, 90);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonCancel.Location = new System.Drawing.Point(52, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDelete.Location = new System.Drawing.Point(52, 148);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEdit.Location = new System.Drawing.Point(52, 119);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddEmployee.Location = new System.Drawing.Point(52, 49);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 35);
            this.buttonAddEmployee.TabIndex = 2;
            this.buttonAddEmployee.Text = "Add New";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 327);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(835, 160);
            this.dataGridViewEmployee.TabIndex = 20;
            // 
            // photoOpenFileDialog
            // 
            this.photoOpenFileDialog.FileName = "photoOpenFileDialog";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 499);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.maskedTextBoxNicNumber);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.groupBoxContactDetails);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelNicNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEmployeeId);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelNicNumber;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxWorkPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPersonalAddress;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPersonalAddress;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNicNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.OpenFileDialog photoOpenFileDialog;
    }
}