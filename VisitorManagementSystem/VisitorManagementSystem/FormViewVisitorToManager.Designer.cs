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
            this.dataGridViewViewVisitorToManager = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelClickToSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitorToManager)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(599, 512);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 32);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonMoreDetails.Location = new System.Drawing.Point(100, 512);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(108, 32);
            this.buttonMoreDetails.TabIndex = 19;
            this.buttonMoreDetails.Text = "More Details";
            this.buttonMoreDetails.UseVisualStyleBackColor = false;
            this.buttonMoreDetails.Click += new System.EventHandler(this.buttonMoreDetails_Click);
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonViewHistory.Location = new System.Drawing.Point(261, 512);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(108, 32);
            this.buttonViewHistory.TabIndex = 18;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = false;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddAppointment.Location = new System.Drawing.Point(424, 512);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(108, 32);
            this.buttonAddAppointment.TabIndex = 17;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = false;
            // 
            // dataGridViewViewVisitorToManager
            // 
            this.dataGridViewViewVisitorToManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisitorToManager.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewViewVisitorToManager.Name = "dataGridViewViewVisitorToManager";
            this.dataGridViewViewVisitorToManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewViewVisitorToManager.Size = new System.Drawing.Size(753, 417);
            this.dataGridViewViewVisitorToManager.TabIndex = 14;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(720, 54);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 30;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(536, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(178, 20);
            this.textBoxSearch.TabIndex = 29;
            // 
            // labelClickToSelect
            // 
            this.labelClickToSelect.AutoSize = true;
            this.labelClickToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickToSelect.Location = new System.Drawing.Point(9, 46);
            this.labelClickToSelect.Name = "labelClickToSelect";
            this.labelClickToSelect.Size = new System.Drawing.Size(214, 18);
            this.labelClickToSelect.TabIndex = 26;
            this.labelClickToSelect.Text = "Click On The Record To Select";
            // 
            // FormViewVisitorToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(777, 558);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelClickToSelect);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMoreDetails);
            this.Controls.Add(this.buttonViewHistory);
            this.Controls.Add(this.buttonAddAppointment);
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
        private System.Windows.Forms.DataGridView dataGridViewViewVisitorToManager;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelClickToSelect;
    }
}