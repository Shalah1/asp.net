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
    public class CartController : ApiController
    {
        [Route("api/Cart/All")]
        [HttpGet]
        public List<CartModel> GetAll()
        {
            return CartService.GetAll();
        }



        [Route("api/Cart/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            CartService.Delete(id);
        }

        [Route("api/Cart/add")]
        [HttpPost]
        public void Add(CartModel e)
        {
            CartService.Add(e);
        }

        [Route("api/Cart/edit")]
        [HttpPost]
        public void Edit(CartModel e)
        {
            CartService.Edit(e);
        }

        [Route("api/Cart/get/{id}")]
        [HttpGet]
        public CartModel Get(int id)
        {
            return CartService.Get(id);
        }

        [Route("api/Cart/search/{id}")]
        [HttpGet]
        public List<CartModel> Gets(int id)
        {
            return CartService.Gets(id);
        }
    }
}
