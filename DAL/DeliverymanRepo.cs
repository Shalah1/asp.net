using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliverymanRepo : IRepository<Deliveryman, int>
    {
        finalproEntities1 db;
        public DeliverymanRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(Deliveryman e)
        {
            db.Deliverymen.Add(e);
            //  db.SaveChanges();

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

        public List<Deliveryman> GetAll()
        {
            return db.Deliverymen.ToList();
        }

        public Deliveryman Get(int id)
        {
            return db.Deliverymen.FirstOrDefault(e => e.DId == id);
        }

        public void Edit(Deliveryman e)
        {
            var emp = db.Deliverymen.FirstOrDefault(em => em.DId == e.DId);
            db.Entry(emp).CurrentValues.SetValues(e);
            //  db.SaveChanges();

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
            var emp = db.Deliverymen.FirstOrDefault(e => e.DId == id);
            db.Deliverymen.Remove(emp);
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

        public List<Deliveryman> Gets(int id)
        {
            throw new NotImplementedException();
        }

        public List<Deliveryman> Getorder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
