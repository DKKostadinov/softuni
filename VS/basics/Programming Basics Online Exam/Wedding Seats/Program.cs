using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            int oddRowsSeats = int.Parse(Console.ReadLine());
            int numberOfSeats = 0;

            for (char i = 'A'; i <= sector; i++)
            {
                for (int j = 1; j <= numberOfRows; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k <= 'a'+oddRowsSeats+1; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            numberOfSeats++;
                        }
                    }
                    else
                    {
                        for (char k = 'a'; k <= 'a'+oddRowsSeats-1; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            numberOfSeats++;
                        }
                    }
                }
                numberOfRows++;
            }
            Console.WriteLine(numberOfSeats);
        }
    }
}
