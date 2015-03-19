using Products.Domain.Model.Category;
using Products.Domain.Model.Product;

namespace Products.Application
{
    public interface ICategoryService
    {
        void CreateNewCategory(Category category);
        bool AddProductToCategory(Category category, Product product);
        bool DeleteProductFromCategory(Category category, Product product);
    }
}