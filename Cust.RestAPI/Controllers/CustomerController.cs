using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cust.Core.ApplicationService;
using Cust.Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cust.RestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        // GET: api/Customer
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_customerService.getCustomerById(id));
        }
        
        // POST: api/Customer
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            return Ok(_customerService.CreateCustomer(customer));
        }
        
        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Customer customer)
        {
            if(id != customer.Id)
            {
                return BadRequest("Id not the same");
            }
            return Ok(_customerService.UpdateCustomer(customer));
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cust = _customerService.DeleteCustomer(id);
            if (cust == null) return NoContent();
            return Ok("Deleted cust with ID: " + cust.Id);
        }
    }
}
