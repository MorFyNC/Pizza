namespace BlazorApp1.Data
{
    public class Cart
    {
        public Dictionary<Pizza, int> pizzas = new Dictionary<Pizza, int>();
        public int Summary;

        public void Add(Pizza pizza)
        {
            if(pizzas.ContainsKey(pizza))
            {
                pizzas[pizza] += 1;
            }
            else
            {
                pizzas.Add(pizza, 1);
            }
        }
    }
}
