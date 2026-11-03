using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab09_DataReaderSearch;

namespace Lab9_DataReaderSearch
{
    public partial class FormCau4 : Form
    {
        private int pageIndex = 1;
        private const int pageSize = 10;

        public FormCau4()
        {
            InitializeComponent();
        }

        private void FormCau4_Load(object sender, EventArgs e)
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
                    ORDER BY MaSV
                    OFFSET @Offset ROWS
                    FETCH NEXT @PageSize ROWS ONLY";

                using (SqlConnection conn = DataConnect.Create())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Offset", SqlDbType.Int).Value =
                            (pageIndex - 1) * pageSize;

                        cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value =
                            pageSize;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvSinhVien.DataSource = dt;
                        }
                    }
                }

                lblTrang.Text = "Trang " + pageIndex;

                btnTruoc.Enabled = pageIndex > 1;
                btnSau.Enabled = dgvSinhVien.Rows.Count == pageSize;
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

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                LoadSinhVien();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.Rows.Count == pageSize)
            {
                pageIndex++;
                LoadSinhVien();
            }
        }
    }
}