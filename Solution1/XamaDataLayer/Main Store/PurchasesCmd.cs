using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.Main_Store
{
    public class PurchasesCmd:ApiCounter
    {
     
        public static bool NewPurchases(Purchase p)
        {
            p.dateOfProcess = DateTime.Now;
            p.SerialNumber = Guid.NewGuid();
            db.Purchases.InsertOnSubmit(p);
            var q = new Store();
            try
            {
                 q = db.Stores.Where(str => str.ProductID == p.ProductID).Take(1).Single();
                 q.AvailableQty = (long)q.AvailableQty + long.Parse(p.Qty);
               
            }
            catch (Exception)
            {

                q = new Store() { ProductID = p.ProductID, AvailableQty = 0, ExpiredDate = null };
                q.AvailableQty = (long)q.AvailableQty + long.Parse(p.Qty);

                db.Stores.InsertOnSubmit(q);

               
            }
            Expenss saleSide = new Expenss();
            var saleAccount = db.Expensses.Where(acc => acc.ExpenssesName.Contains("حساب المشتريات"));
            if (saleAccount==null)
            {
                saleSide = new Expenss() { ExpenssesName = "حساب المشتريات", Description= "حساب خاص بالمشتريات عموما"};
                saleSide.Account.AccountDailies.Add(new AccountDaily()
                {
                    DateOfProcess = DateTime.Now,
                    Description = "عبارة عن عملية تكلفة شراء اشياء وتم تخزينها في المخزن",
                    TotalOut = p.CostAmount,
                    TotalIn = 0,
                });
                saleSide.ExpenssesMovments.Add(new ExpenssesMovment() { 
                 DateOfProcess=DateTime.Now,
                  Amount = p.CostAmount,
                   Description= "عبارة عن تكلفة شراء منتجات للمخزن"
                
                });
                db.Expensses.InsertOnSubmit(saleSide);

            }
            else
            {
                saleSide = saleAccount.ToList()[0];
                saleSide.Account.AccountDailies.Add(new AccountDaily()
                {
                    DateOfProcess = DateTime.Now,
                    Description = "عبارة عن عملية تكلفة شراء اشياء وتم تخزينها في المخزن",
                    TotalOut = p.CostAmount,
                    TotalIn = 0,
                });
                saleSide.ExpenssesMovments.Add(new ExpenssesMovment()
                {
                    DateOfProcess = DateTime.Now,
                    Amount = p.CostAmount,
                    Description = "عبارة عن تكلفة شراء منتجات للمخزن"

                });
               

            }
            
            db.SubmitChanges();
            return true;
        }

        public static bool EditPurchases(Purchase p)
        {
            var q = db.Purchases.Where(px => px.ID == p.ID).Take(1).Single();
            q.AccountID = p.AccountID;
            q.CostAmount = p.CostAmount;
            q.ProductID = p.ProductID;
            q.Qty = p.Qty;
            q.SupplierID = p.SupplierID;
            db.SubmitChanges();
            return true;
        }
        public static bool DeletePurchases(int iD)
        {
            var q = db.Purchases.Where(px => px.ID ==  iD).Take(1).Single();
            db.Purchases.DeleteOnSubmit(q);
            db.SubmitChanges();
            return true;
           
        }

        public static List<Purchase> GetAll()
        {
            db = new DbDataContext();
            return db.Purchases.ToList();
        }
    }
}
