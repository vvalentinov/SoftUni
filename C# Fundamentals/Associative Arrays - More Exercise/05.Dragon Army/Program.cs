namespace _05.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Dragon
        {
            public Dragon(string name, int damage, int health, int armor)
            {
                this.Name = name;
                this.Damage = damage;
                this.Health = health;
                this.Armor = armor;
            }
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] dragonData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = dragonData[0];
                string name = dragonData[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                bool successDamage = int.TryParse(dragonData[2], out damage);
                bool successHealth = int.TryParse(dragonData[3], out health);
                bool successArmor = int.TryParse(dragonData[4], out armor);
                if (!successDamage)
                {
                    damage = 45;
                }
                if (!successHealth)
                {
                    health = 250;
                }
                if (!successArmor)
                {
                    armor = 10;
                }
                if (dragons.ContainsKey(type))
                {
                    Dragon dragon = dragons[type].FirstOrDefault(x => x.Name == name);
                    if (dragon == null)
                    {
                        dragons[type].Add(new Dragon(name, damage, health, armor));
                    }
                    else
                    {
                        dragon.Damage = damage;
                        dragon.Armor = armor;
                        dragon.Health = health;
                    }
                }
                else
                {
                    dragons.Add(type, new List<Dragon>());
                    dragons[type].Add(new Dragon(name, damage, health, armor));
                }
            }

            foreach (var item in dragons)
            {
                string type = item.Key;
                var avgDamage = item.Value.Select(x => x.Damage).Average();
                var avgHealth = item.Value.Select(x => x.Health).Average();
                var avgArmor = item.Value.Select(x => x.Armor).Average();
                Console.WriteLine($"{type}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");
                foreach (var dragon in item.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
