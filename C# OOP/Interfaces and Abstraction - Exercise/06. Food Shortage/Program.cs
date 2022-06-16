namespace _06._Food_Shortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Rebel> rebles = new List<Rebel>();
            List<Citizen> citizens = new List<Citizen>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    rebles.Add(rebel);
                }
            }
            int citizenFood = 0;
            int rebelFood = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                IBuyer citizen = citizens.FirstOrDefault(x => x.Name == line);
                if (citizen != null)
                {
                    citizen.BuyFood();
                    citizenFood += 10;
                    continue;
                }
                IBuyer rebel = rebles.FirstOrDefault(x => x.Name == line);
                if (rebel != null)
                {
                    rebel.BuyFood();
                    rebelFood += 5;
                    continue;
                }
            }
            Console.WriteLine(citizenFood + rebelFood);
        }
    }
}