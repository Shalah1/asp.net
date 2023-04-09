using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo : IRepository<Order, int>
    {
        finalproEntities1 db;
        public OrderRepo(finalproEntities1 db)
        {
            this.db = db;
        }
        public void ADD(Order e)
        {
            db.Orders.Add(e);
            db.SaveChanges();

            var counts = db.Carts.Where(em => em.CId == e.CId).Count();

            for (int i = 0; i < counts; i++)
            {
                var cart = (from s in db.Carts
                            where s.CId == e.CId
                            select s).FirstOrDefault();

                var orderdetails = new OrderDetail();
                orderdetails.CId = cart.CId;
                orderdetails.PId = cart.PId;
                orderdetails.PQuantity = cart.PQuantity;
                orderdetails.OId = e.OId;

                db.OrderDetails.Add(orderdetails);
                db.SaveChanges();

                db.Carts.Remove(cart);
                db.SaveChanges();
            }

        }
        int x = 8;
        public void Delete(int id)
        {
            var emp = db.Orders.FirstOrDefault(e => e.OId == id);
            db.Orders.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Order e)
        {
            var emp = db.Orders.FirstOrDefault(em => em.OId == e.OId);
            db.Entry(emp).CurrentValues.SetValues(e);
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

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(e => e.OId == id);
        }

        public List<Order> GetAll()
        {
            // return db.Orders.ToList();
            return db.Orders.Where(e => e.CId == x).ToList();
        }

        public List<Order> Gets(int id)
        {
            return db.Orders.Where(e => e.OId == id).ToList();
        }

        public List<Order> Getorder(int id)
        {
            // return db.Orders.FirstOrDefault(e => e.CId == id);
            return db.Orders.Where(e => e.CId == id).ToList();

        }

    }
}
