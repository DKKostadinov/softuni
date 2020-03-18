namespace Restaurant.Foods
{
    public class MainDish : Food
    {
        private string name;
        private decimal price;
        private double grams;
        public MainDish(string name, decimal price, double grams) 
            : base(name, price, grams)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual double Grams { get; set; }
    }
}
