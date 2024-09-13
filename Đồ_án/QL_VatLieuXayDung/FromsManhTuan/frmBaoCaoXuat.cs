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
    public partial class frmBaoCaoXuat : Form
    {
        private string conn = "Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True";
        public frmBaoCaoXuat()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvBaoCao.Rows.Clear();
            if (radKhachHang.Checked)
            {
                string selectedKhachHang = cboKhachHang.SelectedItem.ToString();
                LoadDataForDataGridView(selectedKhachHang);
            }
            else if (radThoiGian.Checked)
            {
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;
                LoadDataForDataGridView(tuNgay, denNgay);
            }
            TinhTong();
        }

       

        private void frmBaoCaoXuat_Load(object sender, EventArgs e)
        {
            radKhachHang.Checked = true;
            LoadDataForKhachHangComboBox();
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
        }

        private void radKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            cboKhachHang.Enabled = true;
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            cboKhachHang.Enabled = false;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
        }
        private void LoadDataForKhachHangComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string sqlQuery = "SELECT TenKhachHang FROM KhachHang";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cboKhachHang.Items.Add(reader["TenKhachHang"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message);
            }
        }
        private void LoadDataForDataGridView(string selectedKhachHang)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string sqlQuery = "SELECT NgayXuat, TenHangHoa, SoLuongXuat, GiaBan FROM BaoCaoXuatKho WHERE TenKhachHang = '" + selectedKhachHang + "'";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvBaoCao.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dgvBaoCao.Rows.Add(
                                row["NgayXuat"].ToString(),
                                row["TenHangHoa"].ToString(),
                                row["SoLuongXuat"].ToString(),
                                row["GiaBan"].ToString()
                            );
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu cho DataGridView: " + ex.Message);
            }
        }
         private void LoadDataForDataGridView(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    // Sử dụng tham số trong câu truy vấn
                    string sqlQuery = "SELECT NgayXuat, TenHangHoa, SoLuongXuat, GiaBan FROM BaoCaoXuatKho WHERE NgayXuat BETWEEN @TuNgay AND @DenNgay";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        // Đặt giá trị cho tham số
                        adapter.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                        adapter.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvBaoCao.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dgvBaoCao.Rows.Add(
                                row["NgayXuat"].ToString(),
                                row["TenHangHoa"].ToString(),
                                row["SoLuongXuat"].ToString(),
                                row["GiaBan"].ToString()
                            );
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu cho DataGridView: " + ex.Message);
            }
        }
        private void TinhTong()
        {
            int tongSoLuong = 0;
            decimal tongGiaTri = 0;

            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                object soLuongCellValue = row.Cells["colSoLuongXuat"].Value;
                object giaBanCellValue = row.Cells["colGiaBan"].Value;

                if (soLuongCellValue != null && giaBanCellValue != null)
                {
                    int soLuongXuat;
                    decimal giaBan;
                    if (int.TryParse(soLuongCellValue.ToString(), out soLuongXuat) && decimal.TryParse(giaBanCellValue.ToString(), out giaBan))
                    {
                        tongSoLuong += soLuongXuat;
                        tongGiaTri += soLuongXuat * giaBan;
                    }
                }
            }

            lblTongSoLuong.Text = "Tổng số lượng: " + tongSoLuong.ToString();
            lblTongGiaTri.Text = "Tổng giá trị: " + tongGiaTri.ToString("C");
        }
    }
}
