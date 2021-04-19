using GUI.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TestLayDuLieuCuaKhachHang
    {

        public static int Check_LayDuLieuKhachHang()
        {
            DataTable data = CustomerDAO.GetListCustomer();
            if (data == null)
                return 0;
            else if (data.Rows.Count > 0)
                return 1;
            return 0;
        }
    }
}
