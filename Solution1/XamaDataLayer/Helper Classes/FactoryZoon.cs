using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace XamaDataLayer.Helper_Classes
{
    public  class FactoryZoon  : IDisposable
    {
        private static DbDataContext db = new DbDataContext();
        ~FactoryZoon()
        {
            GC.Collect();
            Application.DoEvents();
            Debug.Write(this);
        }



        public  List<Order> GetAllOrdersInDesigner()
        {
            db = new DbDataContext();
            var Lst = (from o in db.Orders
                   orderby o.OrderDate ascending
                   where
                       o.OrderStatus == "In Designer"
                   select o).ToList();
            return Lst;
        }

        public List<Order> GetAllInProducting()
        {
            db = new DbDataContext();
            var Lst = (from o in db.Orders
                   orderby o.OrderDate ascending
                   where
                       o.OrderStatus == "in producting "
                   select o).ToList();
            return Lst;
        }


        public  List<Order> GetAllToDeliver()
        {
            db = new DbDataContext();
            var Lst = (from o in db.Orders
                   orderby o.OrderDate ascending
                   where
                       o.OrderStatus == "To Deliver"
                   select o).ToList();
            return Lst;
        }






        public void Dispose()
        {
            MemberwiseClone();
            GC.SuppressFinalize(this);
        }
    }
}
