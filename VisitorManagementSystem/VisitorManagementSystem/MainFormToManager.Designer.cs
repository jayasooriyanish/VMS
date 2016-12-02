namespace VisitorManagementSystem
{
    partial class MainFormToManager
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
            this.buttonVisits = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVisits
            // 
            this.buttonVisits.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisits.Location = new System.Drawing.Point(181, 46);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(117, 55);
            this.buttonVisits.TabIndex = 29;
            this.buttonVisits.Text = "Visits";
            this.buttonVisits.UseVisualStyleBackColor = false;
            this.buttonVisits.Click += new System.EventHandler(this.buttonVisits_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(442, 48);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(132, 52);
            this.buttonReports.TabIndex = 28;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(382, 304);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 41);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.Location = new System.Drawing.Point(304, 46);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(132, 52);
            this.buttonEmployee.TabIndex = 26;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisitor.Location = new System.Drawing.Point(43, 46);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(132, 52);
            this.buttonVisitor.TabIndex = 25;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = false;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // MainFormToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 403);
            this.Controls.Add(this.buttonVisits);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonVisitor);
            this.Name = "MainFormToManager";
            this.Text = "Visitor Management System - MAS Silueta Pvt.Ltd.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisits;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonVisitor;

    }
}