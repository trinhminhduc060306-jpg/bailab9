namespace Lab9_DataReaderSearch
{
    partial class FormCau5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblTrangThai;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiemTB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();

            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).BeginInit();

            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);

            this.lblTieuDe.Location =
                new System.Drawing.Point(220, 20);

            this.lblTieuDe.Text =
                "HIỂN THỊ CHI TIẾT SINH VIÊN";

            // dgvSinhVien
            this.dgvSinhVien.Location =
                new System.Drawing.Point(30, 70);

            this.dgvSinhVien.Size =
                new System.Drawing.Size(740, 280);

            this.dgvSinhVien.Name = "dgvSinhVien";

            this.dgvSinhVien.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSinhVien.ReadOnly = true;

            this.dgvSinhVien.AllowUserToAddRows = false;

            this.dgvSinhVien.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSinhVien.MultiSelect = false;

            this.dgvSinhVien.SelectionChanged +=
                new System.EventHandler(this.dgvSinhVien_SelectionChanged);

            // lblMaSV
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location =
                new System.Drawing.Point(40, 375);

            this.lblMaSV.Text = "Mã sinh viên:";

            // txtMaSV
            this.txtMaSV.Location =
                new System.Drawing.Point(140, 370);

            this.txtMaSV.Size =
                new System.Drawing.Size(200, 25);

            this.txtMaSV.ReadOnly = true;

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location =
                new System.Drawing.Point(390, 375);

            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location =
                new System.Drawing.Point(460, 370);

            this.txtHoTen.Size =
                new System.Drawing.Size(250, 25);

            this.txtHoTen.ReadOnly = true;

            // lblDiemTB
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location =
                new System.Drawing.Point(40, 420);

            this.lblDiemTB.Text = "Điểm trung bình:";

            // txtDiemTB
            this.txtDiemTB.Location =
                new System.Drawing.Point(140, 415);

            this.txtDiemTB.Size =
                new System.Drawing.Size(200, 25);

            this.txtDiemTB.ReadOnly = true;

            // lblTrangThai
            this.lblTrangThai.AutoSize = true;

            this.lblTrangThai.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Bold);

            this.lblTrangThai.Location =
                new System.Drawing.Point(390, 420);

            this.lblTrangThai.Size =
                new System.Drawing.Size(250, 25);

            this.lblTrangThai.Text = "Đang chọn: ";

            // FormCau5
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 480);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvSinhVien);

            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);

            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);

            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.txtDiemTB);

            this.Controls.Add(this.lblTrangThai);

            this.Name = "FormCau5";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Câu 5 - Chi tiết sinh viên";

            this.Load +=
                new System.EventHandler(this.FormCau5_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}