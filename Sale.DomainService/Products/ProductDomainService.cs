using Sale.Contract.Customers;
using Sale.Domain.Customers;
using Sale.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Sale.Contract.Common;
using Sale.Domain.Products;
using Sale.Infrastructure.Validations;
using Sale.Contract.Products;

namespace Sale.DomainService.Customers
{
    public class ProductDomainService : IProductDomainService
    {
        private readonly AppDbContext _context = null;
        private readonly IGenericValidation<Product> _productValidation;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductDomainService(AppDbContext ctx, IGenericRepository<Product> productRepository,IGenericValidation<Product> productValidation)
        {
            _context = ctx;
            _productRepository = productRepository;
            _productValidation = productValidation;
        }
        public string IsDuplicateInsert(Product product)

        {
            try
            {
               return _productValidation.IsDuplicateInsert(product);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<string> CheckProductRequiredFieldsFilled(Product product, List<string> requiredFields)
        {
            return _productValidation.CheckEntityRequiredFieldsFilled(product, requiredFields);
        }
        public List<string> CheckProductFieldsUpperLimitLengthRight(Product product, Dictionary<string, int> limitedFields)
        {

            return _productValidation.CheckEntityFieldsUpperLimitLengthRight(product, limitedFields);
        }
        public Dictionary<int, string> GetAllProductList()
        {
            var products = _productRepository.GetAll();
            Dictionary<int, string> productsDictionary = new Dictionary<int, string>();
            //var productsList = new List<string>();
            foreach (var product in products)
            {
                productsDictionary.Add(product.Id, product.Brand + " " + product.Name);
            }
            return productsDictionary;

        }









    }
}
