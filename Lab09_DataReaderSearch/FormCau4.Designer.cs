namespace Lab9_DataReaderSearch
{
    partial class FormCau4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Label lblTieuDe;

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
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).BeginInit();

            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);

            this.lblTieuDe.Location = new System.Drawing.Point(250, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(250, 26);
            this.lblTieuDe.Text = "PHÂN TRANG SINH VIÊN";

            // dgvSinhVien
            this.dgvSinhVien.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvSinhVien.Location =
                new System.Drawing.Point(30, 70);

            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size =
                new System.Drawing.Size(740, 350);

            this.dgvSinhVien.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnTruoc
            this.btnTruoc.Location =
                new System.Drawing.Point(250, 440);

            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size =
                new System.Drawing.Size(100, 35);

            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click +=
                new System.EventHandler(this.btnTruoc_Click);

            // lblTrang
            this.lblTrang.AutoSize = true;
            this.lblTrang.Location =
                new System.Drawing.Point(380, 450);

            this.lblTrang.Name = "lblTrang";
            this.lblTrang.Size =
                new System.Drawing.Size(50, 20);

            this.lblTrang.Text = "Trang 1";

            // btnSau
            this.btnSau.Location =
                new System.Drawing.Point(470, 440);

            this.btnSau.Name = "btnSau";
            this.btnSau.Size =
                new System.Drawing.Size(100, 35);

            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click +=
                new System.EventHandler(this.btnSau_Click);

            // FormCau4
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 500);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.lblTrang);

            this.Name = "FormCau4";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Câu 4 - Phân trang sinh viên";

            this.Load +=
                new System.EventHandler(this.FormCau4_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}