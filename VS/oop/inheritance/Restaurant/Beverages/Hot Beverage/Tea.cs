namespace Restaurant.Beverages.Hot_Beverage
{
    public class Tea : HotBeverage
    {
        private double milliliters;
        private string name;
        private decimal price;

        public Tea(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }

        public double Milliliters { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
