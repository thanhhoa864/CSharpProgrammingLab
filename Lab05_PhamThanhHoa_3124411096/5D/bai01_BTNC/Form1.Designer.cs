namespace bai01_BTNC
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHocVienMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangLopA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLopA = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.grpLopB = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpLopA.SuspendLayout();
            this.grpLopB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhat,
            this.mnuKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapHocVienMoi,
            this.mnuChuyenSangLopB,
            this.mnuChuyenSangLopA,
            this.mnuXoaHocVien});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(96, 27);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuNhapHocVienMoi
            // 
            this.mnuNhapHocVienMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.mnuNhapHocVienMoi.Name = "mnuNhapHocVienMoi";
            this.mnuNhapHocVienMoi.Size = new System.Drawing.Size(226, 26);
            this.mnuNhapHocVienMoi.Text = "Nhập học viên mới";
            this.mnuNhapHocVienMoi.Click += new System.EventHandler(this.mnuNhapHocVienMoi_Click);
            // 
            // mnuChuyenSangLopB
            // 
            this.mnuChuyenSangLopB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
            this.mnuChuyenSangLopB.Size = new System.Drawing.Size(226, 26);
            this.mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
            this.mnuChuyenSangLopB.Click += new System.EventHandler(this.mnuChuyenSangLopB_Click);
            // 
            // mnuChuyenSangLopA
            // 
            this.mnuChuyenSangLopA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
            this.mnuChuyenSangLopA.Size = new System.Drawing.Size(226, 26);
            this.mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
            this.mnuChuyenSangLopA.Click += new System.EventHandler(this.mnuChuyenSangLopA_Click);
            // 
            // mnuXoaHocVien
            // 
            this.mnuXoaHocVien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Size = new System.Drawing.Size(226, 26);
            this.mnuXoaHocVien.Text = "Xóa học viên";
            this.mnuXoaHocVien.Click += new System.EventHandler(this.mnuXoaHocVien_Click);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(91, 27);
            this.mnuKetThuc.Text = "Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // grpLopA
            // 
            this.grpLopA.Controls.Add(this.lstLopA);
            this.grpLopA.Location = new System.Drawing.Point(30, 50);
            this.grpLopA.Name = "grpLopA";
            this.grpLopA.Size = new System.Drawing.Size(235, 260);
            this.grpLopA.TabIndex = 1;
            this.grpLopA.TabStop = false;
            this.grpLopA.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLopA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 20;
            this.lstLopA.Location = new System.Drawing.Point(3, 18);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(229, 239);
            this.lstLopA.TabIndex = 0;
            // 
            // grpLopB
            // 
            this.grpLopB.Controls.Add(this.lstLopB);
            this.grpLopB.Location = new System.Drawing.Point(295, 50);
            this.grpLopB.Name = "grpLopB";
            this.grpLopB.Size = new System.Drawing.Size(235, 260);
            this.grpLopB.TabIndex = 2;
            this.grpLopB.TabStop = false;
            this.grpLopB.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLopB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 20;
            this.lstLopB.Location = new System.Drawing.Point(3, 18);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(229, 239);
            this.lstLopB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 340);
            this.Controls.Add(this.grpLopB);
            this.Controls.Add(this.grpLopA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLopA.ResumeLayout(false);
            this.grpLopB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVienMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.GroupBox grpLopA;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox grpLopB;
        private System.Windows.Forms.ListBox lstLopB;
    }
}