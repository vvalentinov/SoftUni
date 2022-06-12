namespace _05._Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;

    public class Box<T> where T : IComparable
    {
        public Box(List<T> list)
        {
            List = list;
        }
        public List<T> List { get; set; }

        public int GetCount(T value)
        {
            int count = 0;

            foreach (var currValue in List)
            {
                if (value.CompareTo(currValue) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
