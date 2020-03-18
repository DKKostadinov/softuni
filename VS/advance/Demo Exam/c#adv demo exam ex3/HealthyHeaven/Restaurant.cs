namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Restaurant
    {
        private List<Salad> data;
        private string name;

        public Restaurant(string name)
        {
            Name = name;
            data = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            foreach (var salad in data)
            {
                if (salad.Name == name)
                {
                    data.Remove(salad);
                    return true;
                }
            }
            return false;
        }

        public Salad GetHealthiestSalad()
        {
            int leastCals = int.MaxValue;
            Salad bestSalad = new Salad("a");
            foreach (var item in data)
            {
                if (item.GetTotalCalories() < leastCals)
                {
                    leastCals = item.GetTotalCalories();
                    bestSalad = item;
                }
            }
            return bestSalad;
        }

        public string GenerateMenu()
        {
            string value = $"{Name} have {data.Count} salads:";
            foreach (var item in data)
            {
                value += $"\n{item}";
            }
            return value;
        }
    }
}
