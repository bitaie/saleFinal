using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sale.Domain.Products;

namespace Sale.Contract.Products
{
    public interface IProductDomainService
    {
        string IsDuplicateInsert(Product product);
        List<string> CheckProductRequiredFieldsFilled(Product product, List<string> requiredFields);
        List<string> CheckProductFieldsUpperLimitLengthRight(Product product, Dictionary<string, int> limitedFields);
        Dictionary<int, string> GetAllProductList();
    }
}
