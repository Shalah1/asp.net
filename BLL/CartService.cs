using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using AutoMapper;

namespace BLL
{
    public class CartService
    {
        public static List<CartModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Cart, CartModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CartModel>>(DataAccessFactory.CartDataAccess().GetAll());
            return data;
        }

        public static CartModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Cart, CartModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<CartModel>(DataAccessFactory.CartDataAccess().Get(id));
            return data;
        }


        public static List<CartModel> Gets(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Cart, CartModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CartModel>>(DataAccessFactory.CartDataAccess().Gets(id));
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




        public static void Delete(int id)
        {
            DataAccessFactory.CartDataAccess().Delete(id);
        }

        public static void Add(CartModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CartModel, Cart>())).Map<Cart>(e);
            DataAccessFactory.CartDataAccess().ADD(data);
        }
        public static void Edit(CartModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CartModel, Cart>())).Map<Cart>(e);
            DataAccessFactory.CartDataAccess().Edit(data);
        }
    }
}
