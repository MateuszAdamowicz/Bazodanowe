namespace Orders.Domain.Model.Order
{
    public class Customer
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}