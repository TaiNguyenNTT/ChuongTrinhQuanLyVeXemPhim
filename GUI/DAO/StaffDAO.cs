using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class StaffDAO
    {
        QLRPDataContext db = new QLRPDataContext();
		public static Staff GetStaffByID(string id)
		{
			Staff staff = null;
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.NhanVien WHERE id = '" + id + "'");
			foreach (DataRow item in data.Rows)
			{
				staff = new Staff(item);
				return staff;
			}
			return staff;
		}

		public static List<Staff> GetStaff()
		{
			List<Staff> staffList = new List<Staff>();
			DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.NhanVien");
			foreach (DataRow item in data.Rows)
			{
				Staff staff = new Staff(item);
				staffList.Add(staff);
			}
			return staffList;
		}

        public static DataTable GetListStaff()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetStaff");
        }

        public static bool InsertStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertStaff @idStaff , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, cmnd });
            return result > 0;
        }

        public void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(p => p.id.Equals(id));
            nv.HoTen = hoTen;
            nv.NgaySinh = ngaySinh;
            nv.DiaChi = diaChi;
            nv.SDT = sdt;
            nv.CMND = cmnd;
            db.SubmitChanges();
        }

        public static bool DeleteStaff(string id)
        {
            AccountDAO.DeleteAccountByIdStaff(id);
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.NhanVien WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchStaffByName(string name)
        {
            DataTable data = DataProvider.ExecuteQuery("EXEC USP_SearchStaff @hoTen", new object[] { name });
            return data;
        }
    }
}