using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] fileWithExtention = path.Substring(path.LastIndexOf("\\") + 1).Split(".");
            Console.WriteLine($"File name: {fileWithExtention[0]}\nFile extension: {fileWithExtention[1]}");
        }
    }
}
