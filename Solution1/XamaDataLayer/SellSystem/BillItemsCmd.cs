﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.SellSystem
{
   public static  class BillItemsCmd
    {
       static DbDataContext db = new DbDataContext();
       public static bool AddBillItmes(BillItem tb)
       {
           db = new DbDataContext();
           db.BillItems.InsertOnSubmit(tb);
           db.SubmitChanges();
           return true;
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="tb"> أدخل أسم الجدول يا محمد</param>
       /// <param name="xid">أدخل رقم السجل</param>
       /// <param name="bllId">أدخل رقم سجل الفاتورة </param>
       /// <returns></returns>
       public static BillItem EditBillItems(BillItem tb, int xid, int bllId)
       {
           db = new DbDataContext();
           var bl = db.BillItems.Where(b => b.ID == xid && b.Bill_ID == bllId).SingleOrDefault();
           bl.Bill_ID = tb.Bill_ID;
           bl.ItemID = tb.ItemID;
           bl.Qty = tb.Qty;
           db.SubmitChanges();
           return bl;
       }

       public static void DeleteAt(int xid)
       {
           try
           {
           db = new DbDataContext();
           var bl = db.BillItems.Where(b => b.ID == xid ).SingleOrDefault();
           db.BillItems.DeleteOnSubmit(bl);
           db.SubmitChanges();
          
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public static List<BillItem> LoadAllBillItemsByBill_ID(int BLLId){

           db = new DbDataContext();
           var lst = (from i in db.BillItems
                      orderby i.ItemID ascending
                      where i.Bill_ID == BLLId
                      select i).ToList();
           return lst;
      

       }
    }
}
