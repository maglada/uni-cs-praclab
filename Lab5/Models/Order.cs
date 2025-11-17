using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.Models
{
    public enum OrderStatus
    {
        New,
        InProgress,
        Ready,
        Paid
    }

    public class Order
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public OrderStatus Status { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();

        public decimal TotalPrice() => Items.Sum(item => item.Price);
    }
}