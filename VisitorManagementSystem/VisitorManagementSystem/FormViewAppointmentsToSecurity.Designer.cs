namespace VisitorManagementSystem
{
    partial class FormViewAppointmentsToSecurity
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
            this.buttonCheckAuthorization = new System.Windows.Forms.Button();
            this.buttonProceedToCheckIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.dataGridViewViewAppointments = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectAppointments = new System.Windows.Forms.ComboBox();
            this.labelSelectAppointments = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckAuthorization
            // 
            this.buttonCheckAuthorization.Location = new System.Drawing.Point(405, 446);
            this.buttonCheckAuthorization.Name = "buttonCheckAuthorization";
            this.buttonCheckAuthorization.Size = new System.Drawing.Size(144, 37);
            this.buttonCheckAuthorization.TabIndex = 39;
            this.buttonCheckAuthorization.Text = "Check Authorization";
            this.buttonCheckAuthorization.UseVisualStyleBackColor = true;
            // 
            // buttonProceedToCheckIn
            // 
            this.buttonProceedToCheckIn.Location = new System.Drawing.Point(569, 446);
            this.buttonProceedToCheckIn.Name = "buttonProceedToCheckIn";
            this.buttonProceedToCheckIn.Size = new System.Drawing.Size(144, 37);
            this.buttonProceedToCheckIn.TabIndex = 38;
            this.buttonProceedToCheckIn.Text = "Proceed To Check in";
            this.buttonProceedToCheckIn.UseVisualStyleBackColor = true;
            this.buttonProceedToCheckIn.Click += new System.EventHandler(this.buttonProceedToCheckIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(737, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 37);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(684, 57);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 36;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(684, 35);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 35;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(658, 63);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 34;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(648, 41);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 33;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(629, 18);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 32;
            this.labelSelectDate.Text = "Select Date";
            // 
            // dataGridViewViewAppointments
            // 
            this.dataGridViewViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewAppointments.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewViewAppointments.Name = "dataGridViewViewAppointments";
            this.dataGridViewViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewAppointments.Size = new System.Drawing.Size(831, 346);
            this.dataGridViewViewAppointments.TabIndex = 31;
            // 
            // comboBoxSelectAppointments
            // 
            this.comboBoxSelectAppointments.FormattingEnabled = true;
            this.comboBoxSelectAppointments.Items.AddRange(new object[] {
            "All",
            "Approved",
            "Pending Requests",
            "Checked In",
            "Checked Out"});
            this.comboBoxSelectAppointments.Location = new System.Drawing.Point(429, 38);
            this.comboBoxSelectAppointments.Name = "comboBoxSelectAppointments";
            this.comboBoxSelectAppointments.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectAppointments.TabIndex = 41;
            // 
            // labelSelectAppointments
            // 
            this.labelSelectAppointments.AutoSize = true;
            this.labelSelectAppointments.Location = new System.Drawing.Point(319, 41);
            this.labelSelectAppointments.Name = "labelSelectAppointments";
            this.labelSelectAppointments.Size = new System.Drawing.Size(104, 13);
            this.labelSelectAppointments.TabIndex = 40;
            this.labelSelectAppointments.Text = "Select Appointments";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(162, 34);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 43;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(13, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 42;
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(12, 57);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 44;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // FormViewAppointmentsToSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSelectAppointments);
            this.Controls.Add(this.labelSelectAppointments);
            this.Controls.Add(this.buttonCheckAuthorization);
            this.Controls.Add(this.buttonProceedToCheckIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.dataGridViewViewAppointments);
            this.Name = "FormViewAppointmentsToSecurity";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.FormViewAppointmentsToSecurity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckAuthorization;
        private System.Windows.Forms.Button buttonProceedToCheckIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.DataGridView dataGridViewViewAppointments;
        private System.Windows.Forms.ComboBox comboBoxSelectAppointments;
        private System.Windows.Forms.Label labelSelectAppointments;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelClickToSelect;
    }
}