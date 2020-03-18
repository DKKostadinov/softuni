using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            byte ageOfPerson = byte.Parse(Console.ReadLine());
            if (ageOfPerson <= 2) Console.WriteLine("baby");
            else if (ageOfPerson <= 13) Console.WriteLine("child");
            else if (ageOfPerson <= 19) Console.WriteLine("teenager");
            else if (ageOfPerson <= 65) Console.WriteLine("adult");
            else Console.WriteLine("elder");
        }
    }
}
