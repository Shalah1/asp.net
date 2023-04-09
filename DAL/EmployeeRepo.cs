using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo : IRepository<Employee, int>
    {
        finalproEntities1 db;
        public EmployeeRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.FirstOrDefault(e => e.EId == id);
        }

        public void Edit(Employee e)
        {
            var emp = db.Employees.FirstOrDefault(em => em.EId == e.EId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Employees.FirstOrDefault(e => e.EId == id);
            db.Employees.Remove(emp);
            db.SaveChanges();
        }

        public List<Employee> Gets(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Getorder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
