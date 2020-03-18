namespace Restaurant.Foods.Starters
{
    public class Soup : Starter
    {

        private string name;
        private decimal price;
        private double grams;

        public Soup(string name, decimal price, double grams) 
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
