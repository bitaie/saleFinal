using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sale.Contract.Customers;
using Sale.Domain.Customers;

namespace Sale.ApplicationService.Customers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerApplicationService _customerApplicationService;

        public CustomersController(ICustomerApplicationService customerApplicationService)
        {
            _customerApplicationService = customerApplicationService;
        }

        // GET: api/Customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            
            return _customerApplicationService.GetAllCustomers();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public IActionResult GetCustomer([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var Customer = _customerApplicationService.GetCustomerById(id);

            if (Customer == null)
            {
                return NotFound();
            }

            return Ok(Customer);
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public IActionResult PutCustomer([FromBody] Customer Customer)
        {
            try
            {
                var result = _customerApplicationService.UpdateCustomer(Customer);
                if (result.GetType() == typeof(Customer))
                {
                    return Ok(Customer);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
            


        }

        // POST: api/Customers
        [HttpPost]
        public IActionResult PostCustomer([FromBody] Customer Customer)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            try
            {
                var result = _customerApplicationService.SubmitCustomer(Customer);
                if (result.GetType() == typeof(Customer))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch(Exception ex)
            {
                return Content(ex.ToString());
            }


            
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _customerApplicationService.DeleteCustomer(id);
            if (result.GetType() == typeof(Customer))
            {
                return Ok(result);
            }
            else
            {
                return NotFound(); ;
            }
           

           
        }


    }
}