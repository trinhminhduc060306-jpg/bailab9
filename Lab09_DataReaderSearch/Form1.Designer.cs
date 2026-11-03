namespace Lab9_DataReaderSearch
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvSinhVien;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);

            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TIM KIEM SINH VIEN";

            // lblKeyword
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.lblKeyword.Location = new System.Drawing.Point(30, 80);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(110, 23);
            this.lblKeyword.TabIndex = 1;
            this.lblKeyword.Text = "Nhập họ tên:";

            // txtKeyword
            this.txtKeyword.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.txtKeyword.Location = new System.Drawing.Point(150, 77);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(300, 30);
            this.txtKeyword.TabIndex = 2;

            // btnSearch
            this.btnSearch.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.btnSearch.Location = new System.Drawing.Point(470, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;

            // btnShowAll
            this.btnShowAll.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.btnShowAll.Location = new System.Drawing.Point(610, 75);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(130, 35);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;

            // dgvSinhVien
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;

            this.dgvSinhVien.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSinhVien.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvSinhVien.Location = new System.Drawing.Point(30, 130);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(740, 320);
            this.dgvSinhVien.TabIndex = 5;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(800, 480);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgvSinhVien);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Cau 2 - Tim kiem sinh vien";

            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}