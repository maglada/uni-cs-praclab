using Lab5.Models;

namespace Lab5.Interfaces
{
    public interface IMenuService
    {
        void AddMenuItem(MenuItem item);
        List<MenuItem> GetAllMenuItems();  
        MenuItem? GetMenuItemById(int id); 
        List<MenuItem> SearchByName(string name);  
        List<MenuItem> SearchByCategory(string category);
    }
}