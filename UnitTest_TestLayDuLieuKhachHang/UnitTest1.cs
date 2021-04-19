using System;
using GUI;
using GUI.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_TestLayDuLieuKhachHang
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCase_LayDuLieuKhachHang()
        {
            Assert.AreEqual(TestLayDuLieuCuaKhachHang.Check_LayDuLieuKhachHang(), 1);
        }
    }
}
