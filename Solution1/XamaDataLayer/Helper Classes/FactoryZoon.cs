﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace XamaDataLayer.Helper_Classes
{
    public  class FactoryZoon  : IDisposable 
    {
        static DbDataContext db = new DbDataContext();

    public List<OrderProduct> GetAllInDesigner(){

              var lst = ( from c in db.OrderProducts 
                             where c.Status == "In Designer" 
                             select c).ToList ();            
              return lst ;
         
        
        }


    public List<OrderProduct> GetAllInProducting() {

        var lst = (from c in db.OrderProducts
                   where c.Status == "In Producting"
                   select c).ToList();
        return lst; 
    }


    public  List<OrderProduct> GetAllToDeliver()
    {

        var lst = (from c in db.OrderProducts
                   where c.Status == "To Deliver"
                   select c).ToList();
        return lst;
    }






    public void Dispose()
    {
        this.MemberwiseClone();
        GC.SuppressFinalize(this);
    }
    }
}