using System;

namespace Orders.Domain.Model.Order
{
    public class OrderStatus
    {
        public string StatusName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}