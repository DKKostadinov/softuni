namespace Restaurant.Beverages
{
    public class ColdBeverage : Beverage
    {

        private double milliliters;
        private string name;
        private decimal price;

        public ColdBeverage(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {

        }


        public double Milliliters { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }

    }
}
