using System.Collections.Generic;
using Lab5.Models;

namespace Lab5.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(int tableNumber);
        Order? GetOrderById(int id);
        List<Order> GetAllActiveOrders();
        void AddItemToOrder(int orderId, int menuItemId);
        void RemoveItemFromOrder(int orderId, int itemId);
        void ChangeOrderStatus(int orderId, OrderStatus newStatus);
        void UpdateOrderStatus(int id, OrderStatus status);
        List<Order> GetActiveOrders();
        decimal CalculateTotalPrice(int orderId);
    }
}