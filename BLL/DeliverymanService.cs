using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
    public class DeliverymanService
    {

        public static List<DeliverymanModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Deliveryman, DeliverymanModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DeliverymanModel>>(DataAccessFactory.DeliverymanDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.DeliverymanDataAccess().GetAll().Select(emp => emp.DName).ToList();
            return data;

        }

        public static DeliverymanModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Deliveryman, DeliverymanModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DeliverymanModel>(DataAccessFactory.DeliverymanDataAccess().Get(id));
            return data;
        }

        public static List<DeliverymanModel> Gets(string name)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Deliveryman, DeliverymanModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DeliverymanModel>>(DataAccessFactory.DeliverymanStatusSearch().Gets(name));
            return data;
        }

        public static void Delete(int id)
        {
            DataAccessFactory.DeliverymanDataAccess().Delete(id);
        }

        public static void Add(DeliverymanModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliverymanModel, Deliveryman>())).Map<Deliveryman>(e);
            DataAccessFactory.DeliverymanDataAccess().ADD(data);
        }
        public static void Edit(DeliverymanModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliverymanModel, Deliveryman>())).Map<Deliveryman>(e);
            DataAccessFactory.DeliverymanDataAccess().Edit(data);
        }

        public static void assign(int a, int b)
        {
            //  var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CustomerModel, Customer>())).Map<Customer>(e);
            DataAccessFactory.assignOrder(a, b);
        }
    }
}
