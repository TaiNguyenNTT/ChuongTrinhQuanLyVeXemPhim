using GUI.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TestSearchCustomer
    {
        public static int Check_SearchCustomers(string cusName)
        {
          DataTable data = CustomerDAO.SearchCustomerByName(cusName);
            if (data.Rows.Count > 0)
                return 1; // search co khach hang trong bang
            return 0;
        }
    }
}
