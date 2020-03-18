using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.Reverse().ToArray());
            string input = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if(i < 3) Console.WriteLine("Incorrect password. Try again.");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine($"User {username} blocked!");
        }
    }
}
