namespace bai03_BTVN
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
            tvDanhBa = new TreeView();
            grpNhap = new GroupBox();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnExit = new Button();
            grpNhap.SuspendLayout();
            SuspendLayout();
            // 
            // tvDanhBa
            // 
            tvDanhBa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tvDanhBa.ItemHeight = 22;
            tvDanhBa.Location = new Point(10, 11);
            tvDanhBa.Name = "tvDanhBa";
            tvDanhBa.Size = new Size(228, 394);
            tvDanhBa.TabIndex = 0;
            // 
            // grpNhap
            // 
            grpNhap.Controls.Add(btnAdd);
            grpNhap.Controls.Add(txtLastName);
            grpNhap.Controls.Add(txtFirstName);
            grpNhap.Controls.Add(lblLastName);
            grpNhap.Controls.Add(lblFirstName);
            grpNhap.Location = new Point(254, 14);
            grpNhap.Name = "grpNhap";
            grpNhap.Size = new Size(293, 216);
            grpNhap.TabIndex = 1;
            grpNhap.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(192, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(92, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(184, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(92, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(184, 23);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(16, 92);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(16, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(464, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 417);
            Controls.Add(btnExit);
            Controls.Add(grpNhap);
            Controls.Add(tvDanhBa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh bạ";
            Load += Form1_Load;
            grpNhap.ResumeLayout(false);
            grpNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView tvDanhBa;
        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}