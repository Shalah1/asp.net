using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerSearchRepo : SRepository<Customer, string>
    {
        finalproEntities1 db;
        public CustomerSearchRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        /*   public List<Product> Gets(string name)
           {
               return db.Products.Where(e => e.PName.ToLower() == name).ToList();
           }*/

        public List<Customer> Gets(string name)
        {
            return db.Customers.Where(e => e.CName.ToLower().StartsWith(name)).ToList();
        }
    }
}
