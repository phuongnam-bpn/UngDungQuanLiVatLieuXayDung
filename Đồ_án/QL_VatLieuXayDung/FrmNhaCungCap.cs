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
    public partial class FrmNhaCungCap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True"); 
        SqlDataAdapter da_QLVLXD;
        DataSet ds_QLVLXD;
        DataColumn[] key = new DataColumn[1];
        public FrmNhaCungCap()
        {
            InitializeComponent();
            string strSelect = "select NhaCungCapID, TenNhaCungCap, DiaChi, SoDienThoai from NhaCungCap";
            da_QLVLXD = new SqlDataAdapter(strSelect, conn);
            ds_QLVLXD = new DataSet();
            da_QLVLXD.Fill(ds_QLVLXD, "NhaCC");
            //thêm khóa chính
            key[0] = ds_QLVLXD.Tables["NhaCC"].Columns[0];
            ds_QLVLXD.Tables["NhaCC"].PrimaryKey = key;
        }
       

        public void load_Grid()
        {
            dataGridView1.DataSource = ds_QLVLXD.Tables["NhaCC"];
        
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            load_Grid();
            txtMaNcc.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;

            txtMaNcc.Clear();
            txtTenNCC.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;

            // chỉ cho phép đọc
            dataGridView1.ReadOnly = true;
            // ẩn dòng cuối cùng
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ktra_MaNCC(string ma)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string conStr = "Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True";
                conn.ConnectionString = conStr;
                conn.Open();
                // xay dung chuoi truy van
                string strSelect = "Select count(*) from NhaCungCap where NhaCungCapID = '" + ma + "'";
                // khai vao ham commnad vs chuoi truy van va bien ket noi
                SqlCommand cmd = new SqlCommand(strSelect, conn);
                // goi ham thuc thi truy van 
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                if (count >= 1)
                {
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNcc.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNcc.Focus();
            //txtMaNcc.Clear();
            //txtTenNCC.Clear();
            //txtDiachi.Clear();
            //txtDienthoai.Clear();
            DataRow insertRow = ds_QLVLXD.Tables["NhaCC"].NewRow();
            insertRow["NhaCungCapID"] = txtMaNcc.Text;
            insertRow["TenNhaCungCap"] = txtTenNCC.Text;
            insertRow["DiaChi"] = txtDiachi.Text;
            insertRow["SoDienThoai"] = txtDienthoai.Text;


            //Thêm dòng dữ liệu vừa tạo vào dataset
            ds_QLVLXD.Tables[0].Rows.Add(insertRow);
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);

            // cập nhật trong dataset
            int kq = da_QLVLXD.Update(ds_QLVLXD, "NhaCC");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");

            txtMaNcc.Clear();
            txtTenNCC.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();

        }


        private void btnSua_Click(object sender, EventArgs e)
        {

         
            txtTenNCC.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            DataRow dr = ds_QLVLXD.Tables[0].Rows.Find(txtMaNcc.Text);
            if(dr != null)
            {
                dr["TenNhaCungCap"] = txtTenNCC.Text;
                dr["DiaChi"] = txtDiachi.Text;
                dr["SoDienThoai"] = txtDienthoai.Text;
            }
            // Cap nhật trong Csdl
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
            // cập nhật trong dataset
           
            int kq = da_QLVLXD.Update(ds_QLVLXD, "NhaCC");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");
            txtMaNcc.Clear();
            txtTenNCC.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();


        }
        bool KTKhoaNgoai(string ma)
        {
            conn.Open();
            string chuoitruyvan = "Select count(*) from HANGHOA where NhaCungCapID = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(chuoitruyvan, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();

            conn.Open();
            string chuoitruyvan1 = "Select count(*) from PHIEUNHAPKHO where NhaCungCapID = '" + ma + "'";
            SqlCommand cmd1 = new SqlCommand(chuoitruyvan, conn);
            int kq1 = (int)cmd.ExecuteScalar();
            conn.Close();

            conn.Open();
            string chuoitruyvan2 = "Select count(*) from PHIEUCHI where NhaCungCapID = '" + ma + "'";
            SqlCommand cmd2 = new SqlCommand(chuoitruyvan, conn);
            int kq2 = (int)cmd.ExecuteScalar();
            conn.Close();

            if (kq1 >= 1 || kq >=1 || kq2 >= 1)
                return true;
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if( MessageBox.Show("Bạn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if(KTKhoaNgoai(txtMaNcc.Text) == true)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa!");
                    return;
                }    
                else
                {
                    DataRow upd_new = ds_QLVLXD.Tables["NhaCC"].Rows.Find(txtMaNcc.Text);
                    if(upd_new != null )
                    {
                        upd_new.Delete();   
                    }
                    // Cap nhật trong Csdl
                    SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
                    // cập nhật trong dataset
                    int kq = da_QLVLXD.Update(ds_QLVLXD, "NhaCC");
                    if (kq != 0)
                        MessageBox.Show("Đã cập nhật");
                    else
                        MessageBox.Show("Xóa không thành công");
                }    

            }    
           
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            txtMaNcc.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;

        }

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    if(txtMaNcc.Enabled == true) 
        //    {
        //        DataRow insertRow = ds_QLVLXD.Tables["NhaCC"].NewRow();
        //        insertRow["NhaCungCapID"] = txtMaNcc.Text;
        //        insertRow["TenNhaCungCap"] = txtTenNCC.Text;
        //        insertRow["DiaChi"] = txtDiachi.Text;
        //        insertRow["SoDienThoai"] = txtDienthoai.Text;
        //        //Thêm dòng dữ liệu vừa tạo vào dataset
        //        ds_QLVLXD.Tables[0].Rows.Add(insertRow);
        //    }
        //    else
        //    {
              
        //        DataRow update_New = ds_QLVLXD.Tables["NhaCC"].Rows.Find(txtMaNcc.Text);
        //        if(update_New != null)
        //        {
        //            update_New["NhaCungCapID"] = txtMaNcc.Text;
        //            update_New["TenNhaCungCap"] = txtTenNCC.Text;
        //            update_New["DiaChi"] = txtDiachi.Text;
        //            update_New["SoDienThoai"] = txtDienthoai.Text;
        //        }    
        //    }

        //        // Cap nhật trong Csdl
        //        SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
        //        // cập nhật trong dataset
        //        int kq = da_QLVLXD.Update(ds_QLVLXD, "NhaCC");
        //        if (kq != 0)
        //            MessageBox.Show("Đã  cập nhật");
        //        else
        //            MessageBox.Show("Thao tác không thành công");
        //        txtMaNcc.Clear();
        //        txtTenNCC.Clear();
        //        txtDiachi.Clear();
        //        txtDienthoai.Clear();

        //}
    }
}
