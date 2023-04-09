using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherRepo : IRepository<Voucher, int>
    {
        finalproEntities1 db;
        public VoucherRepo(finalproEntities1 db)
        {
            this.db = db;
        }
        public void ADD(Voucher e)
        {
            db.Vouchers.Add(e);
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
            var emp = db.Vouchers.FirstOrDefault(e => e.VouId == id);
            db.Vouchers.Remove(emp);
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

        public void Edit(Voucher e)
        {
            var emp = db.Vouchers.FirstOrDefault(em => em.VouId == e.VouId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Voucher Get(int id)
        {
            return db.Vouchers.FirstOrDefault(e => e.VouId == id);
        }

        public List<Voucher> GetAll()
        {
            return db.Vouchers.ToList();
        }

        public List<Voucher> Getorder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Voucher> Gets(int id)
        {
            throw new NotImplementedException();
        }
    }
}
