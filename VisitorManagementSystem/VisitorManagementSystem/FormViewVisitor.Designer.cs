namespace VisitorManagementSystem
{
    partial class FormViewVisitor
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
            this.dataGridViewViewVisitor = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewVisitor
            // 
            this.dataGridViewViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisitor.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewViewVisitor.Name = "dataGridViewViewVisitor";
            this.dataGridViewViewVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewVisitor.Size = new System.Drawing.Size(811, 451);
            this.dataGridViewViewVisitor.TabIndex = 0;
            this.dataGridViewViewVisitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViewVisitor_CellContentClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Location = new System.Drawing.Point(43, 553);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 32);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddAppointment.Location = new System.Drawing.Point(518, 553);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(108, 32);
            this.buttonAddAppointment.TabIndex = 3;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonViewHistory.Location = new System.Drawing.Point(354, 553);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(108, 32);
            this.buttonViewHistory.TabIndex = 4;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = false;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonMoreDetails.Location = new System.Drawing.Point(196, 553);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(108, 32);
            this.buttonMoreDetails.TabIndex = 5;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = false;
            this.buttonMoreDetails.Click += new System.EventHandler(this.buttonMoreDetails_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(679, 553);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 32);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(179, 53);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 40;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(30, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 39;
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
            this.comboBoxSelectAppointments.Location = new System.Drawing.Point(443, 46);
            this.comboBoxSelectAppointments.Name = "comboBoxSelectAppointments";
            this.comboBoxSelectAppointments.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectAppointments.TabIndex = 38;
            // 
            // labelSelectAppointments
            // 
            this.labelSelectAppointments.AutoSize = true;
            this.labelSelectAppointments.Location = new System.Drawing.Point(333, 49);
            this.labelSelectAppointments.Name = "labelSelectAppointments";
            this.labelSelectAppointments.Size = new System.Drawing.Size(104, 13);
            this.labelSelectAppointments.TabIndex = 37;
            this.labelSelectAppointments.Text = "Select Appointments";
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(16, 72);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 36;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(667, 65);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 35;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(667, 43);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 34;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(641, 71);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 33;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(631, 49);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 32;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(612, 26);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 31;
            this.labelSelectDate.Text = "Select Date";
            // 
            // FormViewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 602);
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
            this.Controls.Add(this.dataGridViewViewVisitor);
            this.Name = "FormViewVisitor";
            this.Text = "View Visitor";
            this.Load += new System.EventHandler(this.FormViewVisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewVisitor;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonViewHistory;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.Button buttonExit;
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