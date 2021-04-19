using System;
using GUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest3_SearchTenKhachHang
{
    [TestClass]
    public class UnitTest1
    {
        string cusName = "";
        int Check_Search_CoKhachHang, Check_Search_KhongCoKhachHang;
        [TestInitialize]
        public void SetUp()
        {
            cusName = "Nguyễn Văn B";
            Check_Search_CoKhachHang = TestSearchCustomer.Check_SearchCustomers(cusName);
            Check_Search_KhongCoKhachHang = TestSearchCustomer.Check_SearchCustomers("Trần Thị Bành Nguyên");
        }
        [TestMethod]
        public void TestCase_Search_CoKhachHang()
        {
            Assert.AreEqual(Check_Search_CoKhachHang, 1);
        }

        [TestMethod]
        public void TestCase_Search_KhongCoKhachHang()
        {
            Assert.AreEqual(Check_Search_KhongCoKhachHang, 0);
        }
    }
}
