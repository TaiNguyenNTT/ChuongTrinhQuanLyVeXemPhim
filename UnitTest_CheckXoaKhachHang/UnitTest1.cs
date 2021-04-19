using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;

namespace UnitTest_CheckXoaKhachHang
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCase_XoaKhachHang()
        {
            int result = TestXoaKhachHang.Check_XoaKhachHang("KH05");
            Assert.IsTrue(result > 0, "Xóa thành công");
        }
    }
}
