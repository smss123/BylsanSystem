using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XamaDataLayer.SellSystem
{
    public static  class SellStoreCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddSellStore(SellStore tb)
        {
            db = new DbDataContext();
            db.SellStores.InsertOnSubmit(tb);
            db.SubmitChanges();

            return true;
        }





        public static bool EditSellStore(SellStore tb)
        {
            db = new DbDataContext();
            var q = db.SellStores.Where(d => d.ID == tb.ID).SingleOrDefault();
            q.ItemID = tb.ItemID;
            q.Qty = tb.Qty;
            db.SubmitChanges();
            return true;
           
        }



        public static SellStore EditQtyInSellStore(SellStore tb, int xid, int branchid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid&&s.branchID==branchid).SingleOrDefault();
            sll.ItemID = tb.ItemID;
            sll.Qty += tb.Qty;
            sll.branchID = tb.branchID;
            db.SubmitChanges();
            return sll;
        }

        public static SellStore Sales_EditQtyInSellStore(SellStore tb, int xid, int branchid)
        {
            db = new DbDataContext();
            var sll = db.SellStores.Where(s => s.ID == xid && s.branchID==branchid).SingleOrDefault();
            sll.ItemID = tb.ItemID;
            sll.Qty = tb.Qty;
            sll.branchID = tb.branchID;
            db.SubmitChanges();
            return sll;
        }
        public static void DeleteSellStore(int xid,int branchID)
        {
            try
            {
                db = new DbDataContext();
                var sll = db.SellStores.Where(s => s.ID == xid && s.branchID == branchID).SingleOrDefault();
                db.SellStores.DeleteOnSubmit(sll);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
               if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint "))
               {
                   throw new Exception("Can't Delete Because its link on other processes in stock an sales");
               }
            }
        }

        public static List<SellStore> GetAllSellStore(int branch)
        {
            db = new DbDataContext();
            return db.SellStores.Where(p=>p.branchID==branch).ToList();
        }

        public static SellStore GetSellStoreByItemID( int ItmId, int branchID)
        {
            db = new DbDataContext();
            
             var lst = (from i in db.SellStores
                        where i.ItemID == ItmId&&i.branchID==branchID
                        select i).Single();
            return lst;
        }

        public static void EditQty(int productID, int branchID, long editedQty)
        {
            var q = new SellStore();
            try
            {
                db = new DbDataContext();
                 q = db.SellStores.Where(p => p.ItemID == productID && p.branchID == branchID).Take(1).Single();

                int qty = int.Parse( q.Qty.Value.ToString());
                if (editedQty < qty)
                {
                    q.Qty = qty - editedQty;

                }
                else
                {
                    if (MessageBox.Show("Your product not availble in your store\n you want to continue ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        q.Qty = qty - editedQty;

                    }
                }
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw new Exception("Your product not availble in your store");
            }
        }
        public static List <SellStore> GetAllSellStore()
        {
            return db.SellStores.ToList();
        }
    }

       
}


