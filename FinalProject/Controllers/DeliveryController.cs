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
    public class DeliveryController : ApiController
    {
        [Route("api/Deliver/All")]
        [HttpGet]
        public List<DeliveryModel> GetAll()
        {
            return DeliveryService.GetAll();
        }

        [Route("api/Deliver/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return DeliveryService.GetNames();
        }

        [Route("api/Deliver/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            DeliveryService.Delete(id);
        }


        [Route("api/Deliver/get/{id}")]
        [HttpGet]
        public DeliveryModel Get(int id)
        {
            return DeliveryService.Get(id);
        }


        [Route("api/Deliver/add")]
        [HttpPost]
        public void Add(DeliveryModel e)
        {
            DeliveryService.Add(e);
        }

        [Route("api/Deliver/edit")]
        [HttpPost]

        public void Edit(DeliveryModel e)
        {
            DeliveryService.Edit(e);
        }
    }
}
