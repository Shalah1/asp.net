using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliverRepo : IRepository<Deliveryman, int>
    {
        finalproEntities1 db;
        public DeliverRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(Deliveryman e)
        {
            db.Deliverymen.Add(e);
            db.SaveChanges();
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
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Deliverymen.FirstOrDefault(e => e.DId == id);
            db.Deliverymen.Remove(emp);
            db.SaveChanges();
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
