using System.Collections.Generic;
using Orders.Domain.Model.Order;

namespace Orders.Application
{
    public interface IOrdersService
    {
        void CreateNewOrder(Order order);
        IEnumerable<Order> GetAllActiveOrders();
    }
}