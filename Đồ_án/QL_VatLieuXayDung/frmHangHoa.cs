using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VatLieuXayDung
{
    public partial class frmHangHoa : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True");
        SqlDataAdapter da_QLVLXD;
        DataSet ds_QLVLXD;
        DataColumn[] key = new DataColumn[1];
        public frmHangHoa()
        {
            InitializeComponent();
            string strSelect = "select * from HangHoa";
            da_QLVLXD = new SqlDataAdapter(strSelect, conn);
            ds_QLVLXD = new DataSet();
            da_QLVLXD.Fill(ds_QLVLXD, "HangHoa");
            //thêm khóa chính
            key[0] = ds_QLVLXD.Tables["HangHoa"].Columns[0];
            ds_QLVLXD.Tables["HangHoa"].PrimaryKey = key;
        }

        public void load_GridHangHoa()
        {
            dataGridView1.DataSource = ds_QLVLXD.Tables["HangHoa"];

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            load_GridHangHoa();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           
            DataRow insertRow = ds_QLVLXD.Tables["HangHoa"].NewRow();
            insertRow["MaHangHoa"] = txt_MaHH.Text;
            insertRow["TenHangHoa"] = txt_TenHangHoa.Text;
            insertRow["DonViTinh"] = txt_DonViTinh.Text;
            insertRow["GiaNhap"] = Convert.ToInt32(txt_GiaNhap.Text);
            insertRow["GiaBan"] = Convert.ToInt32(txt_GiaBan.Text);
            insertRow["SoLuongTon"] = Convert.ToInt32(txt_SoLuongTon.Text);
            insertRow["NhaCungCapID"] = txt_NhaCungCap.Text;


            //Thêm dòng dữ liệu vừa tạo vào dataset
            ds_QLVLXD.Tables[0].Rows.Add(insertRow);
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);

            // cập nhật trong dataset
            int kq = da_QLVLXD.Update(ds_QLVLXD, "HangHoa");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");

            txt_MaHH.Clear();
            txt_TenHangHoa.Clear();
            txt_DonViTinh.Clear();
            txt_GiaNhap.Clear();
            txt_GiaBan.Clear();
            txt_NhaCungCap.Clear();
            txt_NhaCungCap.Clear();
        }
        bool KTKhoaNgoai(string ma)
        {
          

            conn.Open();
            string chuoitruyvan1 = "Select count(*) from ChiTietPhieuXuat where MaHangHoa = '" + ma + "'";
            SqlCommand cmd1 = new SqlCommand(chuoitruyvan1, conn);
            int kq1 = (int)cmd1.ExecuteScalar();
            conn.Close();

            conn.Open();
            string chuoitruyvan2 = "Select count(*) from ChiTietPhieuNhap where MaHangHoa = '" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(chuoitruyvan2, conn);
            int kq2 = (int)cmd2.ExecuteScalar();
            conn.Close();

            if (kq1 >= 1 || kq2 >= 1)
                return true;
            return false;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (KTKhoaNgoai(txt_MaHH.Text) == true)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa!");
                    return;
                }
                else
                {

                    DataRow upd_new = ds_QLVLXD.Tables["HangHoa"].Rows.Find(txt_MaHH.Text);
                    if (upd_new != null)
                    {
                        upd_new.Delete();
                    }
                    // Cap nhật trong Csdl
                    SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
                    // cập nhật trong dataset
                    int kq = da_QLVLXD.Update(ds_QLVLXD, "HangHoa");
                    if (kq != 0)
                        MessageBox.Show("Đã cập nhật");
                    else
                        MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_QLVLXD.Tables[0].Rows.Find(txt_MaHH.Text);
            if (dr != null)
            {

              
                dr["TenHangHoa"] = txt_TenHangHoa.Text;
                dr["DonViTinh"] = txt_DonViTinh.Text;
                dr["GiaNhap"] = Convert.ToInt32(txt_GiaNhap.Text);
                dr["GiaBan"] = Convert.ToInt32(txt_GiaBan.Text);
                dr["SoLuongTon"] = Convert.ToInt32(txt_SoLuongTon.Text);
                dr["NhaCungCapID"] = txt_NhaCungCap.Text;

            }
            // Cap nhật trong Csdl
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
            // cập nhật trong dataset
            int kq = da_QLVLXD.Update(ds_QLVLXD, "HangHoa");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");

            txt_MaHH.Clear();
            txt_TenHangHoa.Clear();
            txt_DonViTinh.Clear();
            txt_GiaNhap.Clear();
            txt_GiaBan.Clear();
            txt_NhaCungCap.Clear();
            txt_NhaCungCap.Clear();
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
