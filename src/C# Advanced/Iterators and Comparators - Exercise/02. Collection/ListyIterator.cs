namespace _02._Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        public ListyIterator(List<T> list)
        {
            List = list;
        }
        public List<T> List { get; set; }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index == List.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Print()
        {
            if (List.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(List[index]);
            }
        }
        public void PrintAll()
        {
            foreach (var item in List)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
