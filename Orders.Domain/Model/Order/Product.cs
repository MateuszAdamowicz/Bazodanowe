using CommonObjects;
using CommonObjects.ValueObjects;

namespace Orders.Domain.Model.Order
{
    public class Product
    {
        public int Id { get; set; }
        public Price Price { get; set; }
        public string Name { get; set; }
    }
}