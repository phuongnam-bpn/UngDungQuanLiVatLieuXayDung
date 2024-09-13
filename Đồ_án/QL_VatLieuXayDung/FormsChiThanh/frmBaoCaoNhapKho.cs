using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_VatLieuXayDung
{
    public partial class frmBaoCaoNhapKho : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public frmBaoCaoNhapKho()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Lấy dữ liệu từ bảng ChiTietPhieuNhap
                dataAdapter = new SqlDataAdapter("SELECT * FROM ChiTietPhieuNhap", connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Hiển thị dữ liệu lên dataGridView1
                dataGridView1.DataSource = dataTable;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaoCaoNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn đóng form nếu người dùng chọn "No"
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin của dòng được chọn lên các textbox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MaPhieuNhap.Text = row.Cells["MaPhieuNhapKho"].Value.ToString();
                txt_MaHangHoa.Text = row.Cells["MaHangHoa"].Value.ToString();
                txt_SoLuong.Text = row.Cells["SoLuongNhap"].Value.ToString();
                txt_GiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();

                // Tính thành tiền và hiển thị lên txt_ThanhTien
                int soLuongNhap = Convert.ToInt32(txt_SoLuong.Text);
                decimal giaNhap = Convert.ToDecimal(txt_GiaNhap.Text);
                decimal thanhTien = soLuongNhap * giaNhap;
                txt_ThanhTien.Text = thanhTien.ToString();
            }
        }
    }
}
