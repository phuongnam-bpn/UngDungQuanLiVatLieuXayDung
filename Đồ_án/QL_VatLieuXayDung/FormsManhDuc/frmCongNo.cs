using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VatLieuXayDung.Forms
{
    public partial class frmCongNo : Form
    {
        public frmCongNo()
        {
            InitializeComponent();
            loadDataToDataGridView();
            loadDataToTextbox();
        }

        private void loadDataToDataGridView()
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string query = "SELECT * FROM BaoCaoCongNoKhachHang";

                DataTable dt = database.ExecuteQuery(query);

                dgvBaoCaoCongNoKhachHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có lỗi xảy ra trong quá trình load dữ liệu
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void loadDataToTextbox()
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string queryTongThu = "SELECT SUM(TongThu) FROM BaoCaoCongNoKhachHang";
                string queryTongXuat = "SELECT SUM(TongXuat) FROM BaoCaoCongNoKhachHang";
                string queryTongCongNo = "SELECT SUM(CongNo) FROM BaoCaoCongNoKhachHang";

                object tongThu = database.ExecuteScalar(queryTongThu);
                object tongXuat = database.ExecuteScalar(queryTongXuat);
                object tongCongNo = database.ExecuteScalar(queryTongCongNo);

                txtTongThuToanBo.Text = tongThu.ToString();
                txtTongXuatToanBo.Text = tongXuat.ToString();
                txtTongCongNoToanBo.Text = tongCongNo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvBaoCaoCongNoKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTongThuToanBo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongXuatToanBo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongCongNoToanBo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
