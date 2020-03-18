namespace Restaurant.Beverages.Hot_Beverage
{
    public class Coffee : HotBeverage
    {
        private const double COFFEE_MILLILITERS = 50;
        private const decimal COFFEE_PRICE = 3.50M;
        private double caffeine;
        private double milliliters;
        private string name;
        private decimal price;

        public Coffee(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }

        public double Caffeine { get; set; }
        public override double Milliliters =>
            COFFEE_MILLILITERS;
        public override decimal Price =>
            COFFEE_PRICE;
        public string Name { get; set; }
    }
}
