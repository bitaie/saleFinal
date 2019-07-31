using Sale.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Products
{
    public interface IProductApplicationService
    {
        object SubmitProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        object UpdateProduct(Product product);
        object DeleteProduct(int id);
    }
}
