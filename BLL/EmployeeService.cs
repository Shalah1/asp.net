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
    public class EmployeeService
    {
        //for fetching all info with the help of Automapper.
        public static List<EmployeeModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.EmployeeDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.EmployeeDataAccess().GetAll().Select(emp => emp.EName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.EmployeeDataAccess().Delete(id);
        }

        public static void Add(EmployeeModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EmployeeModel, Employee>())).Map<Employee>(e);
            DataAccessFactory.EmployeeDataAccess().ADD(data);
        }
        public static void Edit(EmployeeModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EmployeeModel, Employee>())).Map<Employee>(e);
            DataAccessFactory.EmployeeDataAccess().Edit(data);
        }
        public static EmployeeModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Get(id));
            return data;
        }
    }
}
