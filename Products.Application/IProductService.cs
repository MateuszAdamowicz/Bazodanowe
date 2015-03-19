using System.Collections.Generic;
using Products.Domain.Model.Category;
using Products.Domain.Model.Product;

namespace Products.Application
{
    public interface IProductService
    {
        void CreateNewProduct(Product product);
        bool AddPropertyToProduct(Product product, Property property);
        bool DeletePropertyFromProduct(Product product, Property property);
        IEnumerable<Product> GetAllCategoryProducts (Category category);
    }
}