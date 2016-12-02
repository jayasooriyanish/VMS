namespace VisitorManagementSystem
{
    partial class FormViewVisitorToSecurity
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewViewVisitorToSecurity = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSelectAppointments = new System.Windows.Forms.ComboBox();
            this.labelSelectAppointments = new System.Windows.Forms.Label();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitorToSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(682, 573);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 32);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonMoreDetails.Location = new System.Drawing.Point(199, 573);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(108, 32);
            this.buttonMoreDetails.TabIndex = 12;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = false;
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonViewHistory.Location = new System.Drawing.Point(357, 573);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(108, 32);
            this.buttonViewHistory.TabIndex = 11;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = false;
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddAppointment.Location = new System.Drawing.Point(521, 573);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(108, 32);
            this.buttonAddAppointment.TabIndex = 10;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Location = new System.Drawing.Point(46, 573);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 32);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewViewVisitorToSecurity
            // 
            this.dataGridViewViewVisitorToSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisitorToSecurity.Location = new System.Drawing.Point(15, 106);
            this.dataGridViewViewVisitorToSecurity.Name = "dataGridViewViewVisitorToSecurity";
            this.dataGridViewViewVisitorToSecurity.Size = new System.Drawing.Size(811, 451);
            this.dataGridViewViewVisitorToSecurity.TabIndex = 7;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(173, 63);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 50;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(24, 56);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 49;
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
            this.comboBoxSelectAppointments.Location = new System.Drawing.Point(437, 56);
            this.comboBoxSelectAppointments.Name = "comboBoxSelectAppointments";
            this.comboBoxSelectAppointments.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectAppointments.TabIndex = 48;
            // 
            // labelSelectAppointments
            // 
            this.labelSelectAppointments.AutoSize = true;
            this.labelSelectAppointments.Location = new System.Drawing.Point(327, 59);
            this.labelSelectAppointments.Name = "labelSelectAppointments";
            this.labelSelectAppointments.Size = new System.Drawing.Size(104, 13);
            this.labelSelectAppointments.TabIndex = 47;
            this.labelSelectAppointments.Text = "Select Appointments";
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(10, 82);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 46;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(661, 75);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 45;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(661, 53);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 44;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(635, 81);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 43;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(625, 59);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 42;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(606, 36);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 41;
            this.labelSelectDate.Text = "Select Date";
            // 
            // FormViewVisitorToSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(841, 617);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSelectAppointments);
            this.Controls.Add(this.labelSelectAppointments);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMoreDetails);
            this.Controls.Add(this.buttonViewHistory);
            this.Controls.Add(this.buttonAddAppointment);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewViewVisitorToSecurity);
            this.Name = "FormViewVisitorToSecurity";
            this.Text = "View Visitor";
            this.Load += new System.EventHandler(this.FormViewVisitorToSecurity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitorToSecurity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.Button buttonViewHistory;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewViewVisitorToSecurity;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSelectAppointments;
        private System.Windows.Forms.Label labelSelectAppointments;
        private System.Windows.Forms.Label labelClickToSelect;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
    }
}