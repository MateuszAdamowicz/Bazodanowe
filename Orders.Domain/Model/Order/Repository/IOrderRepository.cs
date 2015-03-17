using System.Collections.Generic;

namespace Orders.Domain.Model.Order.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        int Add(Order order);
        int Delete(int orderId);
        Order Find(int orderId);
    }
}