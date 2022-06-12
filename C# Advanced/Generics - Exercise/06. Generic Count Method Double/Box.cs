namespace _06._Generic_Count_Method_Double
{
    using System.Collections.Generic;

    public class Box<T>
    {
        public Box(List<T> list)
        {
            List = list;
        }
        public List<T> List { get; set; }

        public int GetCount(double number)
        {
            int count = 0;
            foreach (var item in List)
            {
                if (number.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
