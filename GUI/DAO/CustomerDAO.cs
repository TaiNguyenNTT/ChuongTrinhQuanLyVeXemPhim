using System;
using System.Data;
using System.Data.Linq;
using System.Linq;

namespace GUI.DAO
{
    public class CustomerDAO
    {
        QLRPDataContext db = new QLRPDataContext();
        public static DataTable GetCustomerMember(string customerID, string name)
        {
            string query = "Select * from KhachHang where id = '" + customerID + "' and HoTen = N'" + name + "'";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetListCustomer()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetCustomer");
        }

        public static bool InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertCustomer @idCus , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, cmnd });
            return result > 0;
        }

        public void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            KhachHang kh = db.KhachHangs.FirstOrDefault(p => p.id.Equals(id));
            kh.HoTen = hoTen;
            kh.NgaySinh = ngaySinh;
            kh.DiaChi = diaChi;
            kh.SDT = sdt;
            kh.CMND = cmnd;
            db.SubmitChanges();
        }
        public static bool DeleteCustomer(string id)
        {
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.KhachHang WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchCustomerByName(string name)
        {
            return DataProvider.ExecuteQuery("EXEC USP_SearchCustomer @hoTen", new object[] { name });
        }
    }
}
