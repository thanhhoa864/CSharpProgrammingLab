namespace bai02_BTVN
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuBai01_BTTL = new ToolStripMenuItem();
            mnuBai02_BTTL = new ToolStripMenuItem();
            mnuBai01_BTNC = new ToolStripMenuItem();
            mnuBai01_BTVN = new ToolStripMenuItem();
            mnuBai02_BTVN = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuBai01_BTTL, mnuBai02_BTTL, mnuBai01_BTNC, mnuBai01_BTVN, mnuBai02_BTVN });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(744, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBai01_BTTL
            // 
            mnuBai01_BTTL.Name = "mnuBai01_BTTL";
            mnuBai01_BTTL.Size = new Size(76, 20);
            mnuBai01_BTTL.Text = "bai01_BTTL";
            mnuBai01_BTTL.Click += mnuBai01_BTTL_Click;
            // 
            // mnuBai02_BTTL
            // 
            mnuBai02_BTTL.Name = "mnuBai02_BTTL";
            mnuBai02_BTTL.Size = new Size(76, 20);
            mnuBai02_BTTL.Text = "bai02_BTTL";
            mnuBai02_BTTL.Click += mnuBai02_BTTL_Click;
            // 
            // mnuBai01_BTNC
            // 
            mnuBai01_BTNC.Name = "mnuBai01_BTNC";
            mnuBai01_BTNC.Size = new Size(81, 20);
            mnuBai01_BTNC.Text = "bai01_BTNC";
            mnuBai01_BTNC.Click += mnuBai01_BTNC_Click;
            // 
            // mnuBai01_BTVN
            // 
            mnuBai01_BTVN.Name = "mnuBai01_BTVN";
            mnuBai01_BTVN.Size = new Size(80, 20);
            mnuBai01_BTVN.Text = "bai01_BTVN";
            mnuBai01_BTVN.Click += mnuBai01_BTVN_Click;
            // 
            // mnuBai02_BTVN
            // 
            mnuBai02_BTVN.Name = "mnuBai02_BTVN";
            mnuBai02_BTVN.Size = new Size(12, 20);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 581);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BTVN_Tuan6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBai01_BTTL;
        private System.Windows.Forms.ToolStripMenuItem mnuBai02_BTTL;
        private System.Windows.Forms.ToolStripMenuItem mnuBai01_BTNC;
        private System.Windows.Forms.ToolStripMenuItem mnuBai01_BTVN;
        private System.Windows.Forms.ToolStripMenuItem mnuBai02_BTVN;
    }
}