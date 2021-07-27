using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            switch (time)
            {
                case "Morning":
                    if (temp <= 18)
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "Sweatshirt", "Sneakers"));
                    }
                    else if (temp <= 24)
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "Shirt", "Moccasins"));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "T-Shirt", "Sandals"));
                    }
                    break;
                case "Afternoon":
                    if (temp <= 18)
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "Shirt", "Moccasins"));
                    }
                    else if (temp <= 24)
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "T-Shirt", "Sandals"));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "Swim Suit", "Barefoot"));
                    }
                    break;
                case "Evening":
                        Console.WriteLine(String.Format("It's {0} degrees, get your {1} and {2}.", temp, "Shirt", "Moccasins"));
                    break;
                default:
                    break;
            }
        }
    }
}
