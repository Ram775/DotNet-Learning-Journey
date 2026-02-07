using System;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        //Get Method 

        [HttpGet]
        public string GetProduct()
        {
            return "All Product List";
        }

        //Get Method By Id

        [HttpGet("{id}")] 
        public string GetProductById(int id)
        {
            return "HI";
        }


        //Post Method 
        [HttpPost]
        public string AddProducts()
        {
            return "Product Added";
        }

        //PUT Method

        [HttpPut("{id}")]
        public string UpdateProducts(int id)
        {
            return "Update Success";
        }

        //Delete Method
        [HttpDelete("{id}")]
        public string DeleteProducts(int id) {
            return "Product Deleted SuccessFully";
        
        }

    }
};