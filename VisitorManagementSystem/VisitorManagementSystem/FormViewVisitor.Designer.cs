namespace VisitorManagementSystem
{
    partial class FormViewVisitor
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
            this.dataGridViewViewVisitor = new System.Windows.Forms.DataGridView();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewVisitor
            // 
            this.dataGridViewViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisitor.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewViewVisitor.Name = "dataGridViewViewVisitor";
            this.dataGridViewViewVisitor.Size = new System.Drawing.Size(811, 451);
            this.dataGridViewViewVisitor.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonHome.Location = new System.Drawing.Point(688, 22);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(135, 36);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Location = new System.Drawing.Point(715, 521);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 32);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // FormViewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 565);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.dataGridViewViewVisitor);
            this.Name = "FormViewVisitor";
            this.Text = "View Visitor";
            this.Load += new System.EventHandler(this.FormViewVisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewVisitor;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
    }
}