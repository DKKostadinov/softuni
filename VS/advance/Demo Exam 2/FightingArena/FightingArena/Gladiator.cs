namespace FightingArena
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Gladiator
    {
        private string name;
        private Stat stat;
        private Weapon weapon;

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int totalValue = 0;
            totalValue = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            totalValue = totalValue + Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return totalValue;
        }

        public int GetWeaponPower()
        {
            int totalValue = 0;
            totalValue = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return totalValue;
        }

        public int GetStatPower()
        {
            int totalValue = 0;
            totalValue = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return totalValue;
        }

        public override string ToString()
        {
            string value = $"{Name} - {GetTotalPower()}\n";
            value += $"  Weapon Power: {GetWeaponPower()}";
            value += $"  Stat Power: {GetStatPower()}";
            return value;
        }
    }
}
