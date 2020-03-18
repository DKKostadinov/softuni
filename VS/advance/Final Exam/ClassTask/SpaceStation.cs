namespace SpaceStationRecruitment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> data;
        private string name;
        private int capacity;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Astronaut astronaut)
        {
            try
            {
                if (data.Count < Capacity)
                {
                    data.Add(astronaut);
                }

            }
            catch (Exception)
            {
            }
        }

        public bool Remove(string name)
        {
            try
            {
                foreach (var item in data)
                {
                    if (item.Name == name)
                    {
                        data.Remove(item);
                        return true;
                    }
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            try
            {
                Astronaut oldestAstrounat = new Astronaut("a", -1, "b");
                foreach (var astr in data)
                {
                    if (astr.Age > oldestAstrounat.Age)
                        oldestAstrounat = astr;
                }
                return oldestAstrounat;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Astronaut GetAstronaut(string name)
        {
            try
            {
                foreach (var item in data)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Report()
        {
            
            try
            {
                string retValue = "Astronauts working at Space Station {spaceStationName}:\n";
                foreach (var item in data)
                {
                    retValue += item;
                    retValue += "\n";
                }
                return retValue;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
