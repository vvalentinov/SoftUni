namespace _05._Date_Modifier
{
    using System;

    public class DateModifier
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            string[] firstDatearr = firstDate.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            DateTime first = new DateTime(int.Parse(firstDatearr[0]), int.Parse(firstDatearr[1]), int.Parse(firstDatearr[2]));
            string[] secondDatearr = secondDate.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            DateTime second = new DateTime(int.Parse(secondDatearr[0]), int.Parse(secondDatearr[1]), int.Parse(secondDatearr[2]));
            int difference = (int)(Math.Abs((first - second).TotalDays));
            return difference;
        }
    }
}
