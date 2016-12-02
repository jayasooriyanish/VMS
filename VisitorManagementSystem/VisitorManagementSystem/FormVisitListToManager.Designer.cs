namespace VisitorManagementSystem
{
    partial class FormVisitListToManager
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSelectAppointments = new System.Windows.Forms.ComboBox();
            this.labelSelectAppointments = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            this.buttonAddNewAppointment = new System.Windows.Forms.Button();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(164, 43);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 27;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(15, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 26;
            // 
            // comboBoxSelectAppointments
            // 
            this.comboBoxSelectAppointments.FormattingEnabled = true;
            this.comboBoxSelectAppointments.Items.AddRange(new object[] {
            "All",
            "Approved",
            "Blocked",
            "Pending Requests",
            "Checked In",
            "Checked Out"});
            this.comboBoxSelectAppointments.Location = new System.Drawing.Point(385, 40);
            this.comboBoxSelectAppointments.Name = "comboBoxSelectAppointments";
            this.comboBoxSelectAppointments.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectAppointments.TabIndex = 25;
            // 
            // labelSelectAppointments
            // 
            this.labelSelectAppointments.AutoSize = true;
            this.labelSelectAppointments.Location = new System.Drawing.Point(275, 43);
            this.labelSelectAppointments.Name = "labelSelectAppointments";
            this.labelSelectAppointments.Size = new System.Drawing.Size(104, 13);
            this.labelSelectAppointments.TabIndex = 24;
            this.labelSelectAppointments.Text = "Select Appointments";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(666, 511);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(93, 32);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(12, 77);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 22;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // buttonAddNewAppointment
            // 
            this.buttonAddNewAppointment.Location = new System.Drawing.Point(522, 511);
            this.buttonAddNewAppointment.Name = "buttonAddNewAppointment";
            this.buttonAddNewAppointment.Size = new System.Drawing.Size(121, 32);
            this.buttonAddNewAppointment.TabIndex = 21;
            this.buttonAddNewAppointment.Text = "Add New Appointment";
            this.buttonAddNewAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.Location = new System.Drawing.Point(406, 511);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(93, 32);
            this.buttonMoreDetails.TabIndex = 20;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(603, 60);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 19;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(603, 38);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 18;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(577, 66);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 17;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(567, 44);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 16;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(548, 21);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 15;
            this.labelSelectDate.Text = "Select Date";
            // 
            // FormVisitListToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 553);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSelectAppointments);
            this.Controls.Add(this.labelSelectAppointments);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.buttonAddNewAppointment);
            this.Controls.Add(this.buttonMoreDetails);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVisitListToManager";
            this.Text = "Visit List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSelectAppointments;
        private System.Windows.Forms.Label labelSelectAppointments;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelClickToSelect;
        private System.Windows.Forms.Button buttonAddNewAppointment;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
    }
}