using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaDataLayer.BranchCmd
{
    public static class EmployeesCmd
    {

        static DbDataContext db = new DbDataContext();
        public static bool AddEmployee(Employee tb)
        {
            db = new DbDataContext();
            db.Employees.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public static List<Employee> GetAllEmployees()
        {
            db = new DbDataContext();
            var emp = (from m in db.Employees
                       orderby m.Emp_Name ascending
                       select m).ToList();
            return emp;
        }


        public static int GetEmployeeIdByHisName(string nam)
        {
            db = new DbDataContext();
            var emp = db.Employees.Where(m => m.Emp_Name == nam ).SingleOrDefault();
            int xid = 0;
            xid = emp.ID;
            return xid;
        }
        public static Employee EditEmployee(Employee tb, int xid)
        {
            db = new DbDataContext();
            var emp = db.Employees.Where(m => m.ID == xid).SingleOrDefault();
            emp.Emp_Name = tb.Emp_Name;
            emp.PhoneNumber = tb.PhoneNumber;
            emp.HereDate = tb.HereDate;
            emp.Personalty_ID = tb.Personalty_ID;
            emp.Nationalty = tb.Nationalty;
            emp.HomeAddress = tb.HomeAddress;
            emp.CreateDate = tb.CreateDate;
            emp.Job = tb.Job;
            db.SubmitChanges();
            return emp;

        }
        public static void DeleteEmployee(int xid)
        {
           
            db = new DbDataContext();
            var emp = db.Employees.Where(m => m.ID == xid).SingleOrDefault();
            db.Employees.DeleteOnSubmit(emp);
            db.SubmitChanges();
           
        }
    }
}
