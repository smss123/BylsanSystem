using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
    public  class StoreSalesCmd
    {
        static DbDataContext db = new DbDataContext();

        public static bool AddNewSales(Store_Sell tb)
        {
            db = new DbDataContext();
            db.Store_Sells.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add ", " Add sell store ", " Add new sell store    At Main Store ");

            return true;
        }

        public Store_Sell EditStore_Sell(Store_Sell tb, int xid)
        {
            db = new DbDataContext();
            var q = db.Store_Sells .Where(i => i.ID == xid).SingleOrDefault();
            q.UserID = tb.UserID;
            q.Price = tb.Price;
            q.SupplierID = tb.SupplierID;
            q.UnitPrice = tb.UnitPrice;
            q.DateOfProcess = tb.DateOfProcess;
            q.Comment = tb.Comment;
            q.ItemID = tb.ItemID;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit  ", " Edit  sell store ", " Edit selected  sell store    At Main Store ");
            return q;
        }
        public void DeleteStore_SellAt(int xid)
        {
            try
            {

                var q = db.Store_Sells.Where(p => p.ID == xid).SingleOrDefault();
                db.Store_Sells.DeleteOnSubmit(q);
                db.SubmitChanges();
                XamaDataLayer.Security.UserCmd.SaveHistory("Delete ", " Delete sell store ", " Delete selected  sell store  from  Main Store ");

            }
            catch (Exception)
            {
            }
        }


  #region " ^^^    Loading Data   ^^^^ " 

        // == {All }
        public static List<Store_Sell> GetAllSTore_Sell() {
            return db.Store_Sells.ToList();
        }
        // == {By User}
        public static List<Store_Sell> GetAllSTore_SellByUserID( int xid)
        {
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending 
                       where s.UserID == xid
                       select s).ToList();
            return lst;
        }
        // == {By Supplier}
        public static List<Store_Sell> GetAllSTore_SellBySupplierID(int xid)
        {
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending
                       where s.SupplierID  == xid
                       select s).ToList();
            return lst;
        }
   

        // == {By Item }
        public static List<Store_Sell> GetAllSTore_SellByItemID(int xid)
        {
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending
                       where s.ItemID  == xid
                       select s).ToList();
            return lst;
        }
        // == { By: Date}
        public static List<Store_Sell> GetAllSTore_SellByDate(DateTime dat)
        {
            var lst = (from s in db.Store_Sells
                       orderby s.DateOfProcess ascending
                       where s.DateOfProcess == dat 
                       select s).ToList();
            return lst;
        }
 
     #endregion 

    }
}
