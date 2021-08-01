using System;

namespace FootbalSouveniers
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double[,] priceTable = new double[4, 4]
            { { 3.25, 4.20, 2.75, 3.10 },
            { 7.20, 8.50, 6.90, 6.50 },
            { 5.10, 5.35, 4.95, 4.80},
            { 1.25, 1.20, 1.10, 0.90} };
            int row = -1;
            int col = -1;
            switch (country)
            {
                case "Argentina":
                    col = 0;
                    break;
                case "Brazil":
                    col = 1;
                    break;
                case "Croatia":
                    col = 2;
                    break;
                case "Denmark":
                    col = 3;
                    break;
                default:
                    break;
            }
            switch (type)
            {
                case "flags":
                    row = 0;
                    break;
                case "caps":
                    row = 1;
                    break;
                case "posters":
                    row = 2;
                    break;
                case "stickers":
                    row = 3;
                    break;
                default:
                    break;
            }
            if (col == -1)
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            if (row == -1)
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
            Console.WriteLine($"Pepi bought {count} {type} of {country} for {count*priceTable[row,col]:0.00} lv.");
        }
    }
}
