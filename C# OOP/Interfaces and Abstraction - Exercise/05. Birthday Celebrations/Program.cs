namespace _05._Birthday_Celebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<string> birthdates = new List<string>();
            while (line != "End")
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] == "Citizen")
                {
                    ICitizen citizen = new Citizen(parts[1], int.Parse(parts[2]), parts[3], parts[4]);
                    birthdates.Add(citizen.Birthdate);
                }
                else if (parts[0] == "Pet")
                {
                    IPet pet = new Pet(parts[1], parts[2]);
                    birthdates.Add(pet.Birthdate);
                }
                line = Console.ReadLine();
            }
            string specificYear = Console.ReadLine();
            birthdates = birthdates.Where(x => x.EndsWith(specificYear)).ToList();
            if (birthdates.Count > 0)
            {
                foreach (string year in birthdates)
                {
                    Console.WriteLine(year);
                }
            }
        }
    }
}