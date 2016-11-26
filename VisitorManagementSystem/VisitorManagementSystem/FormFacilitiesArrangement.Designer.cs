namespace VisitorManagementSystem
{
    partial class FormFacilitiesArrangement
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
            this.groupBoxVehicles = new System.Windows.Forms.GroupBox();
            this.labelNumOfVehicles = new System.Windows.Forms.Label();
            this.comboBoxNumOfVehicles = new System.Windows.Forms.ComboBox();
            this.groupBoxAccomodation = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.labelNumOfDays = new System.Windows.Forms.Label();
            this.textBoxNumOfDays = new System.Windows.Forms.TextBox();
            this.groupBoxVehicles.SuspendLayout();
            this.groupBoxAccomodation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVehicles
            // 
            this.groupBoxVehicles.Controls.Add(this.comboBoxNumOfVehicles);
            this.groupBoxVehicles.Controls.Add(this.labelNumOfVehicles);
            this.groupBoxVehicles.Location = new System.Drawing.Point(12, 25);
            this.groupBoxVehicles.Name = "groupBoxVehicles";
            this.groupBoxVehicles.Size = new System.Drawing.Size(317, 182);
            this.groupBoxVehicles.TabIndex = 0;
            this.groupBoxVehicles.TabStop = false;
            this.groupBoxVehicles.Text = "Vehicles";
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
            // groupBoxAccomodation
            // 
            this.groupBoxAccomodation.Controls.Add(this.textBoxNumOfDays);
            this.groupBoxAccomodation.Controls.Add(this.labelNumOfDays);
            this.groupBoxAccomodation.Controls.Add(this.comboBoxPlace);
            this.groupBoxAccomodation.Controls.Add(this.labelPlace);
            this.groupBoxAccomodation.Location = new System.Drawing.Point(12, 213);
            this.groupBoxAccomodation.Name = "groupBoxAccomodation";
            this.groupBoxAccomodation.Size = new System.Drawing.Size(317, 100);
            this.groupBoxAccomodation.TabIndex = 1;
            this.groupBoxAccomodation.TabStop = false;
            this.groupBoxAccomodation.Text = "Accomodation";
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
            // labelNumOfDays
            // 
            this.labelNumOfDays.AutoSize = true;
            this.labelNumOfDays.Location = new System.Drawing.Point(7, 55);
            this.labelNumOfDays.Name = "labelNumOfDays";
            this.labelNumOfDays.Size = new System.Drawing.Size(70, 13);
            this.labelNumOfDays.TabIndex = 2;
            this.labelNumOfDays.Text = "Num Of Days";
            // 
            // textBoxNumOfDays
            // 
            this.textBoxNumOfDays.Location = new System.Drawing.Point(90, 48);
            this.textBoxNumOfDays.Name = "textBoxNumOfDays";
            this.textBoxNumOfDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumOfDays.TabIndex = 3;
            // 
            // FormFacilitiesArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(341, 322);
            this.Controls.Add(this.groupBoxAccomodation);
            this.Controls.Add(this.groupBoxVehicles);
            this.Name = "FormFacilitiesArrangement";
            this.Text = "Facilities Arrangement";
            this.groupBoxVehicles.ResumeLayout(false);
            this.groupBoxVehicles.PerformLayout();
            this.groupBoxAccomodation.ResumeLayout(false);
            this.groupBoxAccomodation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicles;
        private System.Windows.Forms.ComboBox comboBoxNumOfVehicles;
        private System.Windows.Forms.Label labelNumOfVehicles;
        private System.Windows.Forms.GroupBox groupBoxAccomodation;
        private System.Windows.Forms.TextBox textBoxNumOfDays;
        private System.Windows.Forms.Label labelNumOfDays;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.Label labelPlace;
    }
}