namespace Project_test_2
{
    partial class frmhomepage
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
            this.mnHomepage = new System.Windows.Forms.MenuStrip();
            this.cUSTOMBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHomepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnHomepage
            // 
            this.mnHomepage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUSTOMBOOKToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnHomepage.Location = new System.Drawing.Point(0, 0);
            this.mnHomepage.Name = "mnHomepage";
            this.mnHomepage.Size = new System.Drawing.Size(644, 26);
            this.mnHomepage.TabIndex = 0;
            this.mnHomepage.Text = "menuStrip1";
            // 
            // cUSTOMBOOKToolStripMenuItem
            // 
            this.cUSTOMBOOKToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUSTOMBOOKToolStripMenuItem.Name = "cUSTOMBOOKToolStripMenuItem";
            this.cUSTOMBOOKToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.cUSTOMBOOKToolStripMenuItem.Text = "Custom book";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // frmhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 316);
            this.Controls.Add(this.mnHomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnHomepage;
            this.Name = "frmhomepage";
            this.Text = "frmhomepage";
            this.mnHomepage.ResumeLayout(false);
            this.mnHomepage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnHomepage;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}