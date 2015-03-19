using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public   class EmployeesCmd:ApiCounter
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddEmployee(Employee tb)
        {
            tb.ID = GetNumber();
            db.CommandTimeout = 9000;
            db.Employees.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Employee ", " Add New Employee's Informations  ");
            return true;
        }
        public static List<Employee> GetAllEmployees()
        {
            var com = CompiledQuery.Compile(
              (DbDataContext dbx) =>
             (from m in dbx.Employees
                                    orderby m.Emp_Name ascending
                                    select m).ToList()
                                         );
            db.CommandTimeout = 9000;
            return com(db);
        }


    
        public static bool EditEmployee(Employee tb, int xid)
        {
             
            db.CommandTimeout = 9000;
            var emp = db.Employees.Where(m => m.ID == xid).SingleOrDefault();
            emp.Emp_Name = tb.Emp_Name;
            emp.PhoneNumber = tb.PhoneNumber;
            emp.HereDate = tb.HereDate;
            emp.Personalty_ID = tb.Personalty_ID;
            emp.Nationalty = tb.Nationalty;
            emp.HomeAddress = tb.HomeAddress;

            emp.Job = tb.Job;
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Edit   ", "Edit Employee ", " Edit Selected  Employee's Informations  ");

            return true;
        }
        public static void DeleteEmployee(int xid)
        {
            
            db.CommandTimeout = 9000;
            var emp = db.Employees.Where(m => m.ID == xid).SingleOrDefault();
            db.Employees.DeleteOnSubmit(emp);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delte Employee ", " Delete Selected Employee's Informations  ");
        }
    }
}
