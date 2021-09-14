using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource
{
    class DataAccess
    {
        HumanResourceEntities hrm = new HumanResourceEntities();
        public bool isValid(string usid, string pswd)
        {
            var res = from obj in hrm.Logins where obj.UserName == usid select obj;
            if (!res.Any())
                return false;
            foreach (var r in res)
            {
                if (r.Password != pswd)
                    return false;
            }
            return true;
        }
        public bool IsEmpValid(int eid)
        {
            var r = from ob in hrm.Employees where ob.EmpId == eid select ob;
            if (!r.Any())
                return false;
            return true;
        }
        public void AddBonus(int eid, double Bonus, System.DateTime BDate)
        {
            Bonu bn = new Bonu();
            bn.BonusAmount = Bonus;
            bn.Date = BDate;
            bn.EmpId = eid;
            hrm.Bonus.Add(bn);
            hrm.SaveChanges();
        }
        public void AddHist(int eid, string Company, System.DateTime Start, System.DateTime End)
        {
            EmpHistory eh = new EmpHistory();
            eh.EmpId = eid;
            eh.StartDate = Start;
            eh.EndDate = End;
            eh.CompanyName = Company;
            hrm.EmpHistories.Add(eh);
            hrm.SaveChanges();
        }
        public void Add(string name, string dname, double Salary, string Grade, string Manager, string Company, System.DateTime Start,
            System.DateTime End, double Bonus, System.DateTime BDate)
        {
            Employee em = new Employee();
            var k = (from o in hrm.Departments where o.DeptName == dname select o).FirstOrDefault();
            em.DeptNo = k.DeptNo;
            //em.EmployeeID = EmployeeID;
            em.Name = name;
            em.Salary = Salary;
            em.Grade = Grade;
            em.ManagerName = Manager;
            hrm.Employees.Add(em);
            Bonu bn = new Bonu();
            bn.BonusAmount = Bonus;
            bn.Date = BDate;
            bn.EmpId = em.EmpId;
            hrm.Bonus.Add(bn);
            EmpHistory eh = new EmpHistory();
            eh.EmpId = em.EmpId;
            eh.StartDate = Start;
            eh.EndDate = End;
            eh.CompanyName = Company;
            hrm.EmpHistories.Add(eh);
            hrm.SaveChanges();
        }
        public void Delete(int id)
        {
            var res = (from obj in hrm.Employees where obj.EmpId == id select obj).FirstOrDefault();
            hrm.Employees.Remove(res);
            var resh = from obj in hrm.EmpHistories where obj.EmpId == id select obj;
            foreach (var r in resh)
                hrm.EmpHistories.Remove(r);
            var resn = from obj in hrm.Bonus where obj.EmpId == id select obj;
            foreach (var r in resn)
                hrm.Bonus.Remove(r);
            hrm.SaveChanges();
        }
        public List<Full> Display()
        {
            List<Full> ls = new List<Full>();
            foreach (var r in hrm.Employees)
            {
                Full f = new Full();
                f.EmployeeID = r.EmpId;
                f.Name = r.Name;
                f.DeptNo = r.DeptNo;
                f.Salary = r.Salary;
                f.Grade = r.Grade;
                f.ManagerName = r.ManagerName;
                ls.Add(f);
            }
            return ls;
        }
    }
    class Full
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int DeptNo { get; set; }
        public double Salary { get; set; }
        public string Grade { get; set; }
        public string ManagerName { get; set; }
    }
}
