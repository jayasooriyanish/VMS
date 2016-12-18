namespace VisitorManagementSystem
{
    partial class FormViewHistoryFromRegisterToManager
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
            this.dataGridViewViewHistory = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.labelVisitorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewHistory
            // 
            this.dataGridViewViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewHistory.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewViewHistory.Name = "dataGridViewViewHistory";
            this.dataGridViewViewHistory.Size = new System.Drawing.Size(763, 357);
            this.dataGridViewViewHistory.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(667, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 32);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(80, 22);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(183, 20);
            this.textBoxVisitorId.TabIndex = 23;
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(15, 25);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 22;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // FormViewHistoryFromRegisterToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 471);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.labelVisitorId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewViewHistory);
            this.Name = "FormViewHistoryFromRegisterToManager";
            this.Text = "Visitor History";
            this.Load += new System.EventHandler(this.FormViewHistoryToManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.Label labelVisitorId;
    }
}