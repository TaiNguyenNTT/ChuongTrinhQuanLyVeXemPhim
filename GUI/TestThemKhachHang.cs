using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.DAO;

namespace GUI
{
    public class TestThemKhachHang
    {
      public static int check_ThemKhachHang(string cusID, string cusName, DateTime cusBirth, string cusAddress, string cusPhone, int cusINumber)
      {
        int i = DataProvider.ExecuteNonQuery("EXEC USP_InsertCustomer @idCus , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber});
            return i;
      }
    }
}
