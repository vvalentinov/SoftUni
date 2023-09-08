namespace _04._Collector
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAcessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}