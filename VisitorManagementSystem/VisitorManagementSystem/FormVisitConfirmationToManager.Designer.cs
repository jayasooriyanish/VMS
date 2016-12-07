namespace VisitorManagementSystem
{
    partial class FormVisitConfirmationToManager
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInformVisitor = new System.Windows.Forms.Button();
            this.buttonInformBoi = new System.Windows.Forms.Button();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.labelAppointmentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(145, 186);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 42);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(30, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 42);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonInformVisitor
            // 
            this.buttonInformVisitor.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInformVisitor.Location = new System.Drawing.Point(145, 138);
            this.buttonInformVisitor.Name = "buttonInformVisitor";
            this.buttonInformVisitor.Size = new System.Drawing.Size(105, 42);
            this.buttonInformVisitor.TabIndex = 13;
            this.buttonInformVisitor.Text = "Inform Visitor";
            this.buttonInformVisitor.UseVisualStyleBackColor = false;
            // 
            // buttonInformBoi
            // 
            this.buttonInformBoi.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInformBoi.Location = new System.Drawing.Point(30, 138);
            this.buttonInformBoi.Name = "buttonInformBoi";
            this.buttonInformBoi.Size = new System.Drawing.Size(105, 42);
            this.buttonInformBoi.TabIndex = 12;
            this.buttonInformBoi.Text = "Inform BOI";
            this.buttonInformBoi.UseVisualStyleBackColor = false;
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(111, 68);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(139, 20);
            this.textBoxVisitorId.TabIndex = 11;
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.Location = new System.Drawing.Point(111, 33);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.Size = new System.Drawing.Size(139, 20);
            this.textBoxAppointmentId.TabIndex = 10;
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(27, 71);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 9;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // labelAppointmentId
            // 
            this.labelAppointmentId.AutoSize = true;
            this.labelAppointmentId.Location = new System.Drawing.Point(27, 36);
            this.labelAppointmentId.Name = "labelAppointmentId";
            this.labelAppointmentId.Size = new System.Drawing.Size(78, 13);
            this.labelAppointmentId.TabIndex = 8;
            this.labelAppointmentId.Text = "Appointment Id";
            // 
            // FormVisitConfirmationToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInformVisitor);
            this.Controls.Add(this.buttonInformBoi);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.textBoxAppointmentId);
            this.Controls.Add(this.labelVisitorId);
            this.Controls.Add(this.labelAppointmentId);
            this.Name = "FormVisitConfirmationToManager";
            this.Text = "Visit Confirmation";
            this.Load += new System.EventHandler(this.FormVisitConfirmationToManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInformVisitor;
        private System.Windows.Forms.Button buttonInformBoi;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.Label labelAppointmentId;
    }
}