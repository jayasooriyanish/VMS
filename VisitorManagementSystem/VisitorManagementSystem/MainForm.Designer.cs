namespace VisitorManagementSystem
{
    partial class MainForm
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
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVisitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonVisits = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(411, 66);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(132, 52);
            this.buttonReports.TabIndex = 20;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(351, 322);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 41);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.Location = new System.Drawing.Point(273, 64);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(132, 52);
            this.buttonEmployee.TabIndex = 18;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisitor.Location = new System.Drawing.Point(12, 64);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(132, 52);
            this.buttonVisitor.TabIndex = 16;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = false;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonSearchVisitor_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 25);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(552, 24);
            this.MainMenuStrip.TabIndex = 21;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchVisitorToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // searchVisitorToolStripMenuItem
            // 
            this.searchVisitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchVisitorToolStripMenuItem1,
            this.registerVisitorToolStripMenuItem,
            this.viewVisitorToolStripMenuItem});
            this.searchVisitorToolStripMenuItem.Name = "searchVisitorToolStripMenuItem";
            this.searchVisitorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.searchVisitorToolStripMenuItem.Text = "Visitor";
            this.searchVisitorToolStripMenuItem.Click += new System.EventHandler(this.searchVisitorToolStripMenuItem_Click);
            // 
            // searchVisitorToolStripMenuItem1
            // 
            this.searchVisitorToolStripMenuItem1.Name = "searchVisitorToolStripMenuItem1";
            this.searchVisitorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.searchVisitorToolStripMenuItem1.Text = "Search Visitor";
            // 
            // registerVisitorToolStripMenuItem
            // 
            this.registerVisitorToolStripMenuItem.Name = "registerVisitorToolStripMenuItem";
            this.registerVisitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerVisitorToolStripMenuItem.Text = "Register Visitor";
            // 
            // viewVisitorToolStripMenuItem
            // 
            this.viewVisitorToolStripMenuItem.Name = "viewVisitorToolStripMenuItem";
            this.viewVisitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewVisitorToolStripMenuItem.Text = "View Visitor";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.visitsToolStripMenuItem,
            this.visitListToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.registerToolStripMenuItem.Text = "Visit";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // visitsToolStripMenuItem
            // 
            this.visitsToolStripMenuItem.Name = "visitsToolStripMenuItem";
            this.visitsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.visitsToolStripMenuItem.Text = "Visits";
            // 
            // visitListToolStripMenuItem
            // 
            this.visitListToolStripMenuItem.Name = "visitListToolStripMenuItem";
            this.visitListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.visitListToolStripMenuItem.Text = "Visit List";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerEmployeeToolStripMenuItem,
            this.registerEmployeeToolStripMenuItem1,
            this.viewEmployeeToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Employee";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // registerEmployeeToolStripMenuItem
            // 
            this.registerEmployeeToolStripMenuItem.Name = "registerEmployeeToolStripMenuItem";
            this.registerEmployeeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registerEmployeeToolStripMenuItem.Text = "Search Visitor";
            this.registerEmployeeToolStripMenuItem.Click += new System.EventHandler(this.registerEmployeeToolStripMenuItem_Click);
            // 
            // registerEmployeeToolStripMenuItem1
            // 
            this.registerEmployeeToolStripMenuItem1.Name = "registerEmployeeToolStripMenuItem1";
            this.registerEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.registerEmployeeToolStripMenuItem1.Text = "Register Employee";
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewEmployeeToolStripMenuItem.Text = "View Employee";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonVisits
            // 
            this.buttonVisits.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisits.Location = new System.Drawing.Point(150, 63);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(117, 55);
            this.buttonVisits.TabIndex = 24;
            this.buttonVisits.Text = "Visits";
            this.buttonVisits.UseVisualStyleBackColor = false;
            this.buttonVisits.Click += new System.EventHandler(this.buttonRegisterVisitor_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(113, 183);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 23);
            this.buttonS.TabIndex = 25;
            this.buttonS.Text = "button1";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonVisits);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonVisitor);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Visitor Management System - Silueta Pvt. Ltd.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem searchVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button buttonVisits;
        private System.Windows.Forms.ToolStripMenuItem searchVisitorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button button1;
    }
}

