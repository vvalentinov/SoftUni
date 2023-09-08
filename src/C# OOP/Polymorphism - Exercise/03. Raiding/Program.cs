namespace _03._Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> raidGroup = new List<BaseHero>();
            while (true)
            {
                if (raidGroup.Count == n)
                {
                    break;
                }
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if (type != "Druid" && type != "Paladin" && type != "Rogue" && type != "Warrior")
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                switch (type)
                {
                    case "Druid":
                        Druid druid = new Druid(name);
                        raidGroup.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(name);
                        raidGroup.Add(paladin);
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(name);
                        raidGroup.Add(rogue);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(name);
                        raidGroup.Add(warrior);
                        break;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            raidGroup.ForEach(x => Console.WriteLine(x.CastAbility()));
            int sum = raidGroup.Select(x => x.Power).Sum();
            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}