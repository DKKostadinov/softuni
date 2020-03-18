using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string tab = string.Empty;
            int flag = 0;
            for (int i = 0; i < numberOfTabs; i++)
            {
                tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }
                if (salary <= 0)
                {
                    flag = 1;
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (flag == 0) Console.WriteLine(salary);
        }
    }
}
