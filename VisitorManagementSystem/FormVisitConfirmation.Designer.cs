namespace VisitorManagementSystem
{
    partial class FormVisitConfirmation
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
            this.labelAppointmentId = new System.Windows.Forms.Label();
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.buttonInformBoi = new System.Windows.Forms.Button();
            this.buttonInformVisitor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAppointmentId
            // 
            this.labelAppointmentId.AutoSize = true;
            this.labelAppointmentId.Location = new System.Drawing.Point(22, 31);
            this.labelAppointmentId.Name = "labelAppointmentId";
            this.labelAppointmentId.Size = new System.Drawing.Size(78, 13);
            this.labelAppointmentId.TabIndex = 0;
            this.labelAppointmentId.Text = "Appointment Id";
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(22, 66);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 1;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.Location = new System.Drawing.Point(106, 28);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.Size = new System.Drawing.Size(139, 20);
            this.textBoxAppointmentId.TabIndex = 2;
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(106, 63);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(139, 20);
            this.textBoxVisitorId.TabIndex = 3;
            // 
            // buttonInformBoi
            // 
            this.buttonInformBoi.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInformBoi.Location = new System.Drawing.Point(25, 133);
            this.buttonInformBoi.Name = "buttonInformBoi";
            this.buttonInformBoi.Size = new System.Drawing.Size(105, 42);
            this.buttonInformBoi.TabIndex = 4;
            this.buttonInformBoi.Text = "Inform BOI";
            this.buttonInformBoi.UseVisualStyleBackColor = false;
            // 
            // buttonInformVisitor
            // 
            this.buttonInformVisitor.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInformVisitor.Location = new System.Drawing.Point(140, 133);
            this.buttonInformVisitor.Name = "buttonInformVisitor";
            this.buttonInformVisitor.Size = new System.Drawing.Size(105, 42);
            this.buttonInformVisitor.TabIndex = 5;
            this.buttonInformVisitor.Text = "Inform Visitor";
            this.buttonInformVisitor.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(25, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 42);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(140, 181);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 42);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // FormVisitConfirmation
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
            this.Name = "FormVisitConfirmation";
            this.Text = "Visit Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentId;
        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.Button buttonInformBoi;
        private System.Windows.Forms.Button buttonInformVisitor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}