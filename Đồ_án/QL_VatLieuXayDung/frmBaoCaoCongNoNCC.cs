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
    public partial class frmBaoCaoCongNoNCC : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True");
        SqlDataAdapter da_QLVLXD;
        DataSet ds_QLVLXD;
        DataColumn[] key = new DataColumn[1];
        public frmBaoCaoCongNoNCC()
        {
            InitializeComponent();
            try
            {
                //string strSelect = "select MaPhieuChi, NgayChi, NhaCungCapID, SoTienChi from PhieuChi";
                string strSelect = "select bc.*, nk.NgayNhap from BaoCaoCongNoNhaCungCap bc , PhieuNhapKho nk where bc.NhaCungCapID = nk.NhaCungCapID";
                da_QLVLXD = new SqlDataAdapter(strSelect, conn);
                ds_QLVLXD = new DataSet();
                da_QLVLXD.Fill(ds_QLVLXD, "BaoCao");
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
            cboMaNCC.DataSource = ds.Tables[0];
            cboMaNCC.DisplayMember = "TenNhaCungCap";
            cboMaNCC.ValueMember = "NhaCungCapID";

        }
        public void load_dgvBaoBaoCongNoNCC()
        {
            dgvBaoCaoCongNoNCC.DataSource = ds_QLVLXD.Tables["BaoCao"];

            foreach (DataGridViewColumn column in dgvBaoCaoCongNoNCC.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void frmBaoCaoCongNoNCC_Load(object sender, EventArgs e)
        {
            load_dgvBaoBaoCongNoNCC();
            string defaul = "Nhà cung cấp";
            cboMaNCC.Text = defaul;
            cboMaNCC.SelectedIndexChanged += cboMaNCC_SelectedIndexChanged;
            tinhTongTien();
        }


        private void LoadDataByNgayThang(DateTime tuNgay, DateTime denNgay)
        {

            string queryString = "select bc.*, nk.NgayNhap from BaoCaoCongNoNhaCungCap bc , PhieuNhapKho nk where bc.NhaCungCapID = nk.NhaCungCapID and (NgayNhap between @tuNgay and @denNgay)";

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True"))
            {
                conn.Open();


                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    command.Parameters.AddWithValue("@tuNgay", tuNgay);
                    command.Parameters.AddWithValue("@denNgay", denNgay);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvBaoCaoCongNoNCC.DataSource = dataTable;
                }
                tinhTongTien();
            }


        }




        private void LoadDataByMaCC(string maNCC)
        {
            string queryString = "select bc.*, nk.NgayNhap from BaoCaoCongNoNhaCungCap bc , PhieuNhapKho nk where bc.NhaCungCapID = nk.NhaCungCapID and bc.NhaCungCapID = @maNCC";
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    command.Parameters.AddWithValue("@maNCC", maNCC);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvBaoCaoCongNoNCC.DataSource = dataTable;
                }

                tinhTongTien();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (radThongKeTheoNgay.Checked)
            {
                LoadDataByNgayThang(dtpTuNgay.Value, dtpDenNgay.Value);
            }
        }
        public void tinhTongTien()
        {
            int tongTienPhaiTra = 0;
            int tongTienDaTra = 0;
            int tongTienConLai = 0;
            foreach (DataGridViewRow row in dgvBaoCaoCongNoNCC.Rows)
            {
                if (row.Cells["TongChi"].Value != null && row.Cells["TongNhap"].Value != null && row.Cells["CongNo"].Value != null)
                {
                    if (int.TryParse(row.Cells["TongChi"].Value.ToString(), out int tongTienPT) &&
                        int.TryParse(row.Cells["TongNhap"].Value.ToString(), out int tongTienDT) &&
                        int.TryParse(row.Cells["CongNo"].Value.ToString(), out int tongTienCL))
                    {
                        tongTienPhaiTra += tongTienPT;
                        tongTienDaTra += tongTienDT;
                        tongTienConLai = tongTienPhaiTra - tongTienDaTra;
                    }
                    else
                    {
                        MessageBox.Show("Chuyển đổi không thành công");
                    }
                }
                txtTongTienDaTra.Text = "Tổng tiền phải trả: " + tongTienDaTra.ToString();
                txtTongTienPhaiTra.Text = "Tổng tiền đã trả: " + tongTienPhaiTra.ToString();
                txtTongTienConLai.Text = "Tổng tiền còn lại " + tongTienConLai.ToString();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_dgvBaoBaoCongNoNCC();
            frmBaoCaoCongNoNCC_Load(sender, e);
            string defaul = "Nhà cung cấp";
            cboMaNCC.Text = defaul;
          
            tinhTongTien();
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = cboMaNCC.SelectedItem;
            string maNCC = ((DataRowView)selectedItem)["NhaCungCapID"].ToString();
            LoadDataByMaCC(maNCC);

        }
    }
}
