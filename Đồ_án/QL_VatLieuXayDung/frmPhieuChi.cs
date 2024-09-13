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
    public partial class frmPhieuChi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True");
        SqlDataAdapter da_QLVLXD;
        DataSet ds_QLVLXD;
        DataColumn[] key = new DataColumn[1];
        // Dữ liệu gốc
        DataTable originalData;
        public frmPhieuChi()
        {
            InitializeComponent();
            try
            {
                //string strSelect = "select MaPhieuChi, NgayChi, NhaCungCapID, SoTienChi from PhieuChi";
                string strSelect = "select * from PhieuChi";
                da_QLVLXD = new SqlDataAdapter(strSelect, conn);
                ds_QLVLXD = new DataSet();
                da_QLVLXD.Fill(ds_QLVLXD, "PC");

                //thêm khóa chính
                key[0] = ds_QLVLXD.Tables["PC"].Columns[0];
                ds_QLVLXD.Tables["PC"].PrimaryKey = key;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Load_ComboBox_MaNCC();

        }
        public void Load_ComboBox_MaNCC()
        {
            DataSet ds = new DataSet();
            string strSelect = "Select * from NhaCungCap";
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn);
            da.Fill(ds, "NCC");
            cboNhaCungCap.DataSource = ds.Tables[0];
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "NhaCungCapID";

        }

       
        public void load_Grid1()
        {
            dgvPhieuChiMoi.DataSource = ds_QLVLXD.Tables["PC"];

            foreach (DataGridViewColumn column in dgvPhieuChiMoi.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void CloseForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                   
                    form.Close();
                    return;
                }
            }
            MessageBox.Show("Form không tìm thấy.");
        }

       
     

        private void LoadDataByMaPhieuNhap(string maPhieuNhap)
        {
            // Chuỗi truy vấn để lấy dữ liệu từ cơ sở dữ liệu dựa trên mã phiếu nhập
            string queryString = "select * from PhieuChi where MaPhieuChi = @maPhieuNhap";
            // Mở kết nối
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True"))
            {
                conn.Open();

                // Thực hiện truy vấn và lấy dữ liệu
                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    // Thêm tham số cho mã phiếu nhập
                    command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);

                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trong DataGridView
                    dgvPhieuChiMoi.DataSource = dataTable;
                }
            }
        }

        private void LoadDataByMaCC(string maNhaCC)
        {
            // Chuỗi truy vấn để lấy dữ liệu từ cơ sở dữ liệu dựa trên mã phiếu nhập
            string queryString1 = "select * from PhieuChi where NhaCungCapID = @maNhaCC";
            // Mở kết nối
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True"))
            {
                conn.Open();

                // Thực hiện truy vấn và lấy dữ liệu
                using (SqlCommand command = new SqlCommand(queryString1, conn))
                {
                    // Thêm tham số cho mã phiếu nhập
                    command.Parameters.AddWithValue("@maNhaCC", maNhaCC);

                    // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);

                    // Hiển thị dữ liệu trong DataGridView
                    dgvPhieuChiMoi.DataSource = dataTable1;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }























        private void frmPhieuChi_Load_1(object sender, EventArgs e)
        {
            txtMaPhieuChi.Enabled = true;
            cboNhaCungCap.Enabled = true;
            txtTienChi.Enabled = true;
            dtpNgayChi.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtTimTheoMaNCC.Enabled = false;
            txtTimTheoMaPhieu.Enabled = false;


            try
            {
                load_Grid1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaPhieuChi.Enabled = true;
            cboNhaCungCap.Enabled = true;
            txtTienChi.Enabled = true;
            dtpNgayChi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaPhieuChi.Focus();

            dtpNgayChi.Value = DateTime.Today;

            string tienChi = txtTienChi.Text;
            int soTienChi = Convert.ToInt32(tienChi);
            DataRow insertRow = ds_QLVLXD.Tables["PC"].NewRow();
            insertRow["MaPhieuChi"] = txtMaPhieuChi.Text;
            insertRow["NgayChi"] = dtpNgayChi.Text;
            insertRow["NhaCungCapID"] = cboNhaCungCap.SelectedValue;
            insertRow["SoTienChi"] = soTienChi;


            //Thêm dòng dữ liệu vừa tạo vào dataset
            ds_QLVLXD.Tables[0].Rows.Add(insertRow);
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);

            // cập nhật trong dataset
            int kq = da_QLVLXD.Update(ds_QLVLXD, "PC");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");
            txtMaPhieuChi.Clear();
            txtTienChi.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            dtpNgayChi.Value = DateTime.Today;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                DataRow upd_new = ds_QLVLXD.Tables["PC"].Rows.Find(txtMaPhieuChi.Text);
                if (upd_new != null)
                {
                    upd_new.Delete();
                }
                // Cap nhật trong Csdl
                SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
                // cập nhật trong dataset
                int kq = da_QLVLXD.Update(ds_QLVLXD, "PC");
                if (kq != 0)
                    MessageBox.Show("Đã cập nhật");
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }

        private void dgvPhieuChiMoi_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnThoat.Enabled = true;
            txtMaPhieuChi.Enabled = true;
            txtTienChi.Enabled = true;
            DataRow dr = ds_QLVLXD.Tables[0].Rows.Find(txtMaPhieuChi.Text);
            if (dr != null)
            {

                dr["NgayChi"] = dtpNgayChi.Text;
                dr["NhaCungCapID"] = cboNhaCungCap.SelectedValue;
                dr["SoTienChi"] = int.Parse(txtTienChi.Text);

            }
            // Cap nhật trong Csdl
            SqlCommandBuilder cB = new SqlCommandBuilder(da_QLVLXD);
            // cập nhật trong dataset
            int kq = da_QLVLXD.Update(ds_QLVLXD, "PC");
            if (kq != 0)
                MessageBox.Show("Đã  cập nhật");
            else
                MessageBox.Show("Thao tác không thành công");
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaPhieuChi.Clear();
            dtpNgayChi.Value = DateTime.Now;
            cboNhaCungCap.SelectedIndex = -1;
            txtTienChi.Clear();
            dgvPhieuChiMoi.DataSource = originalData;
            load_Grid1();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (radTimTheoMaPhieu.Checked)
            {

                if (txtTimTheoMaPhieu.Text != null)
                {
                    LoadDataByMaPhieuNhap(txtTimTheoMaPhieu.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }
            if (radTimTheoMaNCC.Checked)
            {
                if (txtTimTheoMaNCC.Text != null)
                {
                    LoadDataByMaCC(txtTimTheoMaNCC.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }
        }

        private void radTimTheoMaPhieu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTimTheoMaPhieu.Checked)
            {
                txtTimTheoMaPhieu.Enabled = true;
            }
            else
            {
                txtTimTheoMaPhieu.Enabled = false;
            }
        }

        private void radTimTheoMaNCC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTimTheoMaNCC.Checked)
            {
                txtTimTheoMaNCC.Enabled = true;
            }
            else
            {
                txtTimTheoMaNCC.Enabled = false;
            }
        }

        private void frmPhieuChi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

