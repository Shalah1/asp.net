using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartRepo : IRepository<Cart, int>
    {

        finalproEntities1 db;
        public CartRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(Cart e)
        {
            db.Carts.Add(e);
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

        public void Delete(int id)
        {
            var emp = db.Carts.FirstOrDefault(e => e.CartId == id);
            db.Carts.Remove(emp);
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

        public void Edit(Cart e)
        {
            var emp = db.Carts.FirstOrDefault(em => em.CartId == e.CartId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Cart Get(int id)
        {
            return db.Carts.FirstOrDefault(e => e.CartId == id);
        }

        public List<Cart> GetAll()
        {
            // return db.Carts.ToList();
            return db.Carts.Where(e => e.CId == 8).ToList();
        }

        public List<Cart> Getorder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cart> Gets(int id)
        {
            return db.Carts.Where(e => e.CId == id).ToList();
        }

    }
}
