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
    public class DeliveryService
    {
        public static List<DeliveryModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Deliveryman, DeliveryModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DeliveryModel>>(DataAccessFactory.DeliverDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.DeliverDataAccess().GetAll().Select(emp => emp.DName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.DeliverDataAccess().Delete(id);
        }

        public static void Add(DeliveryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliveryModel, Deliveryman>())).Map<Deliveryman>(e);
            DataAccessFactory.DeliverDataAccess().ADD(data);
        }
        public static void Edit(DeliveryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliveryModel, Deliveryman>())).Map<Deliveryman>(e);
            DataAccessFactory.DeliverDataAccess().Edit(data);
        }
        public static DeliveryModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Deliveryman, DeliveryModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DeliveryModel>(DataAccessFactory.DeliverDataAccess().Get(id));
            return data;
        }
    }
}
