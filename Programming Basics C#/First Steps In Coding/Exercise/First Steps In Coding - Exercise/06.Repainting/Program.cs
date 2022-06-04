namespace _06.Repainting
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int neededNylon = int.Parse(Console.ReadLine()) + 2;
            double neededPaint = double.Parse(Console.ReadLine());
            neededPaint += 0.10 * neededPaint;
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum = (neededNylon * 1.50) + (neededPaint * 14.50) + (thinner * 5) + 0.4;
            double workersPay = (sum * 0.3) * hours;
            Console.WriteLine(sum + workersPay);
        }
    }
}
