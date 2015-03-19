using System;

namespace Orders.Domain.Model.Order
{
    public class OrderStatus
    {
        public StatusName StatusName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}