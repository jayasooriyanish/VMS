namespace VisitorManagementSystem
{
    partial class MainFormToSecurityAdmin
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
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.buttonVisits = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.Location = new System.Drawing.Point(178, 48);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(90, 57);
            this.buttonVisitor.TabIndex = 0;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = true;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // buttonVisits
            // 
            this.buttonVisits.Location = new System.Drawing.Point(178, 127);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(90, 57);
            this.buttonVisits.TabIndex = 1;
            this.buttonVisits.Text = "Visits";
            this.buttonVisits.UseVisualStyleBackColor = true;
            this.buttonVisits.Click += new System.EventHandler(this.buttonVisits_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Location = new System.Drawing.Point(178, 205);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(90, 57);
            this.buttonReports.TabIndex = 2;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(346, 270);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // MainFormToSecurityAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(449, 323);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonVisits);
            this.Controls.Add(this.buttonVisitor);
            this.Name = "MainFormToSecurityAdmin";
            this.Text = "Visitor Management System - Silueta Pvt.Ltd.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.Button buttonVisits;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonExit;
    }
}