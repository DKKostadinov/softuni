using System;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            double money = 0;
            int fishCaught = 0;
            for (int i = 1; i <= quota; i++)
            {
                fishCaught++;
                string name = Console.ReadLine();
                if (name == "Stop")
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
                double kgs = double.Parse(Console.ReadLine());
                double tax = 0;
                foreach (char letter in name)
                {
                    tax += letter;
                }
                tax /= kgs;
                if (i % 3 == 0) money += tax;
                else money -= tax;
            }
            if (money > 0)
            {
                Console.WriteLine($"Lyubo's profit from {fishCaught} fishes is {money:f2} leva.");
            }
            else Console.WriteLine($"Lyubo lost {Math.Abs(money):f2} leva today.");
        }
    }
}
