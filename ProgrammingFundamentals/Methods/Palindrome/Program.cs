using System;


namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                Console.WriteLine(IsPalindrome(int.Parse(input)));
            }
        }
        static bool IsPalindrome(int n)
        {
            string forward = n.ToString();
            var backwardArr = n.ToString().ToCharArray();
            Array.Reverse(backwardArr);
            string backward = String.Join("", backwardArr);
            if (forward == backward) return true;
            else return false;
        }
    }
}
