namespace Restaurant.Foods
{
    public class Starter : Food
    {
        private string name;
        private decimal price;
        private double grams;

        public Starter(string name, decimal price, double grams) 
            : base(name, price, grams)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Grams { get; set; }
    }
}
