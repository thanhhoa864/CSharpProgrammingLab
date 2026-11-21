
namespace bai01_BTTL_SQL
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtTenMH = new TextBox();
            txtMaMH = new TextBox();
            lblTenMH = new Label();
            lblMaMH = new Label();
            SuspendLayout();

            // btnSua
            btnSua.Location = new Point(234, 82);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // btnXoa
            btnXoa.Location = new Point(137, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnThem
            btnThem.Location = new Point(44, 82);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // txtTenMH
            txtTenMH.Location = new Point(126, 53);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(184, 23);
            txtTenMH.TabIndex = 10;

            // txtMaMH
            txtMaMH.Location = new Point(126, 16);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(184, 23);
            txtMaMH.TabIndex = 9;

            // lblTenMH
            lblTenMH.AutoSize = true;
            lblTenMH.Location = new Point(43, 56);
            lblTenMH.Name = "lblTenMH";
            lblTenMH.Size = new Size(76, 15);
            lblTenMH.TabIndex = 8;
            lblTenMH.Text = "Tên môn học";

            // lblMaMH
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(43, 18);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(75, 15);
            lblMaMH.TabIndex = 7;
            lblMaMH.Text = "Mã môn học";

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 119);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenMH);
            Controls.Add(txtMaMH);
            Controls.Add(lblTenMH);
            Controls.Add(lblMaMH);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtTenMH;
        private TextBox txtMaMH;
        private Label lblTenMH;
        private Label lblMaMH;
    }
}
