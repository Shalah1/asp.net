using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherSearchRepo : SRepository<Voucher, string>
    {
        finalproEntities1 db;
        public VoucherSearchRepo(finalproEntities1 db)
    {
        this.db = db;
    }

    /*   public List<Product> Gets(string name)
       {
           return db.Products.Where(e => e.PName.ToLower() == name).ToList();
       }*/

    public List<Voucher> Gets(string name)
    {
        return db.Vouchers.Where(e => e.VouCode.ToLower().Contains(name)).ToList();
    }
}
}
