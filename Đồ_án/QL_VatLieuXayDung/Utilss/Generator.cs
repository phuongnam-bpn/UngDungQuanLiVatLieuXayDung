using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VatLieuXayDung.Utils
{
    internal class Generator
    {
        public static string ID(string type, string idName, string tableName)
        {
            try
            {
                QL_VatLieuXayDung.Utils.Database database = new QL_VatLieuXayDung.Utils.Database();

                string query = $"SELECT MAX({idName}) FROM {tableName}";

                DataTable dt = database.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    string maxID = dt.Rows[0][0].ToString();
                    int numericPart = 0;

                    // Lấy phần số từ MaKhachHang lớn nhất
                    if (int.TryParse(maxID.Substring(2), out numericPart))
                    {
                        numericPart++; // Tăng giá trị số lên 1 để tạo mã mới
                        string newID = type + numericPart.ToString("D3"); // Định dạng mã mới (ví dụ: KH001)

                        return newID;
                    }
                }

                // Nếu không có dữ liệu trong bảng KhachHang hoặc có lỗi xảy ra, trả về mã mặc định
                return type + "001"; // VD: "KH" + "001" -> "KH001"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return "";
            }
        }
    }
}
