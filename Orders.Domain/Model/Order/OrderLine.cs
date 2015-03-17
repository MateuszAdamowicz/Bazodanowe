namespace Orders.Domain.Model.Order
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}