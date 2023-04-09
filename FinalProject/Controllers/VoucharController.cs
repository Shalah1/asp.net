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
    public class VoucharController : ApiController
    {

        public class VoucherController : ApiController
        {
            [Route("api/Voucher/All")]
            [HttpGet]
            public List<VoucherModel> GetAll()
            {
                return VoucherService.GetAll();
            }


            [Route("api/Voucher/delete/{id}")]
            [HttpPost]
            public void Delete(int id)
            {
                VoucherService.Delete(id);
            }

            [Route("api/Voucher/add")]
            [HttpPost]
            public void Add(VoucherModel e)
            {
                VoucherService.Add(e);
            }

            [Route("api/Voucher/edit")]
            [HttpPost]

            public void Edit(VoucherModel e)
            {
                VoucherService.Edit(e);
            }

            [Route("api/Voucher/get/{id}")]
            [HttpGet]
            public VoucherModel Get(int id)
            {
                return VoucherService.Get(id);
            }

            [Route("api/Voucher/search/{name}")]
            [HttpGet]
            public List<VoucherModel> Gets(string name)
            {
                return VoucherService.Gets(name);
            }


            //employee will give voucher id to specific customer
            [Route("api/Voucher/{cid}/{vouid}")]
            [HttpPost]
            public void Voucher(int cid, int vouid)
            {
                CustomerService.voucher(cid, vouid);
            }
        }
    }
}
