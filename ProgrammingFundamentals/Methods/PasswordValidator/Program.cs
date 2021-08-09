using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            PassValidator(Console.ReadLine());
        }
        static void PassValidator(string pass)
        {
            bool isValid = true;
            if (!(pass.Length > 5 && pass.Length < 11))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!(pass.All(Char.IsLetterOrDigit)))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (NumberOfDigitsInString(pass) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid) Console.WriteLine("Password is valid");
        }
        static int NumberOfDigitsInString(string text)
        {
            int count = 0;
            foreach (var item in text)
            {
                if (item >= '0' && item <= '9') count++;
            }
            return count;
        }
    }
}
