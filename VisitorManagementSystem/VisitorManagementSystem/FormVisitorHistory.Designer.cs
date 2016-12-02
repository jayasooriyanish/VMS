namespace VisitorManagementSystem
{
    partial class FormVisitorHistory
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
            this.dataGridViewVisitorHistory = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddNewAppointment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitorHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisitorHistory
            // 
            this.dataGridViewVisitorHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitorHistory.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewVisitorHistory.Name = "dataGridViewVisitorHistory";
            this.dataGridViewVisitorHistory.Size = new System.Drawing.Size(697, 423);
            this.dataGridViewVisitorHistory.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(414, 462);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 38);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddNewAppointment
            // 
            this.buttonAddNewAppointment.Location = new System.Drawing.Point(526, 462);
            this.buttonAddNewAppointment.Name = "buttonAddNewAppointment";
            this.buttonAddNewAppointment.Size = new System.Drawing.Size(75, 38);
            this.buttonAddNewAppointment.TabIndex = 2;
            this.buttonAddNewAppointment.Text = "Add New Appointment";
            this.buttonAddNewAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(634, 462);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 38);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormVisitorHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(721, 527);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddNewAppointment);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewVisitorHistory);
            this.Name = "FormVisitorHistory";
            this.Text = "Visitor History";
            this.Load += new System.EventHandler(this.FormVisitorHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitorHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisitorHistory;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddNewAppointment;
        private System.Windows.Forms.Button buttonCancel;
    }
}