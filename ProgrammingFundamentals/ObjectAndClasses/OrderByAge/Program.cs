using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                string[] inputArr = input.Split(" ");
                string name = inputArr[0];
                string id = inputArr[1];
                int age = int.Parse(inputArr[2]);
                people.Add(new Person(name, id, age));
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; }
        public string Id { get; }
        public int Age { get; }
    }
}
