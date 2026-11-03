using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab09_DataReaderSearch;


namespace Lab9_DataReaderSearch
{
    public partial class FormCau3 : Form
    {
        public FormCau3()
        {
            InitializeComponent();

            this.Load += FormCau3_Load;
            btnFilter.Click += btnFilter_Click;
        }

        private void FormCau3_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKhoa();

                nudMin.Value = 0;
                nudMax.Value = 10;

                dgvSinhVien.DataSource = FilterStudents(0, 10, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Loi: " + ex.Message,
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Nap danh sach khoa
        private void LoadKhoa()
        {
            string sql = "SELECT MaKhoa, TenKhoa FROM dbo.Khoa";

            DataTable table = new DataTable();

            using (SqlConnection conn = DataConnect.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            cboKhoa.DataSource = table;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;
        }

        // Loc sinh vien theo khoa va khoang diem
        private DataTable FilterStudents(decimal min, decimal max, string maKhoa)
        {
            string sql = @"
                SELECT MaSV, HoTen, MaKhoa, DiemTB
                FROM dbo.SinhVien
                WHERE DiemTB BETWEEN @Min AND @Max
                  AND (@MaKhoa IS NULL OR MaKhoa = @MaKhoa)
                ORDER BY DiemTB DESC";

            DataTable table = new DataTable();

            using (SqlConnection conn = DataConnect.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlParameter pMin = cmd.Parameters.Add(
                    "@Min", SqlDbType.Decimal);

                pMin.Precision = 4;
                pMin.Scale = 2;
                pMin.Value = min;

                SqlParameter pMax = cmd.Parameters.Add(
                    "@Max", SqlDbType.Decimal);

                pMax.Precision = 4;
                pMax.Scale = 2;
                pMax.Value = max;

                SqlParameter pKhoa = cmd.Parameters.Add(
                    "@MaKhoa", SqlDbType.VarChar, 10);

                pKhoa.Value = string.IsNullOrEmpty(maKhoa)
                    ? (object)DBNull.Value
                    : maKhoa;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        // Xu ly nut Loc
        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal min = nudMin.Value;
            decimal max = nudMax.Value;

            if (min > max)
            {
                MessageBox.Show(
                    "Diem toi thieu khong duoc lon hon diem toi da!");

                return;
            }

            string maKhoa = cboKhoa.SelectedValue == null
                ? null
                : cboKhoa.SelectedValue.ToString();

            try
            {
                dgvSinhVien.DataSource =
                    FilterStudents(min, max, maKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi loc du lieu: " + ex.Message);
            }
        }
    }
}