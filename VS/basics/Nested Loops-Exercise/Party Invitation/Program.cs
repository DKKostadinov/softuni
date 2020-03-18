using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Invitation
{
    class Program
    {
        static void Main(string[] args)
        {
            int validNames = 0;
            int invalidNames = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Statistic") break;
                name = name.ToLower();
                bool flag = false;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] < 'a' || name[i] > 'z') flag = true;
                }
                if (flag == true)
                {
                    invalidNames++;
                    Console.WriteLine("Invalid name!");
                }
                else
                {
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    validNames++;
                    Console.WriteLine(name);
                }
                
            }
            Console.WriteLine($"Valid names are {(double)validNames/(validNames+invalidNames)*100:f2}% from {validNames+invalidNames} names.");
            Console.WriteLine($"Invalid names are {(double)invalidNames/(validNames+invalidNames)*100:f2}% from {validNames+invalidNames} names.");
        }
    }
}
