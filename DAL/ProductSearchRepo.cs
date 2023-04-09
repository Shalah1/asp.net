using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductSearchRepo : SRepository<Product, string>
    {
        finalproEntities1 db;
        public ProductSearchRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        /*   public List<Product> Gets(string name)
           {
               return db.Products.Where(e => e.PName.ToLower() == name).ToList();
           }*/

        public List<Product> Gets(string name)
        {
            return db.Products.Where(e => e.PName.ToLower().StartsWith(name)).ToList();
        }

    }
}
