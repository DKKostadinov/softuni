using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                string type = "";
                try
                {
                    int.Parse(input);
                    type = "integer";
                }
                catch (Exception)
                {
                }
                if (type == "")
                {
                    try
                    {
                        double.Parse(input);
                        type = "floating point";
                    }
                    catch (Exception)
                    {
                    }
                }

                if (type == "")
                {
                    try
                    {
                        char.Parse(input);
                        type = "character";
                    }
                    catch (Exception)
                    {
                    }
                }
                if (input == "true" || input == "false")
                {
                    type = "boolean";
                }
                if (type == "")
                {
                    type = "string";
                }
                Console.WriteLine($"{input} is {type} type");
            }
        }
    }
}
