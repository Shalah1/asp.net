using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo : IRepository<Customer, int>
    {
        finalproEntities1 db;
        public CustomerRepo(finalproEntities1 db)
        {
            this.db = db;
        }
        public void ADD(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(e => e.CId == id);
        }

        public void Edit(Customer e)
        {
            var emp = db.Customers.FirstOrDefault(em => em.CId == e.CId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Customers.FirstOrDefault(e => e.CId == id);
            db.Customers.Remove(emp);
            // db.SaveChanges();

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                        validationErrors.Entry.Entity.ToString(),
                        validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public List<Customer> Gets(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Getorder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
