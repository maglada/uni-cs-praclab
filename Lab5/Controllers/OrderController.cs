using Lab5.Interfaces;
using Lab5.Models;
using Lab5.Services;
using System;

namespace Lab5.Controllers
{
    public class OrderController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public Order CreateOrder(int tableNumber)
        {
            return _orderService.CreateOrder(tableNumber);
        }

        public void AddItemToOrder(int orderId, int menuItemId)
        {
            _orderService.AddItemToOrder(orderId, menuItemId);
        }

        public void RemoveItemFromOrder(int orderId, int menuItemId)
        {
            _orderService.RemoveItemFromOrder(orderId, menuItemId);
        }

        public void ChangeOrderStatus(int orderId, OrderStatus newStatus)
        {
            _orderService.ChangeOrderStatus(orderId, newStatus);
        }

        public void ViewActiveOrders()
        {
            var orders = _orderService.GetActiveOrders();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Table: {order.TableNumber}, Status: {order.Status}, Total Price: {order.TotalPrice()}");
            }
        }
    }
}