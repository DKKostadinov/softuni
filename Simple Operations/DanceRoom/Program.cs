using System;

namespace DanceRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var roomLength = double.Parse(Console.ReadLine());
            var roomWidth = double.Parse(Console.ReadLine());
            var wardrobeSide = double.Parse(Console.ReadLine());

            var area = roomLength * roomWidth * 0.9 - wardrobeSide * wardrobeSide;
            Console.WriteLine(Math.Floor(area / 0.7040));
        }
    }
}
