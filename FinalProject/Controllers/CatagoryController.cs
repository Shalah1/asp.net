using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class CatagoryController : ApiController
    {
        [Route("api/Category/All")]
        [HttpGet]
        public List<CatagoryModel> GetAll()
        {
            return CatagoryServices.GetAll();
        }

        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CatagoryServices.GetNames();
        }

        [Route("api/Category/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            CatagoryServices.Delete(id);
        }


        [Route("api/Category/add")]
        [HttpPut]

        public void Add(CatagoryModel e)
        {
            CatagoryServices.Add(e);
        }

        [Route("api/Category/edit")]
        [HttpPost]

        public void Edit(CatagoryModel e)
        {
            CatagoryServices.Edit(e);
        }
    }
}
