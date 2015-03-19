using System.Collections.Generic;
using Orders.Domain.Model.Order;

namespace Orders.Application
{
    public interface IOrdersService
    {
        bool CreateNewOrder(Order order);
        bool DeleteOrder(int id);

        IEnumerable<Order> GetAllActiveOrders();
        OrderStatus SetNextProperOrderStatus(Order order);
        bool CancelOrder(Order order);
        bool AddProductToOrder(Order order, OrderLine product);
        bool DeleteProductFromOrder(Order order, OrderLine product);
        IEnumerable<OrderLine> GetOrderProducts(Order order);
    }
}