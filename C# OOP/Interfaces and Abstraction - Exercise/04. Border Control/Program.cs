namespace _04._Border_Control
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<string> ids = new List<string>();
            while (line != "End")
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3)
                {
                    ICitizen citizen = new Citizen(parts[0], int.Parse(parts[1]), parts[2]);
                    ids.Add(citizen.Id);
                }
                else
                {
                    IRobot robot = new Robot(parts[0], parts[1]);
                    ids.Add(robot.Id);
                }
                line = Console.ReadLine();
            }
            string fakeId = Console.ReadLine();
            ids = ids.Where(x => x.EndsWith(fakeId)).ToList();
            foreach (string id in ids)
            {
                Console.WriteLine(id);
            }
        }
    }
}