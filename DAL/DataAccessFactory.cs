using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static finalproEntities1 db;

        static DataAccessFactory()
        {
            db = new finalproEntities1();
        }

        //return IRepository interface. Sometime it will have ProductRepo class,
        //sometimes it will have CustomerRepo class
        //Every one will return IRepository
        /*public static IRepository<Product, int> ProudctDataAccess()
        {
            return new ProductRepo(db);
        }

        public static IRepository<Category, int> CatatoryDataAccess()
        {
            return new CategoryRepo(db);
        }

        public static IRepository<Customer, int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
        public static IRepository<Order, int> OrderDataAccess()
        {
            return new OrderRepo(db);
        }
        public static IRepository<Employee, int> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }
        public static IRepository<Voucher, int> VoucherDataAccess()
        {
            return new VoucherRepo(db);
        }
        public static IRepository<Cart, int> CartDataAccess()
        {

            return new CartRepo(db);
        }*/

        public static IRepository<Employee, int> EmployeeDataAccess()
        {

            return new EmployeeRepo(db);
        }

        public static IRepository<PReview, int> PReviewDataAccess()
        {

            return new PReviewRepo(db);
        }

        public static IRepository<Product, int> ProductDataAccess()
        {

            return new ProductRepo(db);
        }

        public static SRepository<Product, string> ProductDataSearch()
        {
            return new ProductSearchRepo(db);
        }
        public static SRepository<Customer, string> CustomerDataSearch()
        {
            return new CustomerSearchRepo(db);
        }

        public static SRepository<Deliveryman, string> DeliverymanStatusSearch()
        {
            return new DeliverymanStatusSearchRepo(db);
        }

        public static IRepository<Category, int> CategoryDataAccess()
        {

            return new CategoryRepo(db);
        }
        /*
        public static IRepository<Shop, int> ShopDataAccess()
        {

            return new ShopRepo(db);
        } */
        public static IRepository<Customer, int> CustomerDataAccess()
        {

            return new CustomerRepo(db);
        }
        public static IRepository<Order, int> OrderDataAccess()
        {

            return new OrderRepo(db);
        }
        public static IRepository<Cart, int> CartDataAccess()
        {

            return new CartRepo(db);
        }
        public static IRepository<Deliveryman, int> DeliverymanDataAccess()
        {

            return new DeliverymanRepo(db);
        }
        public static IRepository<Voucher, int> VoucherDataAccess()
        {

            return new VoucherRepo(db);
        }
        public static IRepository<Deliveryman, int> DeliverDataAccess()
        {

            return new DeliverRepo(db);
        }
        public static SRepository<Voucher, string> VoucherDataSearch()
        {
            return new VoucherSearchRepo(db);
        }

        public static SRepository<Order, string> OrderSearchByStatus()
        {

            return new OrderSearchRepo(db);
        }
        public static void Voucherapply(int a, int b)
        {
            var emp = db.Customers.FirstOrDefault(em => em.CId == a);
            db.Entry(emp).CurrentValues.SetValues(emp.VouId = b);
            db.SaveChanges();
        }
        public static List<Product> lessquantity()
        {
            return db.Products.Where(e => e.PStock < 5).ToList();
        }
        public static List<Product> topsold()
        {
            return db.Products.Where(e => e.PSoldQuantity > 5).ToList();
        }

        public static List<Product> discounted()
        {
            return db.Products.Where(e => e.PDiscount > 0).ToList();
        }
        public static List<Product> range(int a, int b)//200>150 && 200<400
        {
            return db.Products.Where(e => e.PBasicPrice > a && e.PBasicPrice < b).ToList();
        }
        public static List<OrderDetail> orderdetails(int id)
        {
            return db.OrderDetails.Where(e => e.CId == id).ToList();
        }

        public static void assignOrder(int a, int b)
        {
            var emp = db.Deliverymen.FirstOrDefault(em => em.DId == b);
            db.Entry(emp).CurrentValues.SetValues(emp.DOrderid = a);
            db.SaveChanges();

            var order = db.Orders.FirstOrDefault(e => e.OId == a);
            db.Entry(order).CurrentValues.SetValues(order.EId = b);
            db.SaveChanges();
        }
    }
}
