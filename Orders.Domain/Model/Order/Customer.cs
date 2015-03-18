using CommonObjects.ValueObjects;

namespace Orders.Domain.Model.Order
{
    public class Customer
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public EmailAddress Email { get; set; }
        public Address Address { get; set; }
    }
}