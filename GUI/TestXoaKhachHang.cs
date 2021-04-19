using GUI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TestXoaKhachHang
    {
        public static int Check_XoaKhachHang(string cusID)
        {
            int i = DataProvider.ExecuteNonQuery("DELETE dbo.KhachHang WHERE id = '" + cusID + "'");
            return i;
        }
    }
}
