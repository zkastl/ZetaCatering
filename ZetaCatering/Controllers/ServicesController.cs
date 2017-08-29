using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZetaCatering.Model;

namespace ZetaCatering.Controllers
{
    [Produces("application/json")]
    [Route("services")]
    public class ServicesController : Controller
    {
        List<Message> messages = new List<Message>();
        Product[] Products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        // GET: services
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        // GET: services/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST:services
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: services/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
