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
    public partial class frmQLNV : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True");

        public frmQLNV()
        {
            InitializeComponent();
        }

        private void btnLayDSNV_Click(object sender, EventArgs e)
        {
            try
            {
                //conn.Open();
                string sql = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachNV.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgvDanhSachNV.Rows.Add(row["MaNhanVien"],row["TenNhanVien"], row["DiaChi"], row["SoDienThoai"], row["NgayBatDauLamViec"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                //conn.Close();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                conn.Open();

                // Tạo mã nhân viên tự động và không trùng lặp
                string maNhanVien = txtMaNhanVien.Text;
                string tenNV = txtTenNV.Text;
                string diaChi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                DateTime ngayBatDau = dtpNgayBatDau.Value;

                string sql = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, NgayBatDauLamViec) VALUES (@MaNhanVien, @TenNhanVien, @DiaChi, @SoDienThoai, @NgayBatDauLamViec)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@TenNhanVien", tenNV);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@NgayBatDauLamViec", ngayBatDau.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, cập nhật lại dữ liệu trong DataGridView
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc thêm nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10,}$");
        }
       
        private void RefreshDataGridView()
        {
            try
            {
                string sql = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachNV.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgvDanhSachNV.Rows.Add(row["MaNhanVien"],row["TenNhanVien"], row["DiaChi"], row["SoDienThoai"], row["NgayBatDauLamViec"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc cập nhật dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmployeeIDExist(string employeeID)
        {
            try
            {
                //conn.Open();
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", employeeID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc kiểm tra mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            finally
            {
                //conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
            RefreshDataGridView();
        }

        private void XoaNhanVien()
        {
            try
            {
                string maNhanVien = txtMaNhanVien.Text;

                conn.Open();
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLayDSNV_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc xóa nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            TimKiemNhanVien(maNhanVien);
        }
        private void TimKiemNhanVien(string maNhanVien)
        {
            try
            {
                conn.Open();

                // Sử dụng SqlCommand để thực hiện truy vấn SELECT theo mã nhân viên
                string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Nếu có dữ liệu, hiển thị trong DataGridView
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvDanhSachNV.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            dgvDanhSachNV.Rows.Add(row["MaNhanVien"], row["TenNhanVien"], row["DiaChi"], row["SoDienThoai"], row["NgayBatDauLamViec"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc tìm kiếm nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
