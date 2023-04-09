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
    public class DeliverymanController : ApiController
    {
        [Route("api/Deliveryman/All")]
        [HttpGet]
        public List<DeliverymanModel> GetAll()
        {
            return DeliverymanService.GetAll();
        }

        [Route("api/Deliveryman/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return DeliverymanService.GetNames();
        }

        [Route("api/Deliveryman/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            DeliverymanService.Delete(id);
        }


        [Route("api/Deliveryman/add")]
        [HttpPost]
        public void Add(DeliverymanModel e)
        {
            DeliverymanService.Add(e);
        }

        [Route("api/Deliveryman/edit")]
        [HttpPost]
        public void Edit(DeliverymanModel e)
        {
            DeliverymanService.Edit(e);
        }

        [Route("api/Deliveryman/get/{id}")]
        [HttpGet]
        public DeliverymanModel Get(int id)
        {
            return DeliverymanService.Get(id);
        }

        [Route("api/Deliveryman/search/{name}")]
        [HttpGet]
        public List<DeliverymanModel> Gets(string name)
        {
            return DeliverymanService.Gets(name);
        }

        [Route("api/Deliveryman/{oid}/{did}")]
        [HttpPost]
        public void assign(int oid, int did)
        {
            DeliverymanService.assign(oid, did);
        }
    }
}
