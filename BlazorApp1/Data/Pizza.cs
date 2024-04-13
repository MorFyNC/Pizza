namespace BlazorApp1.Data
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }

        public Pizza(string name, string description, int cost, string image)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Image = image;
        }
    }
}
