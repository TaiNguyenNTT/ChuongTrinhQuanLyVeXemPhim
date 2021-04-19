using GUI.DAO;
using GUI;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TestLogin
    {
        // Kiem tra tai khoan, mat khau co tra ve dung dong du lieu trong bang TaiKhoan hay khong.
        // neu co thi cho dang nhap => testcase tra ve true
        public static int Login(string userName, string passWord)
        {
            string pass = AccountDAO.PasswordEncryption(passWord);
            string query = "USP_Login @userName , @passWord";
            DataTable data = DataProvider.ExecuteQuery(query, new object[] { userName, pass });

            if (data == null)
                return -1;
            else if (data.Rows.Count > 0)
                return 1;
            else
                return 0;
        }

        public static int CheckLogin(string UserName, string PassWord)
        {
            int result = Login(UserName, PassWord);
            if (result == 1)
            {
                return 1;     // Dung
            }
            else return 0;   // Sai
        }
    }
      
}
