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
    public class OrderController : ApiController
    {
        [Route("api/Order/AllProducts")]
        [HttpGet]
        public List<OrderModel> AllProducts()
        {
            //this controller does not have any headache on how the data will be coming
            //it will go to ProductService in BLL and ProductService (GetAll)
            //will let you go to the DAL through ProductRepo and ProductRepo is a Class of DAL where all the db opertion has been done
            return OrderService.GetAll();
        }

        /*  [Route("api/Product/AllNames")]
          [HttpGet]
          public List<string> AllNames()
          {
              return OrderService.Get();
        }

  */
        [Route("api/Order/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            OrderService.Delete(id);
        }

        [Route("api/Order/Add")]
        [HttpPost]
        public void Add(OrderModel p)
        {
            OrderService.Add(p);
        }

        [Route("api/Order/edit")] //a particular product editing
        [HttpPost]

        public void Edit(OrderModel e)
        {
            //ProductService.Edit(e);
            OrderService.Edit(e);
        }
    }
}
