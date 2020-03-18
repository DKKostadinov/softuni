namespace Restaurant.Foods.Mains
{
    public class Fish : MainDish
    {
        private string name;
        private decimal price;
        private const double GRAMS = 22;

        public Fish(string name, decimal price, double grams)
            : base(name, price, grams)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public override double Grams =>
            GRAMS;

    }
}
