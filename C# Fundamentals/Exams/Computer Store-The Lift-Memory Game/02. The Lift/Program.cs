namespace _02._The_Lift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4)
                {
                    int peopleToBePut = 4 - wagons[i];

                    if (people < peopleToBePut)
                    {
                        wagons[i] = people;
                        people = 0;
                    }
                    else if (people >= peopleToBePut)
                    {
                        wagons[i] = 4;
                        people -= peopleToBePut;
                    }
                }

                if (people <= 0)
                {
                    break;
                }

                if (!HasEmptySpots(wagons))
                {
                    break;
                }
            }

            if (people <= 0 && HasEmptySpots(wagons))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else if (people > 0 && !HasEmptySpots(wagons))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else
            {
                Console.WriteLine(string.Join(' ', wagons));
            }
        }
        private static bool HasEmptySpots(int[] wagons)
        {
            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4)
                {
                    return true;
                }
            }

            return false;
        }
    }
}