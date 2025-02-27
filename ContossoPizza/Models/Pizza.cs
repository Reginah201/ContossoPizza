namespace ContossoPizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }
    }
}
