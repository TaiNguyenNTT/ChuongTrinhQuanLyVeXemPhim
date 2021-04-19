using System;
using GUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1_TestLogin
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest1_TestLogin
        {
            // Kiem tra tai khoan, mat khau co tra ve dung dong du lieu trong bang TaiKhoan hay khong.
            // neu co thi cho dang nhap => testcase tra ve true
            int Check_userName__passWord, Check__noUserName_passWord, Check_UserName_noPassWord, Check_noUserName_noPassword, Check_Caps;
            [TestInitialize]
            public void SetUp()
            {
                Check_userName__passWord = TestLogin.CheckLogin("admin", "admin");
                Check__noUserName_passWord = TestLogin.CheckLogin("", "admin");
                Check_UserName_noPassWord = TestLogin.CheckLogin("admin", "");
                Check_noUserName_noPassword = TestLogin.CheckLogin("", "");
                Check_Caps = TestLogin.CheckLogin("ADMIN", "ADMIN");
            }

            [TestMethod]
            public void testCaseLogin_userName_passWord()
            {
                Assert.AreEqual(Check_userName__passWord, 1); // Dung
            }

            [TestMethod]
            public void testCaseLogin_noUserName_passWord()
            {
                Assert.AreEqual(Check__noUserName_passWord, 0); // Sai
            }

            [TestMethod]
            public void testCaseLogin_UserName_noPassWord()
            {
                Assert.AreEqual(Check_UserName_noPassWord, 0); // Sai
            }

            [TestMethod]
            public void testCaseLogin_noUserName_noPassword()
            {
                Assert.AreEqual(Check_noUserName_noPassword, 0); // Sai
            }

            [TestMethod]
            public void testCase_Login_Caps()
            {
                Assert.AreEqual(Check_Caps, 0); // Sai
            }
        }
    }
}
