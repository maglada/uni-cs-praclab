/*
1. ILibraryItem
○ Властивість int Id
○ Властивість string Title
○ Властивість int Year
○ Метод string GetDisplayInfo()
*/
using LibraryManagmentSystem.Interfaces;

namespace LibraryManagmentSystem.Models
{
     
    public abstract class LibraryItemBase : ILibraryItem
    {
        public static int _nextId = 1;

        public LibraryItemBase(string title, int year)
        {
            Id = _nextId++;
            Title = title;
            Year = year;
        }

        public abstract string GetItemType();
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public string GetDisplayInfo()
        {
            return $" {GetItemType()} ID: {Id}, Title: {Title}, Year: {Year}";
        }
    }
}