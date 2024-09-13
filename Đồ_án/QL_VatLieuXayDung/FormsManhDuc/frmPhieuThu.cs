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
    public partial class frmPhieuThu : Form
    {
        public frmPhieuThu()
        {
            InitializeComponent();
            loadDataToDataGridView();
        }

        private void loadDataToDataGridView()
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string query = "SELECT * FROM PhieuThu";

                DataTable dt = database.ExecuteQuery(query);

                dgvChiTietPhieuThu.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có lỗi xảy ra trong quá trình load dữ liệu
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtMaPhieuThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayThu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string temp = Generator.ID("PT", "MaPhieuThu", "PhieuThu");
                string maPhieuThu = string.IsNullOrEmpty(txtMaPhieuThu.Text) ? temp : txtMaPhieuThu.Text;

                string maKhachHang = txtMaKhachHang.Text;
                DateTime ngayThu = dateNgayThu.Value;
                decimal soTienThu = decimal.Parse(txtSoTienThu.Text);

                if (string.IsNullOrEmpty(maPhieuThu) || (string.IsNullOrEmpty(maKhachHang) && txtSoTienThu.Text == ""))
                {
                    MessageBox.Show("Không thể thêm khách hàng. Vui lòng thử lại!");
                    return;
                }

                string query = $"INSERT INTO PhieuThu (MaPhieuThu, KhachHangID, NgayThu, SoTienThu) VALUES ('{maPhieuThu}', '{maKhachHang}', '{ngayThu}', '{soTienThu}')";

                int rowsAffected = database.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    // Thêm thành công, bạn có thể thông báo thành công hoặc làm các việc khác tùy vào yêu cầu của bạn
                    MessageBox.Show("Thêm phiếu thu thành công!");

                    // Sau khi thêm dữ liệu, có thể làm sạch các ô nhập liệu hoặc làm gì đó khác tùy vào yêu cầu của bạn
                    txtMaPhieuThu.Text = "";
                    txtMaKhachHang.Text = "";
                    txtSoTienThu.Text = "";
                }
                else
                {
                    // Có thể thông báo lỗi nếu không thêm được dữ liệu
                    MessageBox.Show("Không thể thêm phiếu thu. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string maPhieuThu = txtMaPhieuThu.Text;

                string query = $"DELETE FROM Phieuthu WHERE MaPhieuThu = '{maPhieuThu}'";

                int rowsAffected = database.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin phiếu thu. Vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string maPhieuThu = txtMaPhieuThu.Text;
                string maKhachHang = txtMaKhachHang.Text;
                DateTime ngayThu = dateNgayThu.Value;
                decimal soTienThu = decimal.Parse(txtSoTienThu.Text);

                string query = "UPDATE KhachHang SET ";

                if (!string.IsNullOrEmpty(maKhachHang))
                {
                    query += $"KhachHangID = '{maKhachHang}', ";
                }
                query += $"NgayThu = '{ngayThu}', ";
                if (txtSoTienThu.Text == "")
                {
                    query += $"SoTienThu = '{soTienThu}', ";
                }

                query = query.TrimEnd(' ', ',');
                query += $" WHERE MaPhieuThu = '{maPhieuThu}'";

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in những gì bạn cần vào trong đầu của bạn");
        }

        private void dgvChiTietPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieuThu.Rows[e.RowIndex];

                txtMaPhieuThu.Text = row.Cells["MaPhieuThu"].Value.ToString();
                txtMaKhachHang.Text = row.Cells["KhachHangID"].Value.ToString();

                // Chuyển đổi chuỗi sang kiểu DateTime
                if (DateTime.TryParse(row.Cells["NgayThu"].Value.ToString(), out DateTime ngayThu))
                {
                    dateNgayThu.Value = ngayThu;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi thành công
                    MessageBox.Show("Ngày thu không hợp lệ.");
                }

                // Chuyển đổi chuỗi sang kiểu decimal
                if (decimal.TryParse(row.Cells["SoTienThu"].Value.ToString(), out decimal soTienThu))
                {
                    txtSoTienThu.Text = soTienThu.ToString(); // Đưa giá trị vào TextBox
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi thành công
                    MessageBox.Show("Số tiền thu không hợp lệ.");
                }
            }
        }

    }
}
