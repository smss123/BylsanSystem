﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace XamaDataLayer.BranchCmd
{
    public static class EmployeesCmd
    {
        private static DbDataContext db = new DbDataContext();
        public static bool AddEmployee(Employee tb)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            db.Employees.InsertOnSubmit(tb);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Add  ", "Add Employee ", " Add New Employee's Informations  ");
            return true;
        }
        public static List<Employee> GetAllEmployees()
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var emp = (from m in db.Employees
                       orderby m.Emp_Name ascending
                       select m).ToList();
            return emp;
        }


        public static int GetEmployeeIdByHisName(string nam)
        {
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var emp = db.Employees.Where(m => m.Emp_Name == nam ).SingleOrDefault();
            var xid = 0;
            xid = emp.ID;

            return xid;
        }
        public static bool EditEmployee(Employee tb, int xid)
        {
            db = new DbDataContext();
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
            db = new DbDataContext();
            db.CommandTimeout = 9000;
            var emp = db.Employees.Where(m => m.ID == xid).SingleOrDefault();
            db.Employees.DeleteOnSubmit(emp);
            db.SubmitChanges();
            XamaDataLayer.Security.UserCmd.SaveHistory("Delete  ", "Delte Employee ", " Delete Selected Employee's Informations  ");
        }
    }
}
