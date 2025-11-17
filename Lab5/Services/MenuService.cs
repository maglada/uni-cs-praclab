using Lab5.Interfaces;
using Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.Services
{
    public class MenuService : IMenuService
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private int nextId = 1;

        public void AddMenuItem(MenuItem item)
        {
            item.Id = nextId++;
            menuItems.Add(item);
        }

        public List<MenuItem> GetAllMenuItems()
        {
            return menuItems;
        }

        public MenuItem? GetMenuItemById(int id)
        {
            return menuItems.FirstOrDefault(item => item.Id == id);
        }

        public List<MenuItem> SearchByName(string name)
        {
            return menuItems.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<MenuItem> SearchByCategory(string category)
        {
            return menuItems
                .OfType<Dish>()
                .Where(dish => dish.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .Cast<MenuItem>()
                .ToList();
        }
    }
}