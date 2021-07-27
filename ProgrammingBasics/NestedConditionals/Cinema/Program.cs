using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double price = 0;
            switch (projection)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine(string.Format("{0:0.00}", (price*col*row)) + " leva");
        }
    }
}
