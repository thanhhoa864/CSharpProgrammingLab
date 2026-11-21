namespace Bai01_BTVN_SQL
{
    partial class Form1
    {
        private MenuStrip menu;
        private ToolStripMenuItem ton, sp, ban;
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            ton = new ToolStripMenuItem();
            sp = new ToolStripMenuItem();
            ban = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { ton, sp, ban });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(600, 24);
            menu.TabIndex = 0;
            // 
            // ton
            // 
            ton.Name = "ton";
            ton.Size = new Size(82, 20);
            ton.Text = "Tạo tồn kho";
            ton.Click += TonKho_Click;
            // 
            // sp
            // 
            sp.Name = "sp";
            sp.Size = new Size(128, 20);
            sp.Text = "Thêm sản phẩm mới";
            sp.Click += SanPham_Click;
            // 
            // ban
            // 
            ban.Name = "ban";
            ban.Size = new Size(69, 20);
            ban.Text = "Bán hàng";
            ban.Click += BanHang_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 220);
            Controls.Add(menu);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
