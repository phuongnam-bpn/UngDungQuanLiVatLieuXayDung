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
    public partial class frmNhapKho : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-5BL858OA\\PHUONGNAM;Initial Catalog=QL_VLXD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;


        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn đóng form nếu người dùng chọn "No"
            }
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Lấy dữ liệu từ bảng PhieuNhapKho theo ngày được chọn
                dataAdapter = new SqlDataAdapter("SELECT * FROM PhieuNhapKho WHERE NgayNhap = @NgayNhap", connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@NgayNhap", selectedDate);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Hiển thị dữ liệu lên dataGridView1
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
