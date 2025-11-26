namespace LibraryManagmentSystem.Models
{
    public class Magazine : LibraryItemBase
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, int year, int IssueNumber) : base (title, year)
        {
            this.IssueNumber = IssueNumber;
        }
        public override string GetItemType()
        {
            return "Magazine";
        }

        public string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $", IssueNumber : {IssueNumber}";
        }
    }
}