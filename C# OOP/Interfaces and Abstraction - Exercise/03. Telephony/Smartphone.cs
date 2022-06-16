namespace _03._Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public void Browse(string link)
        {
            Console.WriteLine($"Browsing: {link}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... { number}");
        }
    }
}
