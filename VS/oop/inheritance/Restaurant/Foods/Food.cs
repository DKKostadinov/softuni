namespace Restaurant.Foods
{
    public class Food : Product
    {
        private string name;
        private decimal price;
        private double grams;

        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            this.Grams = grams;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Grams { get; set; }
    }
}
