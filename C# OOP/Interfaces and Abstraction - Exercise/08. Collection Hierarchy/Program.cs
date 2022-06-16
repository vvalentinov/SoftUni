namespace _08._Collection_Hierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] lines = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string resultAddCollection = string.Empty;
            foreach (string item in lines)
            {
                int index = addCollection.Add(item);
                resultAddCollection += $"{index} ";
            }
            Console.WriteLine(resultAddCollection.TrimEnd());

            string resultAddRemoveCollection = string.Empty;
            foreach (string item in lines)
            {
                int index = addRemoveCollection.Add(item);
                resultAddRemoveCollection += $"{index} ";
            }
            Console.WriteLine(resultAddRemoveCollection.TrimEnd());

            string resultMyList = string.Empty;
            foreach (string item in lines)
            {
                int index = myList.Add(item);
                resultMyList += $"{index} ";
            }
            Console.WriteLine(resultMyList.TrimEnd());

            int n = int.Parse(Console.ReadLine());

            string resultOne = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string result = addRemoveCollection.Remove();
                resultOne += $"{result} ";
            }
            Console.WriteLine(resultOne.TrimEnd());

            string resultTwo = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string result = myList.Remove();
                resultTwo += $"{result} ";
            }
            Console.WriteLine(resultTwo.TrimEnd());
        }
    }
}