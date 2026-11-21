namespace bai01_BTVN
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnhViet = new System.Windows.Forms.TabPage();
            this.lblTiengAnh = new System.Windows.Forms.Label();
            this.cboTuAV = new System.Windows.Forms.ComboBox();
            this.lstTuAV = new System.Windows.Forms.ListBox();
            this.lblTiengViet = new System.Windows.Forms.Label();
            this.txtNghiaAV = new System.Windows.Forms.TextBox();
            this.tabVietAnh = new System.Windows.Forms.TabPage();
            this.lblTiengViet2 = new System.Windows.Forms.Label();
            this.cboTuVA = new System.Windows.Forms.ComboBox();
            this.lstTuVA = new System.Windows.Forms.ListBox();
            this.lblTiengAnh2 = new System.Windows.Forms.Label();
            this.txtNghiaVA = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnhViet);
            this.tabControl1.Controls.Add(this.tabVietAnh);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnhViet
            // 
            this.tabAnhViet.Controls.Add(this.txtNghiaAV);
            this.tabAnhViet.Controls.Add(this.lblTiengViet);
            this.tabAnhViet.Controls.Add(this.lstTuAV);
            this.tabAnhViet.Controls.Add(this.cboTuAV);
            this.tabAnhViet.Controls.Add(this.lblTiengAnh);
            this.tabAnhViet.Location = new System.Drawing.Point(4, 25);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnhViet.Size = new System.Drawing.Size(552, 331);
            this.tabAnhViet.TabIndex = 0;
            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // lblTiengAnh
            // 
            this.lblTiengAnh.AutoSize = true;
            this.lblTiengAnh.Location = new System.Drawing.Point(15, 12);
            this.lblTiengAnh.Name = "lblTiengAnh";
            this.lblTiengAnh.Size = new System.Drawing.Size(69, 16);
            this.lblTiengAnh.TabIndex = 0;
            this.lblTiengAnh.Text = "Tiếng Anh";
            // 
            // cboTuAV
            // 
            this.cboTuAV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTuAV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTuAV.FormattingEnabled = true;
            this.cboTuAV.Location = new System.Drawing.Point(18, 35);
            this.cboTuAV.Name = "cboTuAV";
            this.cboTuAV.Size = new System.Drawing.Size(220, 24);
            this.cboTuAV.TabIndex = 1;
            this.cboTuAV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTuAV_KeyDown);
            // 
            // lstTuAV
            // 
            this.lstTuAV.FormattingEnabled = true;
            this.lstTuAV.ItemHeight = 16;
            this.lstTuAV.Location = new System.Drawing.Point(18, 65);
            this.lstTuAV.Name = "lstTuAV";
            this.lstTuAV.Size = new System.Drawing.Size(220, 244);
            this.lstTuAV.TabIndex = 2;
            this.lstTuAV.SelectedIndexChanged += new System.EventHandler(this.lstTuAV_SelectedIndexChanged);
            this.lstTuAV.DoubleClick += new System.EventHandler(this.lstTuAV_DoubleClick);
            // 
            // lblTiengViet
            // 
            this.lblTiengViet.AutoSize = true;
            this.lblTiengViet.Location = new System.Drawing.Point(265, 12);
            this.lblTiengViet.Name = "lblTiengViet";
            this.lblTiengViet.Size = new System.Drawing.Size(68, 16);
            this.lblTiengViet.TabIndex = 3;
            this.lblTiengViet.Text = "Tiếng Việt";
            // 
            // txtNghiaAV
            // 
            this.txtNghiaAV.BackColor = System.Drawing.Color.White;
            this.txtNghiaAV.Location = new System.Drawing.Point(268, 35);
            this.txtNghiaAV.Multiline = true;
            this.txtNghiaAV.Name = "txtNghiaAV";
            this.txtNghiaAV.ReadOnly = true;
            this.txtNghiaAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNghiaAV.Size = new System.Drawing.Size(265, 274);
            this.txtNghiaAV.TabIndex = 4;
            // 
            // tabVietAnh
            // 
            this.tabVietAnh.Controls.Add(this.txtNghiaVA);
            this.tabVietAnh.Controls.Add(this.lblTiengAnh2);
            this.tabVietAnh.Controls.Add(this.lstTuVA);
            this.tabVietAnh.Controls.Add(this.cboTuVA);
            this.tabVietAnh.Controls.Add(this.lblTiengViet2);
            this.tabVietAnh.Location = new System.Drawing.Point(4, 25);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
            this.tabVietAnh.Size = new System.Drawing.Size(552, 331);
            this.tabVietAnh.TabIndex = 1;
            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // lblTiengViet2
            // 
            this.lblTiengViet2.AutoSize = true;
            this.lblTiengViet2.Location = new System.Drawing.Point(15, 12);
            this.lblTiengViet2.Name = "lblTiengViet2";
            this.lblTiengViet2.Size = new System.Drawing.Size(68, 16);
            this.lblTiengViet2.TabIndex = 0;
            this.lblTiengViet2.Text = "Tiếng Việt";
            // 
            // cboTuVA
            // 
            this.cboTuVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTuVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTuVA.FormattingEnabled = true;
            this.cboTuVA.Location = new System.Drawing.Point(18, 35);
            this.cboTuVA.Name = "cboTuVA";
            this.cboTuVA.Size = new System.Drawing.Size(220, 24);
            this.cboTuVA.TabIndex = 1;
            this.cboTuVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTuVA_KeyDown);
            // 
            // lstTuVA
            // 
            this.lstTuVA.FormattingEnabled = true;
            this.lstTuVA.ItemHeight = 16;
            this.lstTuVA.Location = new System.Drawing.Point(18, 65);
            this.lstTuVA.Name = "lstTuVA";
            this.lstTuVA.Size = new System.Drawing.Size(220, 244);
            this.lstTuVA.TabIndex = 2;
            this.lstTuVA.SelectedIndexChanged += new System.EventHandler(this.lstTuVA_SelectedIndexChanged);
            this.lstTuVA.DoubleClick += new System.EventHandler(this.lstTuVA_DoubleClick);
            // 
            // lblTiengAnh2
            // 
            this.lblTiengAnh2.AutoSize = true;
            this.lblTiengAnh2.Location = new System.Drawing.Point(265, 12);
            this.lblTiengAnh2.Name = "lblTiengAnh2";
            this.lblTiengAnh2.Size = new System.Drawing.Size(69, 16);
            this.lblTiengAnh2.TabIndex = 3;
            this.lblTiengAnh2.Text = "Tiếng Anh";
            // 
            // txtNghiaVA
            // 
            this.txtNghiaVA.BackColor = System.Drawing.Color.White;
            this.txtNghiaVA.Location = new System.Drawing.Point(268, 35);
            this.txtNghiaVA.Multiline = true;
            this.txtNghiaVA.Name = "txtNghiaVA";
            this.txtNghiaVA.ReadOnly = true;
            this.txtNghiaVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNghiaVA.Size = new System.Drawing.Size(265, 274);
            this.txtNghiaVA.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(460, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnhViet.ResumeLayout(false);
            this.tabAnhViet.PerformLayout();
            this.tabVietAnh.ResumeLayout(false);
            this.tabVietAnh.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnhViet;
        private System.Windows.Forms.Label lblTiengAnh;
        private System.Windows.Forms.ComboBox cboTuAV;
        private System.Windows.Forms.ListBox lstTuAV;
        private System.Windows.Forms.Label lblTiengViet;
        private System.Windows.Forms.TextBox txtNghiaAV;
        private System.Windows.Forms.TabPage tabVietAnh;
        private System.Windows.Forms.Label lblTiengViet2;
        private System.Windows.Forms.ComboBox cboTuVA;
        private System.Windows.Forms.ListBox lstTuVA;
        private System.Windows.Forms.Label lblTiengAnh2;
        private System.Windows.Forms.TextBox txtNghiaVA;
        private System.Windows.Forms.Button btnThoat;
    }
}