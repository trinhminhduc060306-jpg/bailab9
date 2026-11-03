using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab09_DataReaderSearch;

namespace Lab9_DataReaderSearch
{
    public partial class FormCau5 : Form
    {
        public FormCau5()
        {
            InitializeComponent();
        }

        private void FormCau5_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void LoadSinhVien()
        {
            try
            {
                string sql = @"
                    SELECT MaSV, HoTen, MaKhoa, DiemTB
                    FROM SinhVien
                    ORDER BY MaSV";

                using (SqlConnection conn = DataConnect.Create())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvSinhVien.DataSource = dt;
                        }
                    }
                }

                // Hiển thị thông tin dòng đầu tiên nếu có dữ liệu
                if (dgvSinhVien.Rows.Count > 0)
                {
                    dgvSinhVien.Rows[0].Selected = true;
                    HienThiChiTiet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            HienThiChiTiet();
        }

        private void HienThiChiTiet()
        {
            if (dgvSinhVien.CurrentRow == null)
                return;

            if (dgvSinhVien.CurrentRow.IsNewRow)
                return;

            DataGridViewRow row = dgvSinhVien.CurrentRow;

            txtMaSV.Text = LayGiaTri(row, "MaSV");
            txtHoTen.Text = LayGiaTri(row, "HoTen");
            txtDiemTB.Text = LayGiaTri(row, "DiemTB");

            lblTrangThai.Text = "Đang chọn: " + txtMaSV.Text;
        }

        private string LayGiaTri(DataGridViewRow row, string tenCot)
        {
            object value = row.Cells[tenCot].Value;

            if (value == null || value == DBNull.Value)
                return "";

            return Convert.ToString(value);
        }
    }
}