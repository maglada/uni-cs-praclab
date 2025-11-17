namespace Lab5.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public override string ToString() => $"[{Id}] {Name} - {Price:C}";
    }

    public class Dish : MenuItem
    {
        public string Category { get; set; } = string.Empty;

        public override string ToString() => $"[{Id}] Dish: {Name} ({Category}) - {Price:C}";
    }

    public class Drink : MenuItem
    {
        public double Volume { get; set; }
        public bool IsAlcoholic { get; set; }

        public override string ToString() => $"[{Id}] Drink: {Name} ({Volume}L, Alcoholic: {IsAlcoholic}) - {Price:C}";
    }
}