using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;

namespace UnitTest_TestSuaKhangHang
{

    [TestClass]

    public class UnitTest1
    {
        int Check_SuaKhachHang;
        [TestInitialize]
        public void SetUp()
        {
            Check_SuaKhachHang = TestSuaThongTinKhachHang.Check_SuaThongTinKhachHang("KH01", "Nguyễn Văn Một", DateTime.Parse("16/05/1995"), "Đường 26", "025888888", 456123789);
        }

        [TestMethod]
        public void TestCase_Check_SuaKhachHang_ThanhCong()
        {
            Assert.AreEqual(Check_SuaKhachHang, 1);
        }

    }
}
