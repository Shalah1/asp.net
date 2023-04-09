using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliverymanStatusSearchRepo : SRepository<Deliveryman, string>
    {
        finalproEntities1 db;
        public DeliverymanStatusSearchRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        /*   public List<Product> Gets(string name)
           {
               return db.Products.Where(e => e.PName.ToLower() == name).ToList();
           }*/

        public List<Deliveryman> Gets(string status)
        {
            return db.Deliverymen.Where(e => e.DStatus.ToLower().Contains(status)).ToList();
        }
    }
}
