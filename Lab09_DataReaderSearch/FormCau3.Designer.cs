namespace Lab9_DataReaderSearch
{
    partial class FormCau3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;

        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;

        private System.Windows.Forms.Button btnFilter;
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
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();

            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();

            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);

            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.Text = "LOC SINH VIEN";

            // lblKhoa
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(30, 80);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 20);
            this.lblKhoa.Text = "Khoa:";

            // cboKhoa
            this.cboKhoa.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboKhoa.Location = new System.Drawing.Point(90, 77);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(180, 24);

            // lblMin
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(290, 80);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(80, 20);
            this.lblMin.Text = "Diem min:";

            // nudMin
            this.nudMin.DecimalPlaces = 2;
            this.nudMin.Increment = 0.25M;
            this.nudMin.Maximum = 10;
            this.nudMin.Minimum = 0;
            this.nudMin.Location = new System.Drawing.Point(380, 77);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(90, 22);

            // lblMax
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(490, 80);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(80, 20);
            this.lblMax.Text = "Diem max:";

            // nudMax
            this.nudMax.DecimalPlaces = 2;
            this.nudMax.Increment = 0.25M;
            this.nudMax.Maximum = 10;
            this.nudMax.Minimum = 0;
            this.nudMax.Value = 10;
            this.nudMax.Location = new System.Drawing.Point(580, 77);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(90, 22);

            // btnFilter
            this.btnFilter.Location = new System.Drawing.Point(680, 73);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.Text = "Loc";
            this.btnFilter.UseVisualStyleBackColor = true;

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
            this.dgvSinhVien.Size = new System.Drawing.Size(750, 320);

            // FormCau3
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(820, 480);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvSinhVien);

            this.Name = "FormCau3";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Cau 3 - Loc sinh vien";

            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}