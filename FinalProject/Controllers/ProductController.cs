using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Cors;

namespace FinalProject.Controllers
{
    public class ProductController : ApiController 
    {
        //add, fetch all products

        [Route("api/Product/AllProducts")]
        [HttpGet]
        public List<ProductModel> AllProducts()
        {
            //this controller does not have any headache on how the data will be coming
            //it will go to ProductService in BLL and 
            //ProductService (GetAll) will let you go to the DAL through ProductRe3po
            //and ProductRepo is a Class of DAL where all the db opertion has been done
            return ProductService.GetAll();
        }

        [Route("api/Product/AllNames")]
        [HttpGet]
        public List<string> AllNames()
        {
            return ProductService.GetNames();
        }


        [Route("api/Product/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            ProductService.Delete(id);
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel p)
        {
            ProductService.Add(p);
        }

         [Route("api/Product/edit")] //a particular product editing
        [HttpPost]

        public void Edit(ProductModel e)
        {
            ProductService.Edit(e);
        }

        [Route("api/Product/get/{id}")] //a particular product fatching by id
        [HttpGet]
        public ProductModel Get(int id)
        {
            return ProductService.Get(id);
        }

        [Route("api/Product/search/{an}")] ////a particular product searching here an is the product name
        [HttpGet]
        public List<ProductModel> Gets(string an)
        {
            return ProductService.Gets(an);
        }

        [Route("api/Product/lessquantity")] //quantity less (Remainder)
        [HttpGet]
        public List<ProductModel> lessquantity()
        {
            return ProductService.lessquantity();
        }


        [Route("api/Product/mostpopular")] //most popular product / most selling product
        [HttpGet]
        public List<ProductModel> mostpopular()
        {
            return ProductService.topsold();
        }

        [Route("api/Product/discounted")] //giving discount
        [HttpGet]
        public List<ProductModel> discounted()
        {
            return ProductService.discounted();
        }

        [Route("api/Product/range/{aa}/{bb}")]
        [HttpGet]
        public List<ProductModel> range(int aa, int bb)
        {
            return ProductService.range(aa, bb);
        }

        /*    [Route("api/Product/addreview/{id}")] 
            [HttpPut]
            *//*public void Addreview(PReviewsModel e,int id)
            {
                 ProductService.Addreview(e,id);
            }*/
    }
}
