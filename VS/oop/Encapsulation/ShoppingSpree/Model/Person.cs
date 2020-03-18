namespace ShoppingSpree.Model
{
    using System;
    using System.Collections.Generic;
    using ShoppingSpree.Exceptions;
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NonEmptyName);
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NonNegativeCost);
                }
                this.money = value;
            }
        }

        private void AddProductToBag(Product product)
        {
            bagOfProducts.Add(product);
        }
        public void BuyProduct(Product product)
        {
            if (money - product.Cost >= 0)
            {
                money -= product.Cost;
                AddProductToBag(product);
                Console.WriteLine($"{this.Name} bought {product}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product}");
            }
        }
        public override string ToString()
        {
            string value = $"{this.Name} - ";
            if (bagOfProducts.Count > 0)
            {
                value += string.Join(", ", bagOfProducts);
            }
            else
            {
                value += "Nothing bought";
            }
            return value;
        }
    }
}
