using System;
using GUI;
using GUI.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest2_TestThemKhachHang
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase_ThemKH()
        {
          int result = TestThemKhachHang.check_ThemKhachHang("KH05", "Nguyễn Văn Năm", DateTime.Parse("16/03/1998"), "Đường số 27", "0961227570", 123456789);
          Assert.IsTrue(result > 0, "Thêm thành công");
        }
    }
}
