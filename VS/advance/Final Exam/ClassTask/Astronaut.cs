namespace SpaceStationRecruitment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public Astronaut(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            try
            {
                return $"Astronaut: {Name}, {Age} ({Country})";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
