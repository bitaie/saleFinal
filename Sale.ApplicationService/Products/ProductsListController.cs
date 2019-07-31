using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sale.Contract.Products;

namespace Sale.ApplicationService.Products
{
    //For using as Drop Down in Invoice 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsListController : ControllerBase
    {
        private readonly IProductDomainService _ProductService;

        public ProductsListController(IProductDomainService ProductService)
        {
            _ProductService = ProductService;
        }
        // GET: api/ProductsList
        [HttpGet]
        public Dictionary<int, string> Get()
        {
            return _ProductService.GetAllProductList();
        }


    }
}
