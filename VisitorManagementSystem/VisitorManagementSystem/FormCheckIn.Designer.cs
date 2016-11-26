namespace VisitorManagementSystem
{
    partial class FormCheckIn
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
            this.buttonCheckAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckAuthorization
            // 
            this.buttonCheckAuthorization.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCheckAuthorization.Location = new System.Drawing.Point(185, 34);
            this.buttonCheckAuthorization.Name = "buttonCheckAuthorization";
            this.buttonCheckAuthorization.Size = new System.Drawing.Size(87, 58);
            this.buttonCheckAuthorization.TabIndex = 0;
            this.buttonCheckAuthorization.Text = "Check Authorization";
            this.buttonCheckAuthorization.UseVisualStyleBackColor = false;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCheckAuthorization);
            this.Name = "FormCheckIn";
            this.Text = "Visitor Checkin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckAuthorization;
    }
}