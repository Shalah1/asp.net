using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderSearchRepo : SRepository<Order, string>
    {

        finalproEntities1 db;
        public OrderSearchRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        /*   public List<Product> Gets(string name)
           {
               return db.Products.Where(e => e.PName.ToLower() == name).ToList();
           }*/

        public List<Order> Gets(string name)
        {

            return db.Orders.Where(e => e.OrderStatus.ToLower().Contains(name)).ToList();

        }
    }
}
