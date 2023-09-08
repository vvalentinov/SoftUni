namespace _03._Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            List<string> numbers = new List<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
            List<string> links = new List<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            foreach (string number in numbers)
            {
                bool isNumber = number.All(char.IsDigit);
                if (isNumber == false)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (number.Length == 10)
                {
                    smartphone.Call(number);
                }
                else
                {
                    stationaryPhone.Call(number);
                }
            }

            foreach (string link in links)
            {
                bool hasDigit = link.Any(char.IsDigit);
                if (hasDigit)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                smartphone.Browse(link);
            }
        }
    }
}