using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace Orders.Domain.Model.Order
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public IEnumerable<OrderLine> Products { get; set; }
        public string Comment { get; set; }
        public Price Price { get; set; }
    }
}
