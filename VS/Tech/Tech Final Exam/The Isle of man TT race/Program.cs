using System;
using System.Text.RegularExpressions;

namespace The_Isle_of_man_TT_race
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                Regex nameLengthCoords = new Regex(@"(?<name>%[A-z]+%|#[A-z]+#|\*[A-z]+\*|\$[A-z]+\$|\&[A-z]+\&)=(?<length>\d+)!!(?<coords>[^\n]*)");
                if (nameLengthCoords.IsMatch(input))
                {
                    string name = nameLengthCoords.Match(input).Groups["name"].Value;
                    int length = int.Parse(nameLengthCoords.Match(input).Groups["length"].Value);
                    string coords = nameLengthCoords.Match(input).Groups["coords"].Value;
                    if (coords.Length != length)
                    {
                        Console.WriteLine("Nothing found!");
                        continue;
                    }
                    string code = string.Empty;
                    for (int i = 0; i < length; i++)
                    {
                        code += (char)(coords[i] + length);
                    }
                    Console.WriteLine($"Coordinates found! {name.Substring(1, name.Length-2)} -> {code}");
                    return;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
