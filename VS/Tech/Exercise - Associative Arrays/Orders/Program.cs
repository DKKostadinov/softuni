using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{name} {price} {quantity}".
            var productQuantity = new Dictionary<string, int>();
            var productPrice = new Dictionary<string, double>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                List<string> inputList = input
                    .Split(" ")
                    .ToList();
                string nameOfProduct = inputList[0];
                double priceOfProduct = double.Parse(inputList[1]);
                int quantityOfProduct = int.Parse(inputList[2]);

                if (!productPrice.ContainsKey(nameOfProduct) && !productQuantity.ContainsKey(nameOfProduct))
                {
                    productPrice.Add(nameOfProduct, priceOfProduct);
                    productQuantity.Add(nameOfProduct, quantityOfProduct);
                }
                else
                {
                    productQuantity[nameOfProduct] += quantityOfProduct;
                    productPrice[nameOfProduct] = priceOfProduct;
                }
            }

            foreach (var product in productQuantity)
            {
                Console.WriteLine($"{product.Key} -> {product.Value * productPrice[product.Key]:f2}");
            }
        }
    }
}
