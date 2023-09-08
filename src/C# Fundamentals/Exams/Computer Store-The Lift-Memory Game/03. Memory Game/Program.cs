namespace _03._Memory_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            int count = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (numbers.Count == numbers.Distinct().Count())
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    break;
                }

                if (line == "end")
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                string[] arr = line.Split();
                int firstIndex = int.Parse(arr[0]);
                int secondIndex = int.Parse(arr[1]);
                count++;

                if (firstIndex == secondIndex
                    || firstIndex < 0
                    || firstIndex >= numbers.Count
                    || secondIndex < 0
                    || secondIndex >= numbers.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int index = numbers.Count / 2;
                    string toInsert = $"-{count}a";
                    numbers.Insert(index, toInsert);
                    numbers.Insert(index, toInsert);
                    continue;
                }

                if (numbers[firstIndex] == numbers[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");
                    string item = numbers[secondIndex];
                    numbers.RemoveAt(firstIndex);
                    int indx = numbers.IndexOf(item);
                    numbers.RemoveAt(indx);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}