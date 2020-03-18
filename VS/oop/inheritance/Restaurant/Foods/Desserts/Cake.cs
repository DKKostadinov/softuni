namespace Restaurant.Foods.Desserts
{
    public class Cake : Dessert
    {
        private string name;
        private decimal price;
        private double grams;
        private double callories;
        private const double GRAMS = 250;
        private const double CALLS = 1000l;
        private const decimal CAKE_PRICE = 5M;

        public Cake(string name, decimal price, double grams, double callories)
            : base(name, price, grams, callories)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
            this.Calories = callories;
        }

        public string Name { get; set; }
        public override decimal Price =>
            CAKE_PRICE;
        public override double Grams =>
            GRAMS;
        public override double Calories =>
            CALLS;
    }
}
