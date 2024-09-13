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
    public partial class QL_HangHoa : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True";

        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public QL_HangHoa()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Lấy dữ liệu từ bảng HangHoa
                dataAdapter = new SqlDataAdapter("SELECT * FROM HangHoa", connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Hiển thị dữ liệu lên dataGridView1
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QL_HangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn đóng form nếu người dùng chọn "No"
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thêm mới vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HangHoa (TenHangHoa, DonViTinh, GiaNhap, GiaBan, SoLuongTon, NhaCungCapID) VALUES (@TenHangHoa, @DonViTinh, @GiaNhap, @GiaBan, @SoLuongTon, @NhaCungCapID)", connection);

                cmd.Parameters.AddWithValue("@TenHangHoa", txt_TenHangHoa.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txt_DonViTinh.Text);
                cmd.Parameters.AddWithValue("@GiaNhap", Convert.ToInt32(txt_GiaNhap.Text));
                cmd.Parameters.AddWithValue("@GiaBan", Convert.ToInt32(txt_GiaBan.Text));
                cmd.Parameters.AddWithValue("@SoLuongTon", Convert.ToInt32(txt_SoLuongTon.Text));
                cmd.Parameters.AddWithValue("@NhaCungCapID", GetNhaCungCapID(txt_NhaCungCap.Text));
                //cmd.Parameters.AddWithValue("@GiaNhap", Convert.ToDecimal(txt_GiaNhap.Text));
                //cmd.Parameters.AddWithValue("@GiaBan", Convert.ToDecimal(txt_GiaBan.Text));
                //cmd.Parameters.AddWithValue("@SoLuongTon", Convert.ToInt32(txt_SoLuongTon.Text));
                //cmd.Parameters.AddWithValue("@NhaCungCapID", GetNhaCungCapID(txt_NhaCungCap.Text));

                cmd.ExecuteNonQuery();

                // Reload dữ liệu sau khi thêm mới
                LoadData();
            }
        }

        private int GetNhaCungCapID(string nccName)
        {
            // Hàm để lấy ID của Nhà Cung Cấp từ tên
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT NhaCungCapID FROM NhaCungCap WHERE TenNhaCungCap = @TenNhaCungCap", connection);
                cmd.Parameters.AddWithValue("@TenNhaCungCap", nccName);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin của dòng được chọn lên các textbox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MaHH.Text = row.Cells["MaHangHoa"].Value.ToString();
                txt_TenHangHoa.Text = row.Cells["TenHangHoa"].Value.ToString();
                txt_DonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txt_GiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                txt_GiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txt_SoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();

                // Lấy Nhà Cung Cấp từ cột NhaCungCapID
                int nccID = Convert.ToInt32(row.Cells["NhaCungCapID"].Value);
                txt_NhaCungCap.Text = GetNhaCungCapName(nccID);
            }
        }

        private string GetNhaCungCapName(int nccID)
        {
            // Hàm để lấy tên Nhà Cung Cấp từ ID
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenNhaCungCap FROM NhaCungCap WHERE NhaCungCapID = @NhaCungCapID", connection);
                cmd.Parameters.AddWithValue("@NhaCungCapID", nccID);
                return cmd.ExecuteScalar().ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa khỏi cơ sở dữ liệu
            if (!string.IsNullOrEmpty(txt_MaHH.Text))
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM HangHoa WHERE MaHangHoa = @MaHangHoa", connection);
                    cmd.Parameters.AddWithValue("@MaHangHoa", Convert.ToInt32(txt_MaHH.Text));

                    cmd.ExecuteNonQuery();

                    // Reload dữ liệu sau khi xóa
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin vào cơ sở dữ liệu
            if (!string.IsNullOrEmpty(txt_MaHH.Text))
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE HangHoa SET TenHangHoa = @TenHangHoa, DonViTinh = @DonViTinh, GiaNhap = @GiaNhap, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon, NhaCungCapID = @NhaCungCapID WHERE MaHangHoa = @MaHangHoa", connection);

                    cmd.Parameters.AddWithValue("@MaHangHoa", Convert.ToInt32(txt_MaHH.Text));
                    cmd.Parameters.AddWithValue("@TenHangHoa", txt_TenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@DonViTinh", txt_DonViTinh.Text);
                    cmd.Parameters.AddWithValue("@GiaNhap", Convert.ToDecimal(txt_GiaNhap.Text));
                    cmd.Parameters.AddWithValue("@GiaBan", Convert.ToDecimal(txt_GiaBan.Text));
                    cmd.Parameters.AddWithValue("@SoLuongTon", Convert.ToInt32(txt_SoLuongTon.Text));
                    cmd.Parameters.AddWithValue("@NhaCungCapID", GetNhaCungCapID(txt_NhaCungCap.Text));

                    cmd.ExecuteNonQuery();

                    // Reload dữ liệu sau khi cập nhật
                    LoadData();
                }
            }
        }
    }
}
