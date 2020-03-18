namespace FightingArena
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Arena
    {
        private List<Gladiator> gladiators;
        private string name;

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }
        public int Count{ get {return gladiators.Count;}}

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            foreach (var item in gladiators)
            {
                if (item.Name == name)
                {
                    gladiators.Remove(item);
                    return;
                }
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator bestGladiator = gladiators[0];
            foreach (var item in gladiators)
            {
                if (bestGladiator.GetStatPower() < item.GetStatPower())
                    bestGladiator = item;
            }
            return bestGladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator bestGladiator = gladiators[0];
            foreach (var item in gladiators)
            {
                if (bestGladiator.GetWeaponPower() < item.GetWeaponPower())
                    bestGladiator = item;
            }
            return bestGladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator bestGladiator = gladiators[0];
            foreach (var item in gladiators)
            {
                if (bestGladiator.GetTotalPower() < item.GetTotalPower())
                    bestGladiator = item;
            }
            return bestGladiator;
        }

        public override string ToString()
        {
            string value = $"{Name} - {gladiators.Count} gladiators are participating.";
            return value;
        }
    }
}
