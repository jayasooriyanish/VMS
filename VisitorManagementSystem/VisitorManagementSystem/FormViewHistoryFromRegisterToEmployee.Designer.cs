namespace VisitorManagementSystem
{
    partial class FormViewHistoryFromRegisterToEmployee
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
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.labelVisitorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.Size = new System.Drawing.Size(697, 406);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(634, 477);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 38);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(82, 30);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(183, 20);
            this.textBoxVisitorId.TabIndex = 25;
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(17, 33);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 24;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // FormViewHistoryFromRegisterToEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(721, 527);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.labelVisitorId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewHistory);
            this.Name = "FormViewHistoryFromRegisterToEmployee";
            this.Text = "Visitor History";
            this.Load += new System.EventHandler(this.FormVisitorHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.Label labelVisitorId;
    }
}