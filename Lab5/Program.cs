/*
Функціональні вимоги
Програма повинна забезпечувати такі можливості:

Робота з меню
Зберігати інформацію про страви й напої (назва, ціна, додаткові характеристики — наприклад, категорія, об’єм, алкогольність тощо).
Можливість перегляду повного меню.

Робота із замовленнями
Створення нового замовлення (з вказаним номером столика або клієнта).
Додавання та видалення позицій з меню у замовлення.
Розрахунок загальної вартості замовлення.
Зміна статусу замовлення (наприклад: New → InProgress → Ready → Paid).
Перегляд усіх активних замовлень ресторану.

Облік і пошук
Пошук замовлення за унікальним номером (ID).
Пошук позицій у меню за назвою або категорією (на ваш розсуд або обидва варіанти).

Принципи побудови
Кожен клас повинен відповідати за одну логічну задачу.
Усі поля мають бути інкапсульовані (доступ через властивості).
Методи повинні виконувати лише одну конкретну дію.
Використати інтерфейси або абстрактні класи для спільних функцій об’єктів.
Застосувати композицію або агрегацію між об’єктами (наприклад, ресторан містить список замовлень).
Продемонструвати upcast/downcast у коді.
Використати enum для статусів замовлення.

Презентація результатів
Вся взаємодія з системою — через метод Main.
Вивід має бути структурований, читабельний та інформативний.

*/

using System;
using Lab5.Models;
using Lab5.Services;
using Lab5.Controllers;
using Lab5.Interfaces;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenuService menuService = new MenuService();
            IOrderService orderService = new OrderService(menuService);

            MenuController menuController = new MenuController(menuService);
            OrderController orderController = new OrderController(orderService);

            // Додавання страв і напоїв до меню
            menuController.AddDish("Піца Маргарита", 150.00m, "Італійська");
            menuController.AddDrink("Кока-Кола", 30.00m, 0.5, false);

            // Перегляд меню
            Console.WriteLine("Меню ресторану:");
            menuController.ViewMenu();

            // Створення нового замовлення
            Order order = orderController.CreateOrder(5);
            Console.WriteLine($"\nСтворено нове замовлення з ID: {order.Id} для столика №{order.TableNumber}");

            // Додавання позицій до замовлення
            orderController.AddItemToOrder(order.Id, 1); // Додаємо Піцу Маргариту
            orderController.AddItemToOrder(order.Id, 2); // Додаємо Кока-Колу

            // Перегляд активних замовлень
            Console.WriteLine("\nАктивні замовлення:");
            orderController.ViewActiveOrders();

            // Зміна статусу замовлення
            orderController.ChangeOrderStatus(order.Id, OrderStatus.InProgress);
            Console.WriteLine($"\nСтатус замовлення ID {order.Id} змінено на {OrderStatus.InProgress}");
            orderController.ChangeOrderStatus(order.Id, OrderStatus.Ready);
            Console.WriteLine($"\nСтатус замовлення ID {order.Id} змінено на {OrderStatus.Ready}");
            orderController.ChangeOrderStatus(order.Id, OrderStatus.Paid);
            Console.WriteLine($"\nСтатус замовлення ID {order.Id} змінено на {OrderStatus.Paid}");

            Console.WriteLine("\nУсі замовлення:");
            orderController.ViewAllOrders();

        }
    }
}