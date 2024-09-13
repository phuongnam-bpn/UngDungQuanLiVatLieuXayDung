using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_VatLieuXayDung.Utils;

namespace QL_VatLieuXayDung.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            loadDataToDataGridView();
        }

        private string generateKhachHangID()
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string query = "SELECT MAX(MaKhachHang) FROM KhachHang";

                DataTable dt = database.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    string maxID = dt.Rows[0][0].ToString();
                    int numericPart = 0;

                    // Lấy phần số từ MaKhachHang lớn nhất
                    if (int.TryParse(maxID.Substring(2), out numericPart))
                    {
                        numericPart++; // Tăng giá trị số lên 1 để tạo mã mới
                        string newID = "KH" + numericPart.ToString("D3"); // Định dạng mã mới (ví dụ: KH001)

                        return newID;
                    }
                }

                // Nếu không có dữ liệu trong bảng KhachHang hoặc có lỗi xảy ra, trả về mã mặc định
                return "KH001";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return "";
            }
        }

        private void loadDataToDataGridView()
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string query = "SELECT * FROM KhachHang";

                DataTable dt = database.ExecuteQuery(query);

                dgw_khachhang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có lỗi xảy ra trong quá trình load dữ liệu
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            foreach (DataGridViewColumn column in dgw_khachhang.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string temp = Generator.ID("KH", "MaKhachHang", "KhachHang");
                string maKhachHang = string.IsNullOrEmpty(txt_makh.Text) ? generateKhachHangID() : txt_makh.Text;
                //string maKhachHang = txt_makh.Text;

                string tenKhachHang = txt_tenkh.Text;
                string soDienThoai = txt_sdt.Text;
                string diaChi = txt_diachi.Text;

                if (string.IsNullOrEmpty(tenKhachHang) && !string.IsNullOrEmpty(soDienThoai) && !string.IsNullOrEmpty(diaChi))
                {
                    MessageBox.Show("Không thể thêm khách hàng. Vui lòng thử lại!");
                    return;
                }

                string query = $"INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi) VALUES ('{maKhachHang}', '{tenKhachHang}', '{soDienThoai}', '{diaChi}')";

                int rowsAffected = database.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    // Thêm thành công, bạn có thể thông báo thành công hoặc làm các việc khác tùy vào yêu cầu của bạn
                    MessageBox.Show("Thêm khách hàng thành công!");

                    // Sau khi thêm dữ liệu, có thể làm sạch các ô nhập liệu hoặc làm gì đó khác tùy vào yêu cầu của bạn
                    txt_makh.Text = "";
                    txt_tenkh.Text = "";
                    txt_sdt.Text = "";
                    txt_diachi.Text = "";
                }
                else
                {
                    // Có thể thông báo lỗi nếu không thêm được dữ liệu
                    MessageBox.Show("Không thể thêm khách hàng. Vui lòng thử lại!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string maKhachHang = txt_makh.Text;
                string tenKhachHang = txt_tenkh.Text;
                string soDienThoai = txt_sdt.Text;
                string diaChi = txt_diachi.Text;

                string query = "UPDATE KhachHang SET ";

                if (!string.IsNullOrEmpty(tenKhachHang))
                {
                    query += $"TenKhachHang = '{tenKhachHang}', ";
                }
                if (!string.IsNullOrEmpty(soDienThoai))
                {
                    query += $"SoDienThoai = '{soDienThoai}', ";
                }
                if (!string.IsNullOrEmpty(diaChi))
                {
                    query += $"DiaChi = '{diaChi}', ";
                }

                query = query.TrimEnd(' ', ',');
                query += $" WHERE MaKhachHang = '{maKhachHang}'";

                int rowsAffected = database.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể sửa thông tin khách hàng. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string maKhachHang = txt_makh.Text;

                string query = $"DELETE FROM KhachHang WHERE MaKhachHang = '{maKhachHang}'";

                int rowsAffected = database.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể sửa thông tin khách hàng. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string finder = txt_timkiem.Text;
                string query = "SELECT * FROM KhachHang WHERE ";
                if (radio_timkiemtheoten.Checked)
                {
                    query += $"TenKhachHang = '{finder}'";
                }
                else
                {
                    query += $"MaKhachHang = '{finder}'";
                }

                DataTable dt = database.ExecuteQuery(query);

                dgw_khachhang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có lỗi xảy ra trong quá trình load dữ liệu
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void radio_timkiemtheoma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_timkiemtheoten_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgw_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw_khachhang.Rows[e.RowIndex];

                txt_makh.Text = row.Cells["MaKhachHang"].Value.ToString();
                txt_tenkh.Text = row.Cells["TenKhachHang"].Value.ToString();
                txt_sdt.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
