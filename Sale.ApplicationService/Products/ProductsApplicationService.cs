using Sale.Contract.Common;
using Sale.Contract.Products;
using Sale.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.ApplicationService.Products
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductDomainService _productDomainService;
        private readonly IGenericRepository<Product> _productRepository;
        private static List<string> requiredFields = new List<string>() { "FirstName", "LastName", "PhoneNumber" };
        private static Dictionary<string, int> limitedFields = new Dictionary<string, int>() { { "FirstName", 50 }, { "LastName", 50 }, { "PhoneNumber", 10 } };
        public ProductApplicationService(IProductDomainService productDomainService, IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
            _productDomainService = productDomainService;
            

        }

        public object SubmitProduct(Product product)
        {
            var productRequireedFilledErrors = _productDomainService.CheckProductRequiredFieldsFilled(product, requiredFields);
            var productFieldsUpperLimitLengthRightErrors = _productDomainService.CheckProductFieldsUpperLimitLengthRight(product, limitedFields);


            if (productRequireedFilledErrors.Any() && productFieldsUpperLimitLengthRightErrors.Any())

            {
                List<string> errors = productRequireedFilledErrors.Concat(productFieldsUpperLimitLengthRightErrors).ToList();
                return errors;


            }
            var IsDuplicateInsertError = _productDomainService.IsDuplicateInsert(product);
            if (IsDuplicateInsertError != null)
            {

                return IsDuplicateInsertError;
            }
            return _productRepository.Insert(product);
        }
        public object UpdateProduct(Product product)
        {
            var productRequireedFilledErrors = _productDomainService.CheckProductRequiredFieldsFilled(product, requiredFields);
            var productFieldsUpperLimitLengthRightErrors = _productDomainService.CheckProductFieldsUpperLimitLengthRight(product, limitedFields);


            if (productRequireedFilledErrors.Any() && productFieldsUpperLimitLengthRightErrors.Any())

            {
                List<string> errors = productRequireedFilledErrors.Concat(productFieldsUpperLimitLengthRightErrors).ToList();
                return errors;


            }
            var IsDuplicateInsertError = _productDomainService.IsDuplicateInsert(product);
            if (IsDuplicateInsertError != null)
            {

                return IsDuplicateInsertError;
            }
            return _productRepository.Update(product);

        }
        public object DeleteProduct(int id)
        {


            return _productRepository.Delete(id);

        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.Get(x => x.Id == id).FirstOrDefault();
        }

    }
}
