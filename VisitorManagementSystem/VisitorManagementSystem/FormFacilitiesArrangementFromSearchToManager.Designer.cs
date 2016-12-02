namespace VisitorManagementSystem
{
    partial class FormFacilitiesArrangementFromSearchToManager
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
            this.textBoxVisitorId = new System.Windows.Forms.TextBox();
            this.labelVisitorId = new System.Windows.Forms.Label();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.labelAppointmentId = new System.Windows.Forms.Label();
            this.groupBoxAccomodation = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfDays = new System.Windows.Forms.TextBox();
            this.labelNumOfDays = new System.Windows.Forms.Label();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.groupBoxVehicles = new System.Windows.Forms.GroupBox();
            this.comboBoxNumOfVehicles = new System.Windows.Forms.ComboBox();
            this.labelNumOfVehicles = new System.Windows.Forms.Label();
            this.groupBoxAccomodation.SuspendLayout();
            this.groupBoxVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVisitorId
            // 
            this.textBoxVisitorId.Location = new System.Drawing.Point(102, 52);
            this.textBoxVisitorId.Name = "textBoxVisitorId";
            this.textBoxVisitorId.Size = new System.Drawing.Size(142, 20);
            this.textBoxVisitorId.TabIndex = 17;
            // 
            // labelVisitorId
            // 
            this.labelVisitorId.AutoSize = true;
            this.labelVisitorId.Location = new System.Drawing.Point(21, 55);
            this.labelVisitorId.Name = "labelVisitorId";
            this.labelVisitorId.Size = new System.Drawing.Size(47, 13);
            this.labelVisitorId.TabIndex = 16;
            this.labelVisitorId.Text = "Visitor Id";
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.Location = new System.Drawing.Point(102, 15);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.Size = new System.Drawing.Size(142, 20);
            this.textBoxAppointmentId.TabIndex = 15;
            // 
            // labelAppointmentId
            // 
            this.labelAppointmentId.AutoSize = true;
            this.labelAppointmentId.Location = new System.Drawing.Point(21, 18);
            this.labelAppointmentId.Name = "labelAppointmentId";
            this.labelAppointmentId.Size = new System.Drawing.Size(78, 13);
            this.labelAppointmentId.TabIndex = 14;
            this.labelAppointmentId.Text = "Appointment Id";
            // 
            // groupBoxAccomodation
            // 
            this.groupBoxAccomodation.Controls.Add(this.textBoxNumOfDays);
            this.groupBoxAccomodation.Controls.Add(this.labelNumOfDays);
            this.groupBoxAccomodation.Controls.Add(this.comboBoxPlace);
            this.groupBoxAccomodation.Controls.Add(this.labelPlace);
            this.groupBoxAccomodation.Location = new System.Drawing.Point(24, 242);
            this.groupBoxAccomodation.Name = "groupBoxAccomodation";
            this.groupBoxAccomodation.Size = new System.Drawing.Size(317, 100);
            this.groupBoxAccomodation.TabIndex = 13;
            this.groupBoxAccomodation.TabStop = false;
            this.groupBoxAccomodation.Text = "Accomodation";
            // 
            // textBoxNumOfDays
            // 
            this.textBoxNumOfDays.Location = new System.Drawing.Point(90, 48);
            this.textBoxNumOfDays.Name = "textBoxNumOfDays";
            this.textBoxNumOfDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumOfDays.TabIndex = 3;
            // 
            // labelNumOfDays
            // 
            this.labelNumOfDays.AutoSize = true;
            this.labelNumOfDays.Location = new System.Drawing.Point(7, 55);
            this.labelNumOfDays.Name = "labelNumOfDays";
            this.labelNumOfDays.Size = new System.Drawing.Size(70, 13);
            this.labelNumOfDays.TabIndex = 2;
            this.labelNumOfDays.Text = "Num Of Days";
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Items.AddRange(new object[] {
            "Hotel A",
            "Hotel B",
            "Hotel C"});
            this.comboBoxPlace.Location = new System.Drawing.Point(47, 23);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(143, 21);
            this.comboBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 26);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(34, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Place";
            // 
            // groupBoxVehicles
            // 
            this.groupBoxVehicles.Controls.Add(this.comboBoxNumOfVehicles);
            this.groupBoxVehicles.Controls.Add(this.labelNumOfVehicles);
            this.groupBoxVehicles.Location = new System.Drawing.Point(24, 89);
            this.groupBoxVehicles.Name = "groupBoxVehicles";
            this.groupBoxVehicles.Size = new System.Drawing.Size(317, 147);
            this.groupBoxVehicles.TabIndex = 12;
            this.groupBoxVehicles.TabStop = false;
            this.groupBoxVehicles.Text = "Vehicles";
            // 
            // comboBoxNumOfVehicles
            // 
            this.comboBoxNumOfVehicles.FormattingEnabled = true;
            this.comboBoxNumOfVehicles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNumOfVehicles.Location = new System.Drawing.Point(99, 27);
            this.comboBoxNumOfVehicles.Name = "comboBoxNumOfVehicles";
            this.comboBoxNumOfVehicles.Size = new System.Drawing.Size(91, 21);
            this.comboBoxNumOfVehicles.TabIndex = 1;
            // 
            // labelNumOfVehicles
            // 
            this.labelNumOfVehicles.AutoSize = true;
            this.labelNumOfVehicles.Location = new System.Drawing.Point(7, 30);
            this.labelNumOfVehicles.Name = "labelNumOfVehicles";
            this.labelNumOfVehicles.Size = new System.Drawing.Size(86, 13);
            this.labelNumOfVehicles.TabIndex = 0;
            this.labelNumOfVehicles.Text = "Num Of Vehicles";
            // 
            // FormFacilitiesArrangementFromVisitorRegisterToManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 357);
            this.Controls.Add(this.textBoxVisitorId);
            this.Controls.Add(this.labelVisitorId);
            this.Controls.Add(this.textBoxAppointmentId);
            this.Controls.Add(this.labelAppointmentId);
            this.Controls.Add(this.groupBoxAccomodation);
            this.Controls.Add(this.groupBoxVehicles);
            this.Name = "FormFacilitiesArrangementFromVisitorRegisterToManager";
            this.Text = "Facilities Arrangement";
            this.groupBoxAccomodation.ResumeLayout(false);
            this.groupBoxAccomodation.PerformLayout();
            this.groupBoxVehicles.ResumeLayout(false);
            this.groupBoxVehicles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVisitorId;
        private System.Windows.Forms.Label labelVisitorId;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.Label labelAppointmentId;
        private System.Windows.Forms.GroupBox groupBoxAccomodation;
        private System.Windows.Forms.TextBox textBoxNumOfDays;
        private System.Windows.Forms.Label labelNumOfDays;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.GroupBox groupBoxVehicles;
        private System.Windows.Forms.ComboBox comboBoxNumOfVehicles;
        private System.Windows.Forms.Label labelNumOfVehicles;
    }
}