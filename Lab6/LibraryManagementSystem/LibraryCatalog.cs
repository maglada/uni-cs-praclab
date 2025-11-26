using System.Runtime.InteropServices;

namespace LibraryManagmentSystem.Models
{
    public class LibraryCatalog<T> where T : LibraryItemBase
    {
        private List<T> _items;
        public void AddItem(T item)
        {
            _items.Add(item);
        }
        public List<T> GetAllItems()
        {
            return _items;
        }

        public T GetItemById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}