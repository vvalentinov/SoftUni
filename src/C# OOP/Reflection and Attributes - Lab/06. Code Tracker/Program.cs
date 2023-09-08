namespace _06._Code_Tracker
{
    [Author("Sam")]
    public class Program
    {
        [Author("Tom")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}