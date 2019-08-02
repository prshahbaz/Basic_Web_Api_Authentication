using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api_Project.Models;

namespace Api_Project.Controllers
{
    [RoutePrefix("Api/Product")]
    public class ProductController : ApiController
    {
        [Authentication.BasicAuthentication]
        [HttpGet]
        [Route("ProductDetails")]
        public List<Product_Table> GetProducts()
        {
            using (BasicDbEntities db=new BasicDbEntities())
            {
                return db.Product_Table.ToList();
            }   
        }
    }
}
