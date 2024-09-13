using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_VatLieuXayDung
{
    public partial class frmĐangNhap : Form
    {
        public frmĐangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-94RIAE0;Initial Catalog=QL_VLXD;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from NguoiDung where Username ='" + tk + "' and Password = '" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader da = cmd.ExecuteReader();
                if(da.Read() == true )
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmChinh f = new frmChinh();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }





            //frmChinh f = new frmChinh();
            //f.Show();
            //this.Hide();
        }

        private void chkMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar= true;
            }    
        }

        private void frmĐangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
