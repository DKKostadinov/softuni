using System;
using System.Linq;
using System.Collections.Generic;

namespace Valid_Usernames1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernameArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernameArray.Length; i++)
            {
                string username = usernameArray[i];
                bool isValid = false;
                if ( username.Length >= 3 && username.Length <= 16)
                {
                    for (int j = 0; j < username.Length; j++)
                    {
                        char currentLetter = username[j];
                        if (char.IsLetterOrDigit(currentLetter) ||
                            currentLetter == '-' ||
                            currentLetter == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if(isValid)
                    Console.WriteLine(username);
            }

        }
    }
}