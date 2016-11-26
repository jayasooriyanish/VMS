namespace VisitorManagementSystem
{
    partial class FormSearchVisitor
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRegisterNewVisitor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.maskedTextBoxNIC = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelEnterVisitorInformation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonCancel.Location = new System.Drawing.Point(16, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHome.Location = new System.Drawing.Point(16, 176);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(85, 23);
            this.buttonHome.TabIndex = 23;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonBack.Location = new System.Drawing.Point(16, 147);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRegisterNewVisitor
            // 
            this.buttonRegisterNewVisitor.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRegisterNewVisitor.Location = new System.Drawing.Point(6, 19);
            this.buttonRegisterNewVisitor.Name = "buttonRegisterNewVisitor";
            this.buttonRegisterNewVisitor.Size = new System.Drawing.Size(108, 40);
            this.buttonRegisterNewVisitor.TabIndex = 24;
            this.buttonRegisterNewVisitor.Text = "Register New Visitor";
            this.buttonRegisterNewVisitor.UseVisualStyleBackColor = false;
            this.buttonRegisterNewVisitor.Click += new System.EventHandler(this.buttonRegisterNewVisitor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClearFields);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.maskedTextBoxNIC);
            this.groupBox2.Controls.Add(this.textBoxLastName);
            this.groupBox2.Controls.Add(this.textBoxFirstName);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.labelFirstName);
            this.groupBox2.Controls.Add(this.labelNIC);
            this.groupBox2.Controls.Add(this.labelEnterVisitorInformation);
            this.groupBox2.Location = new System.Drawing.Point(9, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 237);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonClearFields.Location = new System.Drawing.Point(199, 70);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(81, 29);
            this.buttonClearFields.TabIndex = 34;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSearch.Location = new System.Drawing.Point(93, 164);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 29);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // maskedTextBoxNIC
            // 
            this.maskedTextBoxNIC.Location = new System.Drawing.Point(93, 75);
            this.maskedTextBoxNIC.Mask = "000000000<L";
            this.maskedTextBoxNIC.Name = "maskedTextBoxNIC";
            this.maskedTextBoxNIC.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNIC.TabIndex = 32;
            this.maskedTextBoxNIC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNIC_MaskInputRejected);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(93, 135);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 31;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(93, 105);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 30;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(14, 138);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 29;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 108);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 28;
            this.labelFirstName.Text = "First Name";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(13, 78);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(65, 13);
            this.labelNIC.TabIndex = 27;
            this.labelNIC.Text = "NIC Number";
            // 
            // labelEnterVisitorInformation
            // 
            this.labelEnterVisitorInformation.AutoSize = true;
            this.labelEnterVisitorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterVisitorInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEnterVisitorInformation.Location = new System.Drawing.Point(16, 42);
            this.labelEnterVisitorInformation.Name = "labelEnterVisitorInformation";
            this.labelEnterVisitorInformation.Size = new System.Drawing.Size(207, 16);
            this.labelEnterVisitorInformation.TabIndex = 26;
            this.labelEnterVisitorInformation.Text = "Enter Visitor Information here";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonHome);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.buttonRegisterNewVisitor);
            this.groupBox1.Location = new System.Drawing.Point(311, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 237);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // FormSearchVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(441, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearchVisitor";
            this.Text = "Search Visitor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRegisterNewVisitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNIC;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelEnterVisitorInformation;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}