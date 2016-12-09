namespace VisitorManagementSystem
{
    partial class PendingRequestsForm
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
            this.dataGridViewPendingRequests = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSelectRequest = new System.Windows.Forms.ComboBox();
            this.labelSelectRequests = new System.Windows.Forms.Label();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPendingRequests
            // 
            this.dataGridViewPendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingRequests.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewPendingRequests.Name = "dataGridViewPendingRequests";
            this.dataGridViewPendingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPendingRequests.Size = new System.Drawing.Size(864, 367);
            this.dataGridViewPendingRequests.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(217, 52);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 24;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(19, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 20);
            this.textBoxSearch.TabIndex = 23;
            // 
            // comboBoxSelectRequest
            // 
            this.comboBoxSelectRequest.FormattingEnabled = true;
            this.comboBoxSelectRequest.Items.AddRange(new object[] {
            "All",
            "Approved",
            "Pending Requests",
            "Checked In",
            "Checked Out"});
            this.comboBoxSelectRequest.Location = new System.Drawing.Point(474, 49);
            this.comboBoxSelectRequest.Name = "comboBoxSelectRequest";
            this.comboBoxSelectRequest.Size = new System.Drawing.Size(143, 21);
            this.comboBoxSelectRequest.TabIndex = 22;
            // 
            // labelSelectRequests
            // 
            this.labelSelectRequests.AutoSize = true;
            this.labelSelectRequests.Location = new System.Drawing.Point(388, 54);
            this.labelSelectRequests.Name = "labelSelectRequests";
            this.labelSelectRequests.Size = new System.Drawing.Size(80, 13);
            this.labelSelectRequests.TabIndex = 21;
            this.labelSelectRequests.Text = "Select Request";
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(16, 86);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 20;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(705, 64);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerToDate.TabIndex = 19;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(705, 42);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFromDate.TabIndex = 18;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(679, 70);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 17;
            this.labelToDate.Text = "To";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(669, 48);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 16;
            this.labelFromDate.Text = "From";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(650, 25);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(63, 13);
            this.labelSelectDate.TabIndex = 15;
            this.labelSelectDate.Text = "Select Date";
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.Location = new System.Drawing.Point(432, 494);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonMoreDetails.TabIndex = 25;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = true;
            this.buttonMoreDetails.Click += new System.EventHandler(this.buttonMoreDetails_Click);
            // 
            // PendingRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.buttonMoreDetails);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSelectRequest);
            this.Controls.Add(this.labelSelectRequests);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.dataGridViewPendingRequests);
            this.Name = "PendingRequestsForm";
            this.Text = "Pending Requests";
            this.Load += new System.EventHandler(this.PendingRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPendingRequests;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSelectRequest;
        private System.Windows.Forms.Label labelSelectRequests;
        private System.Windows.Forms.Label labelClickToSelect;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.Button buttonMoreDetails;
    }
}