using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using AutoMapper;
using DAL;

namespace BLL
{
    public class VoucherService
    {
        public static List<VoucherModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Voucher, VoucherModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<VoucherModel>>(DataAccessFactory.VoucherDataAccess().GetAll());
            return data;
        }

        public static VoucherModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Voucher, VoucherModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<VoucherModel>(DataAccessFactory.VoucherDataAccess().Get(id));
            return data;
        }


        public static List<VoucherModel> Gets(string name)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Voucher, VoucherModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<VoucherModel>>(DataAccessFactory.VoucherDataSearch().Gets(name));
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
            DataAccessFactory.VoucherDataAccess().Delete(id);
        }

        public static void Add(VoucherModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<VoucherModel, Voucher>())).Map<Voucher>(e);
            DataAccessFactory.VoucherDataAccess().ADD(data);
        }
        public static void Edit(VoucherModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<VoucherModel, Voucher>())).Map<Voucher>(e);
            DataAccessFactory.VoucherDataAccess().Edit(data);
        }
    }
}
