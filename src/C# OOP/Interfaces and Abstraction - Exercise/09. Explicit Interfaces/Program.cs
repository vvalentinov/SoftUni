namespace _09._Explicit_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Citizen citizen = new Citizen(parts[0], parts[1], int.Parse(parts[2]));
                IPerson person = citizen;
                IResident resident = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}