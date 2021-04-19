using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.DAO;

namespace GUI
{
    public class TestSuaThongTinKhachHang
    {
        public static int Check_SuaThongTinKhachHang(string id, string hoten, DateTime ngsinh, string diachi, string dienthoai, int cmnd)
        {
            CustomerDAO da = new CustomerDAO();
            da.UpdateCustomer(id, hoten, ngsinh, diachi, dienthoai, cmnd);

            string query = "Select * from KhachHang where id = '" + id + "' and HoTen = N'" + hoten + "' and cmnd = N'" + cmnd + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            if (data == null)
                return 0;
            else if (data.Rows.Count > 0)
                return 1;
            return 0;
        }
    }
}
