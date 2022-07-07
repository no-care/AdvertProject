using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUser()
        {
            Class1 test = new Class1();
            string addedUser = test.AddUser("nocare", "evstafyev02", "2135");
            string log = "nocare";
            Assert.AreEqual(addedUser, log);
        }
        [TestMethod]
        public void DeleteUser()
        {
            Class1 test = new Class1();
            bool remove_user = test.DeleteUser(11);
            bool deletedUser = true;
            Assert.AreEqual(remove_user,deletedUser);
        }

        [TestMethod]
        public void EditUser() 
        {
            Class1 test = new Class1();
            string edit_habit = test.EditUser("mixerlone", "evstafyev02@gmial.com", "qwe", 3);
            string title = "mixerlone";
            Assert.AreEqual(edit_habit, title);
        }

        [TestMethod]
        public void AddAdvert()
        {
            Class1 test = new Class1();
            string addedAdvert = test.addAdvert("qwe", "qwe", "qwe", "qwe",7);
            string title = "qwe";
            Assert.AreEqual(addedAdvert, title);
        }
        [TestMethod]
        public void DeleteAdvert()
        {
            Class1 test = new Class1();
            bool remove_advert = test.deleteAdvert(7);
            bool deletedAdvert= true;
            Assert.AreEqual(remove_advert, deletedAdvert);
        }

    }
}
