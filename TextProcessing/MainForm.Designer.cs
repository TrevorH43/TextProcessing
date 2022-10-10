namespace TextProcessing
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOption1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption1ToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.menuOption2ToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.cSVDisplayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOption1ToolStripMenuItem
            // 
            this.menuOption1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuOption1ToolStripMenuItem.Image")));
            this.menuOption1ToolStripMenuItem.Name = "menuOption1ToolStripMenuItem";
            this.menuOption1ToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.menuOption1ToolStripMenuItem.Text = "Menu Option 1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // menuOption2ToolStripMenuItem
            // 
            this.menuOption2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuOption2ToolStripMenuItem.Image")));
            this.menuOption2ToolStripMenuItem.Name = "menuOption2ToolStripMenuItem";
            this.menuOption2ToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.menuOption2ToolStripMenuItem.Text = "Menu Option 2";
            this.menuOption2ToolStripMenuItem.Click += new System.EventHandler(this.menuOption2ToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // cSVDisplayToolStripMenuItem
            // 
            this.cSVDisplayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cSVDisplayToolStripMenuItem.Image")));
            this.cSVDisplayToolStripMenuItem.Name = "cSVDisplayToolStripMenuItem";
            this.cSVDisplayToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.cSVDisplayToolStripMenuItem.Text = "CSV Display";
            this.cSVDisplayToolStripMenuItem.Click += new System.EventHandler(this.cSVDisplayToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuOption1ToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem menuOption2ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cSVDisplayToolStripMenuItem;
    }
}