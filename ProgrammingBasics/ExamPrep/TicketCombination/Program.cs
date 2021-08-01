using System;

namespace TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 'B'; i <= 'L'; i++)
            {
                for (int j = 'f'; j >= 'a'; j--)
                {
                    for (int k = 'A'; k <= 'C'; k++)
                    {
                        for (int l = 1; l <= 10; l++)
                        {
                            for (int m = 10; m >= 1; m--)
                            {
                                if(i % 2 == 0)count++;
                                if (count == num)
                                {
                                    Console.WriteLine($"Ticket combination: {(char)i}{(char)j}{(char)k}{l}{m}");
                                    Console.WriteLine($"Prize: {i+j+k+l+m} lv.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
