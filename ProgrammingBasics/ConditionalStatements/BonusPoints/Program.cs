using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Ако числото е до 100 включително, бонус точките са 5.
•	Ако числото е по-голямо от 100, бонус точките са 20% от числото.
•	Ако числото е по-голямо от 1000, бонус точките са 10% от числото.
•	Допълнителни бонус точки (начисляват се отделно от предходните):
o	За четно число  + 1 т.
o	За число, което завършва на 5  + 2 т.
*/
            var input = int.Parse(Console.ReadLine());
            double bonus;

            if (input <= 100)
            {
                bonus = 5;
            }
            else if (input <= 1000)
            {
                bonus = input * 0.2;
            }
            else
            {
                bonus = input * 0.1;
            }

            if (input % 2 == 0)
            {
                bonus++;
            }

            if (input % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(input + bonus);
        }
    }
}
