namespace ClassBoxData
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(System.Console.ReadLine());
            double width = double.Parse(System.Console.ReadLine());
            double heigth = double.Parse(System.Console.ReadLine());

            try
            {
                Box box = new Box(length, width, heigth);
                Console.WriteLine(box.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
