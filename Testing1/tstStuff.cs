﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStuff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        public void ActivePropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.Active = TestData;
            Assert.AreEqual(aStaff.Active, TestData);
        }
        public void DateCreatedPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.DateCreated = TestData;
            Assert.AreEqual(aStaff.DateCreated, TestData);
            }
        public void EmailPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "ppp@gmail.com"; 
            aStaff.StaffEmail = TestData;
            Assert.AreEqual(aStaff.StaffEmail, TestData);
        }
        public void LoginPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "p21315412";
            aStaff.StaffLogin = TestData;
            Assert.AreEqual(aStaff.StaffLogin, TestData);
        }
        public void PasswordPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            String TestData = "as213as";
            aStaff.StaffPassword = TestData;
            Assert.AreEqual(aStaff.StaffPassword, TestData);
        }
        public void isAdminPropertyOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.StaffIsAdmin = TestData;
            Assert.AreEqual(aStaff.StaffIsAdmin, TestData);
        }

    }

}
