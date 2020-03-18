using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidate(Console.ReadLine());
        }

        static void PasswordValidate(string inputPassword)
        {
            bool isPassOnlyLettersAndNumbers = true;
            int numberCountInPass = 0;
            foreach (var symbol in inputPassword)
            {
                if (!((symbol >= '0' && symbol <= '9') || (symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z')))
                    isPassOnlyLettersAndNumbers = false;
                if (symbol >= '0' && symbol <= '9')
                    numberCountInPass++;
            }
            if (inputPassword.Length < 6 || inputPassword.Length > 10)
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (isPassOnlyLettersAndNumbers == false)
                Console.WriteLine("Password must consist only of letters and digits");
            if (numberCountInPass < 2)
                Console.WriteLine("Password must have at least 2 digits");
            if(!(inputPassword.Length < 6 || inputPassword.Length > 10) && !(isPassOnlyLettersAndNumbers == false) && !(numberCountInPass < 2))
                Console.WriteLine("Password is valid");
        }
    }
}
