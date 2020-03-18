namespace Restaurant.Beverages
{
    public class HotBeverage : Beverage
    {
        private double milliliters;
        private string name;
        private decimal price;

        public HotBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {

        }

        public virtual double Milliliters { get; set; }
        public virtual decimal Price { get; set; }
        public string Name { get; set; }
    }
}
