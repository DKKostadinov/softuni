namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Salad
    {
        private List<Vegetable> products;
        private string name;

        public Salad(string name)
        {
            Name = name;
            products = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int GetTotalCalories()
        {
            int sumOfCalories = 0;
            foreach (var product in products)
            {
                sumOfCalories += product.Calories;
            }
            return sumOfCalories;
        }

        public int GetProductCount()
        {
            return products.Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            string value = $"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:";
            foreach (var product in products)
            {
                value += $"\n{product}";
            }
            return value;
        }
    }
}
