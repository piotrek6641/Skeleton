﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;


namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

       
        
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            TestSupplier.InStock = true;
            TestSupplier.PhoneNo = "+44 1111111111";
            TestSupplier.StockAmount = 100;
            TestSupplier.SupplierEmail = "new@new.com";
            TestSupplier.Address = "1 new street";
            TestSupplier.DeliveryDate = DateTime.Now.Date;
            TestSupplier.SupplierID = 1;

            AllSupplier.ThisSupplier = TestSupplier;

            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddmethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;

            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "newer@newer.com";
            TestItem.Address = "11 newer street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 7;

            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void DeletemethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.PhoneNo = "+44 1111111111";
            TestItem.StockAmount = 100;
            TestItem.SupplierEmail = "new@new.com";
            TestItem.Address = "1 new street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;

            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            AllSuppliers.Delete();


            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);


            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPhoneNoMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            FilteredSuppliers.ReportByPhoneNo("");

            Assert.AreEqual(AllSupplier.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNoNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            FilteredSuppliers.ReportByPhoneNo("456");

            Assert.AreEqual(4, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNoTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportByPhoneNo("444");
            if(FilteredSuppliers.Count == 2)
            {
                if(FilteredSuppliers.SupplierList[0].SupplierID != 36)
                {
                    OK = false;
                }
                if(FilteredSuppliers.SupplierList[1].SupplierID != 37)
                {
                    OK = fasle;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
