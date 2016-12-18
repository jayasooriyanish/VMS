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
            this.dataGridViewVisitList = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisitList
            // 
            this.dataGridViewVisitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitList.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewVisitList.Name = "dataGridViewVisitList";
            this.dataGridViewVisitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVisitList.Size = new System.Drawing.Size(744, 407);
            this.dataGridViewVisitList.TabIndex = 0;
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
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(666, 511);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(93, 32);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.Enabled = false;
            this.buttonMoreDetails.Location = new System.Drawing.Point(551, 511);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(93, 32);
            this.buttonMoreDetails.TabIndex = 20;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = true;
            this.buttonMoreDetails.Click += new System.EventHandler(this.buttonMoreDetails_Click);
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
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(15, 511);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(93, 32);
            this.buttonPrint.TabIndex = 28;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // FormVisitListToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 553);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.buttonMoreDetails);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.dataGridViewVisitList);
            this.Name = "FormVisitListToManager";
            this.Text = "Visit List";
            this.Load += new System.EventHandler(this.FormVisitListToManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisitList;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelClickToSelect;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.Button buttonPrint;
    }
}