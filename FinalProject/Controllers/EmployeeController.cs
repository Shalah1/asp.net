using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace FinalProject.Controllers
{
    public class EmployeeController : ApiController
    {


        [Route("api/Employee/All")]
        [HttpGet]
        public List<EmployeeModel> GetAll()
        {
            return EmployeeService.GetAll();
        }

        [Route("api/Employee/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return EmployeeService.GetNames();
        }

        [Route("api/Employee/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            EmployeeService.Delete(id);
        }


        [Route("api/Employee/get/{id}")]
        [HttpGet]
        public EmployeeModel Get(int id)
        {
            return EmployeeService.Get(id);
        }


        [Route("api/Employee/add")]
        [HttpPost]
        public void Add(EmployeeModel e)
        {
            EmployeeService.Add(e);
        }

        [Route("api/Employee/edit")]
        [HttpPost]

        public void Edit(EmployeeModel e)
        {
            EmployeeService.Edit(e);
        }
    }
}
