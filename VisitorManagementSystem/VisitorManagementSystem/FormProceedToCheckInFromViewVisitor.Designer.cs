namespace VisitorManagementSystem
{
    partial class FormProceedToCheckInFromViewVisitor
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
            this.textBoxVisitId = new System.Windows.Forms.TextBox();
            this.labelVisitId = new System.Windows.Forms.Label();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.labelApointmentId = new System.Windows.Forms.Label();
            this.checkBoxcheckedOut = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckedIn = new System.Windows.Forms.CheckBox();
            this.labelOutTime = new System.Windows.Forms.Label();
            this.lableSecurityId = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.groupBoxVisitorPass = new System.Windows.Forms.GroupBox();
            this.pictureBoxBarCode = new System.Windows.Forms.PictureBox();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxNicNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.labelNicNumber = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecurityAdminId = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.dateTimePickerInTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOutTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOutDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInDate = new System.Windows.Forms.DateTimePicker();
            this.labelOutDate = new System.Windows.Forms.Label();
            this.labelInDate = new System.Windows.Forms.Label();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.labelEmployeeLastName = new System.Windows.Forms.Label();
            this.labelEmployeeFirstname = new System.Windows.Forms.Label();
            this.groupBoxResponsibleEmployee = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.textBoxDaysStayed = new System.Windows.Forms.TextBox();
            this.textBoxPlaceStayed = new System.Windows.Forms.TextBox();
            this.labelDaysStayed = new System.Windows.Forms.Label();
            this.labelPlaceStayed = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxVisitorPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxResponsibleEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVisitId
            // 
            this.textBoxVisitId.Location = new System.Drawing.Point(98, 56);
            this.textBoxVisitId.Name = "textBoxVisitId";
            this.textBoxVisitId.Size = new System.Drawing.Size(164, 20);
            this.textBoxVisitId.TabIndex = 33;
            // 
            // labelVisitId
            // 
            this.labelVisitId.AutoSize = true;
            this.labelVisitId.Location = new System.Drawing.Point(7, 59);
            this.labelVisitId.Name = "labelVisitId";
            this.labelVisitId.Size = new System.Drawing.Size(38, 13);
            this.labelVisitId.TabIndex = 32;
            this.labelVisitId.Text = "Visit Id";
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.Location = new System.Drawing.Point(98, 82);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.Size = new System.Drawing.Size(164, 20);
            this.textBoxAppointmentId.TabIndex = 31;
            // 
            // labelApointmentId
            // 
            this.labelApointmentId.AutoSize = true;
            this.labelApointmentId.Location = new System.Drawing.Point(7, 85);
            this.labelApointmentId.Name = "labelApointmentId";
            this.labelApointmentId.Size = new System.Drawing.Size(78, 13);
            this.labelApointmentId.TabIndex = 30;
            this.labelApointmentId.Text = "Appointment Id";
            // 
            // checkBoxcheckedOut
            // 
            this.checkBoxcheckedOut.AutoSize = true;
            this.checkBoxcheckedOut.Location = new System.Drawing.Point(413, 62);
            this.checkBoxcheckedOut.Name = "checkBoxcheckedOut";
            this.checkBoxcheckedOut.Size = new System.Drawing.Size(89, 17);
            this.checkBoxcheckedOut.TabIndex = 29;
            this.checkBoxcheckedOut.Text = "Checked Out";
            this.checkBoxcheckedOut.UseVisualStyleBackColor = true;
            this.checkBoxcheckedOut.CheckedChanged += new System.EventHandler(this.checkBoxheckedOut_CheckedChanged);
            // 
            // checkBoxCheckedIn
            // 
            this.checkBoxCheckedIn.AutoSize = true;
            this.checkBoxCheckedIn.Location = new System.Drawing.Point(413, 36);
            this.checkBoxCheckedIn.Name = "checkBoxCheckedIn";
            this.checkBoxCheckedIn.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCheckedIn.TabIndex = 28;
            this.checkBoxCheckedIn.Text = "Checked In";
            this.checkBoxCheckedIn.UseVisualStyleBackColor = true;
            // 
            // labelOutTime
            // 
            this.labelOutTime.AutoSize = true;
            this.labelOutTime.Location = new System.Drawing.Point(290, 146);
            this.labelOutTime.Name = "labelOutTime";
            this.labelOutTime.Size = new System.Drawing.Size(50, 13);
            this.labelOutTime.TabIndex = 26;
            this.labelOutTime.Text = "Out Time";
            // 
            // lableSecurityId
            // 
            this.lableSecurityId.AutoSize = true;
            this.lableSecurityId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lableSecurityId.Location = new System.Drawing.Point(115, 19);
            this.lableSecurityId.Name = "lableSecurityId";
            this.lableSecurityId.Size = new System.Drawing.Size(2, 15);
            this.lableSecurityId.TabIndex = 25;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(280, 599);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(110, 37);
            this.buttonPrint.TabIndex = 23;
            this.buttonPrint.Text = "Print Pass";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // groupBoxVisitorPass
            // 
            this.groupBoxVisitorPass.Controls.Add(this.pictureBoxBarCode);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxOrganization);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxDesignation);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxLastName);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxNicNumber);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxFirstName);
            this.groupBoxVisitorPass.Controls.Add(this.textBoxVisitorId);
            this.groupBoxVisitorPass.Controls.Add(this.pictureBoxPhoto);
            this.groupBoxVisitorPass.Controls.Add(this.labelDesignation);
            this.groupBoxVisitorPass.Controls.Add(this.labelOrganization);
            this.groupBoxVisitorPass.Controls.Add(this.labelVisitorId);
            this.groupBoxVisitorPass.Controls.Add(this.labelNicNumber);
            this.groupBoxVisitorPass.Controls.Add(this.labelLastName);
            this.groupBoxVisitorPass.Controls.Add(this.labelFirstName);
            this.groupBoxVisitorPass.Location = new System.Drawing.Point(15, 300);
            this.groupBoxVisitorPass.Name = "groupBoxVisitorPass";
            this.groupBoxVisitorPass.Size = new System.Drawing.Size(493, 213);
            this.groupBoxVisitorPass.TabIndex = 22;
            this.groupBoxVisitorPass.TabStop = false;
            this.groupBoxVisitorPass.Text = "Visitor Pass";
            // 
            // pictureBoxBarCode
            // 
            this.pictureBoxBarCode.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBoxBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBarCode.Location = new System.Drawing.Point(39, 135);
            this.pictureBoxBarCode.Name = "pictureBoxBarCode";
            this.pictureBoxBarCode.Size = new System.Drawing.Size(401, 52);
            this.pictureBoxBarCode.TabIndex = 9;
            this.pictureBoxBarCode.TabStop = false;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(255, 61);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(99, 20);
            this.textBoxOrganization.TabIndex = 15;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(255, 87);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(99, 20);
            this.textBoxDesignation.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(77, 89);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(99, 20);
            this.textBoxLastName.TabIndex = 13;
            // 
            // textBoxNicNumber
            // 
            this.textBoxNicNumber.Location = new System.Drawing.Point(255, 33);
            this.textBoxNicNumber.Name = "textBoxNicNumber";
            this.textBoxNicNumber.Size = new System.Drawing.Size(99, 20);
            this.textBoxNicNumber.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(77, 63);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(99, 20);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(77, 37);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(99, 20);
            this.textBoxVisitorId.TabIndex = 10;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(372, 19);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(104, 101);
            this.pictureBoxPhoto.TabIndex = 9;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(184, 94);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 8;
            this.labelDesignation.Text = "Designation";
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Location = new System.Drawing.Point(183, 63);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(66, 13);
            this.labelOrganization.TabIndex = 7;
            this.labelOrganization.Text = "Organization";
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(12, 40);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 3;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // labelNicNumber
            // 
            this.labelNicNumber.AutoSize = true;
            this.labelNicNumber.Location = new System.Drawing.Point(184, 37);
            this.labelNicNumber.Name = "labelNicNumber";
            this.labelNicNumber.Size = new System.Drawing.Size(65, 13);
            this.labelNicNumber.TabIndex = 4;
            this.labelNicNumber.Text = "NIC Number";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 94);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 66);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // labelSecurityAdminId
            // 
            this.labelSecurityAdminId.AutoSize = true;
            this.labelSecurityAdminId.Location = new System.Drawing.Point(8, 19);
            this.labelSecurityAdminId.Name = "labelSecurityAdminId";
            this.labelSecurityAdminId.Size = new System.Drawing.Size(89, 13);
            this.labelSecurityAdminId.TabIndex = 21;
            this.labelSecurityAdminId.Text = "Security Admin Id";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Location = new System.Drawing.Point(7, 146);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(42, 13);
            this.labelInTime.TabIndex = 19;
            this.labelInTime.Text = "In Time";
            // 
            // dateTimePickerInTime
            // 
            this.dateTimePickerInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInTime.Location = new System.Drawing.Point(98, 146);
            this.dateTimePickerInTime.Name = "dateTimePickerInTime";
            this.dateTimePickerInTime.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerInTime.TabIndex = 34;
            // 
            // dateTimePickerOutTime
            // 
            this.dateTimePickerOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOutTime.Location = new System.Drawing.Point(346, 146);
            this.dateTimePickerOutTime.Name = "dateTimePickerOutTime";
            this.dateTimePickerOutTime.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerOutTime.TabIndex = 35;
            // 
            // dateTimePickerOutDate
            // 
            this.dateTimePickerOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOutDate.Location = new System.Drawing.Point(346, 115);
            this.dateTimePickerOutDate.Name = "dateTimePickerOutDate";
            this.dateTimePickerOutDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerOutDate.TabIndex = 39;
            // 
            // dateTimePickerInDate
            // 
            this.dateTimePickerInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInDate.Location = new System.Drawing.Point(98, 115);
            this.dateTimePickerInDate.Name = "dateTimePickerInDate";
            this.dateTimePickerInDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerInDate.TabIndex = 38;
            // 
            // labelOutDate
            // 
            this.labelOutDate.AutoSize = true;
            this.labelOutDate.Location = new System.Drawing.Point(290, 115);
            this.labelOutDate.Name = "labelOutDate";
            this.labelOutDate.Size = new System.Drawing.Size(50, 13);
            this.labelOutDate.TabIndex = 37;
            this.labelOutDate.Text = "Out Date";
            // 
            // labelInDate
            // 
            this.labelInDate.AutoSize = true;
            this.labelInDate.Location = new System.Drawing.Point(8, 121);
            this.labelInDate.Name = "labelInDate";
            this.labelInDate.Size = new System.Drawing.Size(42, 13);
            this.labelInDate.TabIndex = 36;
            this.labelInDate.Text = "In Date";
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(317, 44);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(171, 20);
            this.textBoxEmployeeLastName.TabIndex = 43;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(80, 44);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(170, 20);
            this.textBoxEmployeeFirstName.TabIndex = 42;
            // 
            // labelEmployeeLastName
            // 
            this.labelEmployeeLastName.AutoSize = true;
            this.labelEmployeeLastName.Location = new System.Drawing.Point(256, 51);
            this.labelEmployeeLastName.Name = "labelEmployeeLastName";
            this.labelEmployeeLastName.Size = new System.Drawing.Size(58, 13);
            this.labelEmployeeLastName.TabIndex = 40;
            this.labelEmployeeLastName.Text = "Last Name";
            // 
            // labelEmployeeFirstname
            // 
            this.labelEmployeeFirstname.AutoSize = true;
            this.labelEmployeeFirstname.Location = new System.Drawing.Point(15, 47);
            this.labelEmployeeFirstname.Name = "labelEmployeeFirstname";
            this.labelEmployeeFirstname.Size = new System.Drawing.Size(57, 13);
            this.labelEmployeeFirstname.TabIndex = 41;
            this.labelEmployeeFirstname.Text = "First Name";
            // 
            // groupBoxResponsibleEmployee
            // 
            this.groupBoxResponsibleEmployee.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxResponsibleEmployee.Controls.Add(this.labelEmployeeId);
            this.groupBoxResponsibleEmployee.Controls.Add(this.textBoxEmployeeFirstName);
            this.groupBoxResponsibleEmployee.Controls.Add(this.textBoxEmployeeLastName);
            this.groupBoxResponsibleEmployee.Controls.Add(this.labelEmployeeFirstname);
            this.groupBoxResponsibleEmployee.Controls.Add(this.labelEmployeeLastName);
            this.groupBoxResponsibleEmployee.Location = new System.Drawing.Point(12, 216);
            this.groupBoxResponsibleEmployee.Name = "groupBoxResponsibleEmployee";
            this.groupBoxResponsibleEmployee.Size = new System.Drawing.Size(496, 78);
            this.groupBoxResponsibleEmployee.TabIndex = 44;
            this.groupBoxResponsibleEmployee.TabStop = false;
            this.groupBoxResponsibleEmployee.Text = "Responsible Employee Details";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(80, 19);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(170, 20);
            this.textBoxEmployeeId.TabIndex = 45;
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Location = new System.Drawing.Point(15, 22);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.labelEmployeeId.TabIndex = 44;
            this.labelEmployeeId.Text = "Employee Id";
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Location = new System.Drawing.Point(98, 181);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(404, 20);
            this.textBoxPurpose.TabIndex = 46;
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(9, 184);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(62, 13);
            this.labelPurpose.TabIndex = 45;
            this.labelPurpose.Text = "Visit Purose";
            // 
            // textBoxDaysStayed
            // 
            this.textBoxDaysStayed.Location = new System.Drawing.Point(115, 530);
            this.textBoxDaysStayed.Name = "textBoxDaysStayed";
            this.textBoxDaysStayed.Size = new System.Drawing.Size(393, 20);
            this.textBoxDaysStayed.TabIndex = 49;
            // 
            // textBoxPlaceStayed
            // 
            this.textBoxPlaceStayed.Location = new System.Drawing.Point(115, 566);
            this.textBoxPlaceStayed.Name = "textBoxPlaceStayed";
            this.textBoxPlaceStayed.Size = new System.Drawing.Size(393, 20);
            this.textBoxPlaceStayed.TabIndex = 50;
            // 
            // labelDaysStayed
            // 
            this.labelDaysStayed.AutoSize = true;
            this.labelDaysStayed.Location = new System.Drawing.Point(15, 533);
            this.labelDaysStayed.Name = "labelDaysStayed";
            this.labelDaysStayed.Size = new System.Drawing.Size(98, 13);
            this.labelDaysStayed.TabIndex = 48;
            this.labelDaysStayed.Text = "No Of Days Stayed";
            // 
            // labelPlaceStayed
            // 
            this.labelPlaceStayed.AutoSize = true;
            this.labelPlaceStayed.Location = new System.Drawing.Point(15, 569);
            this.labelPlaceStayed.Name = "labelPlaceStayed";
            this.labelPlaceStayed.Size = new System.Drawing.Size(70, 13);
            this.labelPlaceStayed.TabIndex = 47;
            this.labelPlaceStayed.Text = "Place Stayed";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(396, 599);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 37);
            this.buttonClose.TabIndex = 51;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormProceedToCheckInFromViewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(525, 648);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxDaysStayed);
            this.Controls.Add(this.textBoxPlaceStayed);
            this.Controls.Add(this.labelDaysStayed);
            this.Controls.Add(this.labelPlaceStayed);
            this.Controls.Add(this.textBoxPurpose);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.groupBoxResponsibleEmployee);
            this.Controls.Add(this.dateTimePickerOutDate);
            this.Controls.Add(this.dateTimePickerInDate);
            this.Controls.Add(this.labelOutDate);
            this.Controls.Add(this.labelInDate);
            this.Controls.Add(this.dateTimePickerOutTime);
            this.Controls.Add(this.dateTimePickerInTime);
            this.Controls.Add(this.textBoxVisitId);
            this.Controls.Add(this.labelVisitId);
            this.Controls.Add(this.textBoxAppointmentId);
            this.Controls.Add(this.labelApointmentId);
            this.Controls.Add(this.checkBoxcheckedOut);
            this.Controls.Add(this.checkBoxCheckedIn);
            this.Controls.Add(this.labelOutTime);
            this.Controls.Add(this.lableSecurityId);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBoxVisitorPass);
            this.Controls.Add(this.labelSecurityAdminId);
            this.Controls.Add(this.labelInTime);
            this.Name = "FormProceedToCheckInFromViewVisitor";
            this.Text = "Visitor Checkin";
            this.Load += new System.EventHandler(this.FormProceedToCheckInFromViewVisitor_Load);
            this.groupBoxVisitorPass.ResumeLayout(false);
            this.groupBoxVisitorPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxResponsibleEmployee.ResumeLayout(false);
            this.groupBoxResponsibleEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVisitId;
        private System.Windows.Forms.Label labelVisitId;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.Label labelApointmentId;
        private System.Windows.Forms.CheckBox checkBoxcheckedOut;
        private System.Windows.Forms.CheckBox checkBoxCheckedIn;
        private System.Windows.Forms.Label labelOutTime;
        private System.Windows.Forms.Label lableSecurityId;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.GroupBox groupBoxVisitorPass;
        private System.Windows.Forms.PictureBox pictureBoxBarCode;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxNicNumber;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.Label labelNicNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSecurityAdminId;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerInTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInDate;
        private System.Windows.Forms.Label labelOutDate;
        private System.Windows.Forms.Label labelInDate;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.Label labelEmployeeLastName;
        private System.Windows.Forms.Label labelEmployeeFirstname;
        private System.Windows.Forms.GroupBox groupBoxResponsibleEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.TextBox textBoxDaysStayed;
        private System.Windows.Forms.TextBox textBoxPlaceStayed;
        private System.Windows.Forms.Label labelDaysStayed;
        private System.Windows.Forms.Label labelPlaceStayed;
        private System.Windows.Forms.Button buttonClose;
    }
}