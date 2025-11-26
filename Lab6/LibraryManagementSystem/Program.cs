/*
Створіть проект LibraryManagementSystem
В класі Program в коментарі напишіть ПІБ та групу
Класи, методи та властивості мають бути публічними!
Необхідні компоненти для реалізації

1. ILibraryItem
○ Властивість int Id
○ Властивість string Title
○ Властивість int Year
○ Метод string GetDisplayInfo()

2. LibraryItemBase
○ Повинен імплементувати інтерфейс ILibraryItem
○ Статичне поле int _nextId
○ Конструктор який приймає title та year. Ініціалізує Title, Year та Id.
○ Абстрактний метод string GetItemType()
○ Метод GetDisplayInfo() Повинен повертати рядок у форматі:
"[Type] ID: [Id], Title: [Title], Year: [Year]"
приклад “Book ID: 4, Title: “C#”, Year: 2025”
використовуючи GetItemType();

3. Book
○ Наслідує LibraryItemBase
○ Властивість string Author
○ Конструктор який приймає title, year та author
○ Метод GetItemType() Повертає "Book"
○ Метод GetDisplayInfo() Повинен додавати інформацію про автора до виводу
базового класу.

4. Magazine
○ Наслідує LibraryItemBase
○ Властивість int IssueNumber
○ Конструктор який приймає title, year та issueNumber
○ Метод GetItemType() Повертає "Magazine"
○ Метод GetDisplayInfo() Повинен додавати інформацію про номер випуску до
виводу базового класу.

5. LibraryCatalog<T>
○ Повинен мати обмеження where T : ILibraryItem
○ Поле List<T> _items
○ Метод void AddItem(T item)
○ Метод List<T> GetAllItems() Повертає копію списку або сам список
○ Метод T GetItemById(int id) Повертає елемент за Id або default(T), якщо не
знайдено.

6. LibraryManager
○ Поле LibraryCatalog<Book> _bookCatalog
○ Поле LibraryCatalog<Magazine> _magazineCatalog;
○ Конструктор без параметрів який ініціалізує поля класу.
○ Метод void AddItem(ILibraryItem item)
Якщо це Book, додати його до _bookCatalog.
Якщо це Magazine, додати його до _magazineCatalog.
Ігнорувати об'єкти, які не є ані Book, ані Magazine.

○ Метод List<ILibraryItem> GetAllItems()
Повинен об'єднати всі елементи з _bookCatalog та _magazineCatalog в
один результуючий список List<ILibraryItem>

○ Метод ILibraryItem? GetItemById(int id)
Повертає знайдений об'єкт або null, якщо об'єкт не знайдено в жодному
каталозі
*/


using System;
using LibraryManagmentSystem.Models;
using LibraryManagmentSystem.Interfaces;
using LibraryManagmentSystem.Managers;
using System.Runtime.CompilerServices;

// Оперенко Віталій Сергійович, ПД-21
namespace LibraryManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
               
        }
    }
}