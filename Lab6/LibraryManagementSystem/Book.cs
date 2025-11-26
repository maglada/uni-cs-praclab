namespace LibraryManagmentSystem.Models
{
    public class Book : LibraryItemBase
    {
        string Author { get; set; }

        public Book(string title, int year, string author) : base (title, year)
        {
            Author = author;
        }
        public override string GetItemType()
        {
            return "Book";
        }

        public string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $", Author: {Author}";
        }
    }
}