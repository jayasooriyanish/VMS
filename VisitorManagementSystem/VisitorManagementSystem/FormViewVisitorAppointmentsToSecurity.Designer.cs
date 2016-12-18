namespace VisitorManagementSystem
{
    partial class FormViewVisitorAppointmentsToSecurity
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
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.dataGridViewViewAppointments = new System.Windows.Forms.DataGridView();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonProceedToCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckAuthorization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorId.Location = new System.Drawing.Point(18, 38);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(59, 16);
            this.labelVisitorId.TabIndex = 0;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(83, 37);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(184, 20);
            this.textBoxVisitorId.TabIndex = 1;
            // 
            // dataGridViewViewAppointments
            // 
            this.dataGridViewViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewAppointments.Location = new System.Drawing.Point(15, 86);
            this.dataGridViewViewAppointments.Name = "dataGridViewViewAppointments";
            this.dataGridViewViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewAppointments.Size = new System.Drawing.Size(831, 346);
            this.dataGridViewViewAppointments.TabIndex = 2;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(687, 60);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 25;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(687, 38);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 24;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(661, 66);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 23;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(651, 44);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 22;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(632, 21);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 21;
            this.labelSelectDate.Text = "Select Date";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(740, 449);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 37);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonProceedToCheckIn
            // 
            this.buttonProceedToCheckIn.Location = new System.Drawing.Point(572, 449);
            this.buttonProceedToCheckIn.Name = "buttonProceedToCheckIn";
            this.buttonProceedToCheckIn.Size = new System.Drawing.Size(144, 37);
            this.buttonProceedToCheckIn.TabIndex = 27;
            this.buttonProceedToCheckIn.Text = "Proceed To Check in";
            this.buttonProceedToCheckIn.UseVisualStyleBackColor = true;
            this.buttonProceedToCheckIn.Click += new System.EventHandler(this.buttonProceedToCheckIn_Click);
            // 
            // buttonCheckAuthorization
            // 
            this.buttonCheckAuthorization.Location = new System.Drawing.Point(408, 449);
            this.buttonCheckAuthorization.Name = "buttonCheckAuthorization";
            this.buttonCheckAuthorization.Size = new System.Drawing.Size(144, 37);
            this.buttonCheckAuthorization.TabIndex = 28;
            this.buttonCheckAuthorization.Text = "Check Authorization";
            this.buttonCheckAuthorization.UseVisualStyleBackColor = true;
            // 
            // FormViewVisitorAppointmentsToSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.buttonCheckAuthorization);
            this.Controls.Add(this.buttonProceedToCheckIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.dataGridViewViewAppointments);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.labelVisitorId);
            this.Name = "FormViewVisitorAppointmentsToSecurity";
            this.Text = "View Visitor Appointments";
            this.Load += new System.EventHandler(this.FormViewVisitorAppointmentsToSecurity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.DataGridView dataGridViewViewAppointments;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonProceedToCheckIn;
        private System.Windows.Forms.Button buttonCheckAuthorization;
    }
}