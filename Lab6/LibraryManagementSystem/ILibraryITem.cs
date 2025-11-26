/*
Властивість int Id
○ Властивість string Title
○ Властивість int Year
○ Метод string GetDisplayInfo()
*/
namespace LibraryManagmentSystem.Interfaces
{
    public interface ILibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public string GetDisplayInfo();
        abstract string GetItemType();
    }
}