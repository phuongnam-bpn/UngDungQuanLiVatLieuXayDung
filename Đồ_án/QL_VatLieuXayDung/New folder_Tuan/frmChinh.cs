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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNV nv = new frmQLNV(); //Khoi tao moi
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatKho xk = new frmXuatKho();
            this.Hide();
            xk.ShowDialog();
            this.Show();
        }

        private void báoCáoXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoXuat bc = new frmBaoCaoXuat();
            this.Hide();
            bc.ShowDialog();
            this.Show();
        }
    }
}
