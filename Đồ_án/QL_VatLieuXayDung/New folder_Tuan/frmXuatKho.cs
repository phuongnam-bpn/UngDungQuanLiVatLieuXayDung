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
    public partial class frmXuatKho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-94RIAE0;Initial Catalog=QL_VLXD;Integrated Security=True");
        public frmXuatKho()
        {
            InitializeComponent();
        }

        private void btnLayDSXuatKho_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT MaPhieuXuatKho, NgayXuat, KhachHangID FROM PhieuXuatKho";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachXuatKho.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgvDanhSachXuatKho.Rows.Add(row["MaPhieuXuatKho"], row["NgayXuat"], row["KhachHangID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnThemXuatKho_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Thêm dữ liệu vào bảng PhieuXuatKho
                string insertPhieuXuatKho = "INSERT INTO PhieuXuatKho (MaPhieuXuatKho,NgayXuat, KhachHangID) VALUES (@MaPhieuXuatKho, @NgayXuat, @KhachHangID); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdPhieuXuatKho = new SqlCommand(insertPhieuXuatKho, conn);
                cmdPhieuXuatKho.Parameters.AddWithValue("@MaPhieuXuatKho", txtMaPhieuXuatKho.Text);
                cmdPhieuXuatKho.Parameters.AddWithValue("@NgayXuat", dtpNgayXuat.Value);
                cmdPhieuXuatKho.Parameters.AddWithValue("@KhachHangID", txtKhachHangId.Text);

                // Lấy giá trị Identity của cột MaPhieuXuatKho sau khi chèn
                int maPhieuXuatKho = Convert.ToInt32(cmdPhieuXuatKho.ExecuteScalar());

                // Thêm dữ liệu vào bảng ChiTietPhieuXuat
                string insertChiTietPhieuXuat = "INSERT INTO ChiTietPhieuXuat (MaPhieuXuatKho, MaHangHoa, SoLuongXuat, GiaBan) VALUES (@MaPhieuXuatKho, @MaHangHoa, @SoLuongXuat, @GiaBan)";
                SqlCommand cmdChiTietPhieuXuat = new SqlCommand(insertChiTietPhieuXuat, conn);
                cmdChiTietPhieuXuat.Parameters.AddWithValue("@MaPhieuXuatKho", maPhieuXuatKho);
                cmdChiTietPhieuXuat.Parameters.AddWithValue("@MaHangHoa", txtMaHang.Text);
                cmdChiTietPhieuXuat.Parameters.AddWithValue("@SoLuongXuat", int.Parse(txtSoLuongXuat.Text));
                cmdChiTietPhieuXuat.Parameters.AddWithValue("@GiaBan", decimal.Parse(txtGiaBan.Text));
                cmdChiTietPhieuXuat.ExecuteNonQuery();

                // Cập nhật lại danh sách xuất kho
                btnLayDSXuatKho_Click(sender, e);

                // Xóa trắng các TextBox và đặt lại ngày hiện tại cho DateTimePicker
                dtpNgayXuat.Value = DateTime.Now;
                txtKhachHangId.Clear();
                txtMaPhieuXuatKho.Clear();
                txtMaHang.Clear();
                txtSoLuongXuat.Clear();
                txtGiaBan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (dgvDanhSachXuatKho.SelectedRows.Count > 0)
                {
                    int maPhieuXuatKho = Convert.ToInt32(dgvDanhSachXuatKho.SelectedRows[0].Cells["MaPhieuXuatKho"].Value);
                    string deleteChiTietPhieuXuat = "DELETE FROM ChiTietPhieuXuat WHERE MaPhieuXuatKho = @MaPhieuXuatKho";
                    SqlCommand cmdChiTietPhieuXuat = new SqlCommand(deleteChiTietPhieuXuat, conn);
                    cmdChiTietPhieuXuat.Parameters.AddWithValue("@MaPhieuXuatKho", maPhieuXuatKho);
                    cmdChiTietPhieuXuat.ExecuteNonQuery();
                    string deletePhieuXuatKho = "DELETE FROM PhieuXuatKho WHERE MaPhieuXuatKho = @MaPhieuXuatKho";
                    SqlCommand cmdPhieuXuatKho = new SqlCommand(deletePhieuXuatKho, conn);
                    cmdPhieuXuatKho.Parameters.AddWithValue("@MaPhieuXuatKho", maPhieuXuatKho);
                    cmdPhieuXuatKho.ExecuteNonQuery();
                    btnLayDSXuatKho_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phiếu để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
