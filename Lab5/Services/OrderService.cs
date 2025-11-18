using Lab5.Interfaces;
using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.Services
{
    public class OrderService : IOrderService
    {
        private List<Order> orders = new List<Order>();
        private int nextId = 1;
        private readonly IMenuService menuService;

        public OrderService(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        public Order CreateOrder(int tableNumber)
        {
            var order = new Order
            {
                Id = nextId++,
                TableNumber = tableNumber,
                Status = OrderStatus.New
            };
            orders.Add(order);
            return order;
        }
        public Order? GetOrderById(int id)
        {
            return orders.FirstOrDefault(order => order.Id == id);
        }
        public List<Order> GetAllActiveOrders()
        {
            return orders.Where(order => order.Status != OrderStatus.Paid).ToList();
        }
        public void AddItemToOrder(int orderId, int menuItemId)
        {
            var order = GetOrderById(orderId);
            if (order != null)
            {
                var item = menuService.GetMenuItemById(menuItemId);
                if (item != null)
                {
                    order.Items.Add(item);
                }
            }
        }
        public void RemoveItemFromOrder(int orderId, int itemId)
        {
            var order = GetOrderById(orderId);
            if (order != null)
            {
                var item = order.Items.FirstOrDefault(i => i.Id == itemId);
                if (item != null)
                {
                    order.Items.Remove(item);
                }
            }
        }
        public void ChangeOrderStatus(int orderId, OrderStatus newStatus)
        {
            UpdateOrderStatus(orderId, newStatus);
        }

        public void UpdateOrderStatus(int id, OrderStatus status)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                order.Status = status;
            }
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }
        public List<Order> GetActiveOrders()
        {
            return GetAllActiveOrders();
        }

        public decimal CalculateTotalPrice(int orderId)
        {
            var order = GetOrderById(orderId);
            return order?.TotalPrice() ?? 0;
        }
    }
}