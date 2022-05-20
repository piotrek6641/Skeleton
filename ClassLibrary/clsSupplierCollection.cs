﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAl");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnSupplier.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                AnSupplier.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);

                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@PhoneNo", mThisSupplier.PhoneNo);
            DB.AddParameter("@StockAmount", mThisSupplier.StockAmount);
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@InStock", mThisSupplier.InStock);

            return DB.Execute("sproc_tblSupplier_Insert");
        }
    }
}