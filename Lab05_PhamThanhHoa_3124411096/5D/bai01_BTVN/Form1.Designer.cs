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
            components = new System.ComponentModel.Container();
            lblDongHo = new Label();
            btnBatDau = new Button();
            timerDemNguoc = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDongHo
            // 
            lblDongHo.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDongHo.Location = new Point(44, 19);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(158, 38);
            lblDongHo.TabIndex = 0;
            lblDongHo.Text = "30:00";
            lblDongHo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            btnBatDau.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatDau.Location = new Point(34, 60);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(182, 33);
            btnBatDau.TabIndex = 1;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // timerDemNguoc
            // 
            timerDemNguoc.Interval = 1000;
            timerDemNguoc.Tick += timerDemNguoc_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 120);
            Controls.Add(btnBatDau);
            Controls.Add(lblDongHo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đồng hồ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer timerDemNguoc;
    }
}