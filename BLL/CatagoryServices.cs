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
    public class CatagoryServices
    {
        public static List<CatagoryModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CatagoryModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CatagoryModel>>(DataAccessFactory.CategoryDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {                  

            var data = DataAccessFactory.CategoryDataAccess().GetAll().Select(emp => emp.CategoryName).ToList();
            return data;

        }
        public static void Delete(int id)
        {
            DataAccessFactory.CategoryDataAccess().Delete(id);
        }

        public static void Add(CatagoryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CatagoryModel, Category>())).Map<Category>(e);
            DataAccessFactory.CategoryDataAccess().ADD(data);
        }  
        public static void Edit(CatagoryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CatagoryModel, Category>())).Map<Category>(e);
            DataAccessFactory.CategoryDataAccess().Edit(data);
        }
    }
}
