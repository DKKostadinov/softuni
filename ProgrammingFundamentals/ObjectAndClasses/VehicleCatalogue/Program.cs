using System;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = inputArr[0];
                string model = inputArr[1];
                string color = inputArr[2];
                int horsepower = int.Parse(inputArr[3]);
                vehicles.Add(new Vehicle(type, model, color, horsepower));
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue") break;
                Vehicle currentVehicle = vehicles.Find(x => x.Model == input);
                Console.WriteLine($"Type: {currentVehicle.Type}\nModel: {CapitalizeFirstLetter(currentVehicle.Type)}\nColor: {currentVehicle.Color}\nHorsepower: {currentVehicle.Horsepower}");
            }
            int numOfCars = 0;
            int numbOfTrucks = 0;
            double combinedCarHP = 0;
            double combinedTruckHP = 0;
            foreach (var vehicle in vehicles)
            {
                if(vehicle.Type == "car")
                {
                    numOfCars++;
                    combinedCarHP += vehicle.Horsepower;
                }
                else
                {
                    numbOfTrucks++;
                    combinedTruckHP += vehicle.Horsepower;
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {combinedCarHP/numOfCars:0.00}.");
            Console.WriteLine($"Trucks have average horsepower of: {combinedTruckHP/numbOfTrucks:0.00}.");
        }

        static string CapitalizeFirstLetter(string input)
        {
            string output = "";
            output += input.Substring(0,1).ToUpper();
            output += input[1..].ToLower();
            return output;
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; }
        public string Model { get; }
        public string Color { get; }
        public int Horsepower { get; }
    }
}
