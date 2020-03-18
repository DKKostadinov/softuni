namespace Restaurant.Foods
{
    public class Dessert : Food
    {
        private string name;
        private decimal price;
        private double grams;
        private double calories;

        public Dessert(string name, decimal price, double grams, double calories) 
            : base(name, price, grams)
        {
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
            this.Calories = calories;
        }

        public string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual double Grams { get; set; }
        public virtual double Calories { get; set; }
    }
}
