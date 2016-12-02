namespace VisitorManagementSystem
{
    partial class FormViewVisitorToManager
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
            this.dataGridViewViewVisitorToManager = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitorToManager)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(653, 579);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 32);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonMoreDetails.Location = new System.Drawing.Point(180, 579);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(108, 32);
            this.buttonMoreDetails.TabIndex = 19;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = false;
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonViewHistory.Location = new System.Drawing.Point(336, 579);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(108, 32);
            this.buttonViewHistory.TabIndex = 18;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = false;
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddAppointment.Location = new System.Drawing.Point(505, 579);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(108, 32);
            this.buttonAddAppointment.TabIndex = 17;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Location = new System.Drawing.Point(28, 579);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 32);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // dataGridViewViewVisitorToManager
            // 
            this.dataGridViewViewVisitorToManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisitorToManager.Location = new System.Drawing.Point(13, 112);
            this.dataGridViewViewVisitorToManager.Name = "dataGridViewViewVisitorToManager";
            this.dataGridViewViewVisitorToManager.Size = new System.Drawing.Size(748, 451);
            this.dataGridViewViewVisitorToManager.TabIndex = 14;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(166, 56);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 30;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 49);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 29;
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
            this.comboBoxSelectAppointments.Location = new System.Drawing.Point(389, 53);
            this.comboBoxSelectAppointments.Name = "comboBoxSelectAppointments";
            this.comboBoxSelectAppointments.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectAppointments.TabIndex = 28;
            // 
            // labelSelectAppointments
            // 
            this.labelSelectAppointments.AutoSize = true;
            this.labelSelectAppointments.Location = new System.Drawing.Point(279, 56);
            this.labelSelectAppointments.Name = "labelSelectAppointments";
            this.labelSelectAppointments.Size = new System.Drawing.Size(104, 13);
            this.labelSelectAppointments.TabIndex = 27;
            this.labelSelectAppointments.Text = "Select Appointments";
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(14, 85);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 26;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(605, 68);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 25;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(605, 46);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 24;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(579, 74);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 23;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(569, 52);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 22;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(550, 29);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 21;
            this.labelSelectDate.Text = "Select Date";
            // 
            // FormViewVisitorToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(777, 626);
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
            this.Controls.Add(this.dataGridViewViewVisitorToManager);
            this.Name = "FormViewVisitorToManager";
            this.Text = "View Visitor";
            this.Load += new System.EventHandler(this.FormViewVisitorToManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitorToManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.Button buttonViewHistory;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewViewVisitorToManager;
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