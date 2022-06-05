namespace _04.Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Dwarf
        {
            public Dwarf(string name, string hatcolor, int physics)
            {
                this.Name = name;
                this.HatColor = hatcolor;
                this.Physics = physics;
            }
            public string Name { get; }
            public string HatColor { get; }
            public int Physics { get; set; }
        }
        static void Main(string[] args)
        {
            List<Dwarf> dwarves = new List<Dwarf>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Once upon a time")
                {
                    foreach (Dwarf item in dwarves.OrderByDescending(x => x.Physics).ThenByDescending(x => dwarves.Count(y => y.HatColor == x.HatColor)))
                    {
                        Console.WriteLine($"({item.HatColor}) {item.Name} <-> {item.Physics}");
                    }
                    break;
                }
                string[] dwarfData = line.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = dwarfData[0];
                string hatColor = dwarfData[1];
                int physics = int.Parse(dwarfData[2]);
                Dwarf dwarf = dwarves.Find(x => x.Name == name && x.HatColor == hatColor);
                if (dwarf == null)
                {
                    Dwarf toBeAdded = new Dwarf(name, hatColor, physics);
                    dwarves.Add(toBeAdded);
                }
                else
                {
                    dwarf.Physics = Math.Max(dwarf.Physics, physics);
                }
            }
        }
    }
}
