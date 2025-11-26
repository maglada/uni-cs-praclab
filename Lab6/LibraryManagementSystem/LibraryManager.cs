using System;
using System.Collections.Generic;
using LibraryManagmentSystem.Models;
using LibraryManagmentSystem.Interfaces;


namespace LibraryManagmentSystem.Managers
{
    public class LibraryManager
    {
        public LibraryCatalog<Book> _bookCatalog;
        public LibraryCatalog<Magazine> _magazineCatalog;
        public LibraryManager()
        {
            _bookCatalog = new LibraryCatalog<Book>();
            _magazineCatalog = new LibraryCatalog<Magazine>();
        }
        void AddItem(ILibraryItem item)
        {
            if (item is Book book)
            {
                _bookCatalog.AddItem(book);
            }
            else if (item is Magazine magazine)
            {
                _magazineCatalog.AddItem(magazine);
            }
        }
        public List<ILibraryItem> GetAllItems()
        {
            List<ILibraryItem> allItems = new List<ILibraryItem>();
            allItems.AddRange(_bookCatalog.GetAllItems());
            allItems.AddRange(_magazineCatalog.GetAllItems());
            return allItems;
        }
        public ILibraryItem? GetItemById(int id)
        {
            ILibraryItem bookItem = _bookCatalog.GetItemById(id);
            if (bookItem != null)
            {
                return bookItem;
            }

            ILibraryItem magazineItem = _magazineCatalog.GetItemById(id);
            if (magazineItem != null)
            {
                return magazineItem;
            }

            return null;
        }
    }
}