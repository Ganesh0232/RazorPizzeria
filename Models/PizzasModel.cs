namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }

        public string PizzaName { get; set; } = string.Empty;

        public float BasePrice { get; set; } = 99;

        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }

        public bool Peperoni { get; set; }

        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }

        public bool PinaApple{ get; set; }

        public bool Ham { get; set; }

        public bool Chicken{ get; set; }

        public bool Paneer { get; set; }

        public float FinalPrice { get; set; }   


    }
}
