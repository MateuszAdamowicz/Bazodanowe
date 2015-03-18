using System.Collections;
using System.Collections.Generic;
using CommonObjects;
using CommonObjects.ValueObjects;

namespace Product.Domain.Model.Product
{
    public class Product
    {
        public int Id { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public Category.Category Category { get; set; }
        public IEnumerable<Category.Property> Properties { get; set; }
        public Price Price { get; set; }
        public int Quantity { get; set; }
    }
}