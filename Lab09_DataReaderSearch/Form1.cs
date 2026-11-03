using Lab09_DataReaderSearch;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab9_DataReaderSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tu dong nap du lieu khi Form khoi dong
            this.Load += Form1_Load;
            btnSearch.Click += btnSearch_Click;
            btnShowAll.Click += btnShowAll_Click;
        }
        //cau1
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSinhVien.DataSource = LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Loi khi tai du lieu: " + ex.Message,
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private DataTable LoadStudents()
        {
            string sql = @"
                SELECT
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh,
                    k.TenKhoa,
                    sv.DiemTB
                FROM dbo.SinhVien sv
                JOIN dbo.Khoa k
                    ON sv.MaKhoa = k.MaKhoa";

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

            return table;
        }
        //cau2
        private DataTable SearchByName(string keyword)
        {
            string sql = @"
        SELECT MaSV, HoTen, MaKhoa, DiemTB
        FROM dbo.SinhVien
        WHERE HoTen LIKE @Keyword
        ORDER BY HoTen";

            DataTable table = new DataTable();

            using (SqlConnection conn = DataConnect.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar, 100).Value =
                    "%" + keyword.Trim() + "%";

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();

            dgvSinhVien.DataSource = SearchByName(keyword);
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            dgvSinhVien.DataSource = LoadStudents();
        }
    }
}