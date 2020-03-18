namespace ShoppingSpree
{
    using ShoppingSpree.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> peopleAndMoney = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> productsAndCost = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            try
            {
                List<Person> peopleInStore = new List<Person>();
                List<Product> products = new List<Product>();
                foreach (var item in peopleAndMoney)
                {
                    string name = item.Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal money = decimal.Parse(item.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                    Person person = new Person(name, money);
                    peopleInStore.Add(person);
                }
                foreach (var item in productsAndCost)
                {
                    string name = item.Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal cost = decimal.Parse(item.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }
                    string buyerName = input.Split(" ")[0];
                    string productName = input.Split(" ")[1];
                    Person buyer = peopleInStore.Find(x => x.Name == buyerName);
                    Product product = products.Find(x => x.Name == productName);
                    buyer.BuyProduct(product);
                }
                foreach (var item in peopleInStore)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
