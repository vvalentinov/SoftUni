namespace _08._Threeuple
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] personContactInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (personContactInfo.Length % 2 == 0)
            {
                string fullName = $"{personContactInfo[0]} {personContactInfo[1]}";
                string address = personContactInfo[2];
                string town = personContactInfo[3];
                Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, address, town);
                Console.WriteLine(firstTuple.ToString());
            }
            else
            {
                string fullName = $"{personContactInfo[0]} {personContactInfo[1]}";
                string address = personContactInfo[2];
                string town = $"{personContactInfo[3]} {personContactInfo[4]}";
                Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, address, town);
                Console.WriteLine(firstTuple.ToString());
            }

            string[] personData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = personData[0];
            int litresBeer = int.Parse(personData[1]);
            bool isDrunk = personData[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(name, litresBeer, isDrunk);
            Console.WriteLine(secondTuple.ToString());

            string[] personBankInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string personName = personBankInfo[0];
            double accountBalance = double.Parse(personBankInfo[1]);
            string bank = personBankInfo[2];

            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(personName, accountBalance, bank);



            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
