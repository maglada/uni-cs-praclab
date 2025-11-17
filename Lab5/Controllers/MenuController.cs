using Lab5.Interfaces;
using Lab5.Models;
using Lab5.Services;
using System;

namespace Lab5.Controllers
{
    public class MenuController
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void AddDish(string name, decimal price, string category)
        {
            Dish dish = new Dish
            {
                Name = name,
                Price = price,
                Category = category
            };
            _menuService.AddMenuItem(dish);
        }

        public void AddDrink(string name, decimal price, double volume, bool isAlcoholic)
        {
            Drink drink = new Drink
            {
                Name = name,
                Price = price,
                Volume = volume,
                IsAlcoholic = isAlcoholic
            };
            _menuService.AddMenuItem(drink);
        }

        public void ViewMenu()
        {
            var items = _menuService.GetAllMenuItems();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}