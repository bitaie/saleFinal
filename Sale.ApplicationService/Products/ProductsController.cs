using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sale.Contract.Products;
using Sale.Domain.Products;

namespace Sale.ApplicationService.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductApplicationService _productApplicationService;

        public ProductsController(IProductApplicationService productApplicationService)
        {
            _productApplicationService = productApplicationService;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProduct()
        {

            return _productApplicationService.GetAllProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var Product = _productApplicationService.GetProductById(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Ok(Product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult PutProduct([FromBody] Product Product)
        {
            try
            {
                var result = _productApplicationService.UpdateProduct(Product);
                if (result.GetType() == typeof(Product))
                {
                    return Ok(Product);
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

        // POST: api/Products
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product Product)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            try
            {
                var result = _productApplicationService.SubmitProduct(Product);
                if (result.GetType() == typeof(Product))
                {
                    return Ok();
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

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _productApplicationService.DeleteProduct(id);
            if (result.GetType() == typeof(Product))
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