using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;
using BLL;
using BEL;

namespace BLL
{
    public class ProductService
    {
        //methods

        //for fetching all info with the help of Automapper.
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().GetAll());
            return data;
        }

        public static ProductModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ProductModel>(DataAccessFactory.ProductDataAccess().Get(id));
            return data;
        }


        public static List<ProductModel> Gets(string name)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataSearch().Gets(name));
            return data;
        }

        /*   

         

        public static List<ProductModel> Gets(string name)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().GetAll().Select(emp => emp.PName = name).ToList());
        }


         */



        public static List<String> GetNames()
        {

            var data = DataAccessFactory.ProductDataAccess().GetAll().Select(emp => emp.PName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.ProductDataAccess().Delete(id);
        }

        public static void Add(ProductModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>())).Map<Product>(e);
            DataAccessFactory.ProductDataAccess().ADD(data);
        }
        public static void Edit(ProductModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>())).Map<Product>(e);
            DataAccessFactory.ProductDataAccess().Edit(data);
        }

        public static List<ProductModel> lessquantity()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.lessquantity());
            return data;
        }
        public static List<ProductModel> topsold()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.topsold());
            return data;
        }
        public static List<ProductModel> discounted()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.discounted());
            return data;
        }

        public static List<ProductModel> range(int a, int b)
        {
            //  var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CustomerModel, Customer>())).Map<Customer>(e);
            // DataAccessFactory.range(a, b);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.range(a, b));
            return data;
        }
    }
}
