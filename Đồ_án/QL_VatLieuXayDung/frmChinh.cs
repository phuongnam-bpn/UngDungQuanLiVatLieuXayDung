using QL_VatLieuXayDung.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VatLieuXayDung
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (r == DialogResult.Yes)
            {
                frmĐangNhap f = new frmĐangNhap();
                this.Hide();
               f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hủy đăng xuất thành công.");
            }    
            this.Close();
        }

        private void mnuNhaCC_Click(object sender, EventArgs e)
        {

            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuPhieuChi_Click(object sender, EventArgs e)
        {
            frmPhieuChi f = new frmPhieuChi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuBaoCaoCongNoNCC_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNoNCC f = new frmBaoCaoCongNoNCC();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuPhieuThu_Click(object sender, EventArgs e)
        {
            frmPhieuThu f = new frmPhieuThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuBaoCaoCongNoKH_Click(object sender, EventArgs e)
        {
            frmCongNo f = new frmCongNo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNV f = new frmQLNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnnuNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho f = new frmNhapKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuXuatKho_Click(object sender, EventArgs e)
        {
            frmXuatKho f = new frmXuatKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mnuBaoCaoNhapKho_Click(object sender, EventArgs e)
        {
            frmBaoCaoNhapKho f = new frmBaoCaoNhapKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void menuBaoCaoXuatKho_Click(object sender, EventArgs e)
        {
            frmBaoCaoXuat f = new frmBaoCaoXuat();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
