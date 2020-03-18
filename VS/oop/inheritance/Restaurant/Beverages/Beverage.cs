namespace Restaurant.Beverages
{
    public class Beverage : Product
    {
        private double milliliters;
        private string name;
        private decimal price;

        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
            this.Name = name;
            this.Price = price;
        }

        public double Milliliters { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
