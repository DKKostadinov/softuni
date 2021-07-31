using System;

namespace SamePair
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPairs = double.Parse(Console.ReadLine());
            bool sameValue = true;
            double lastSum = double.MinValue;
            double maxDiff = 0;
            for (int i = 0; i < numberOfPairs; i++)
            {
                double sum = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine());
                lastSum = (lastSum == double.MinValue) ? sum : lastSum;
                if (lastSum != sum)
                {
                    sameValue = false;
                    maxDiff = Math.Abs(sum - lastSum);
                }
                lastSum = sum;
            }
            if (sameValue) Console.WriteLine($"Yes, value={lastSum}");
            else Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
