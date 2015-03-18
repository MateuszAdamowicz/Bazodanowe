using System.Collections;
using System.Collections.Generic;

namespace Product.Domain.Model.Product.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        int Add(Product product);
        int Delete(int productId);
        Product Find(int productId);
    }
}