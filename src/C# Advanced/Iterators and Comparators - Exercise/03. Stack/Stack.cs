namespace _03._Stack
{
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        public List<T> List { get; set; } = new List<T>();
        public int Count
        {
            get
            {
                return List.Count;
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = List.Count - 1; i >= 0; i--)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Push(T element)
        {
            List.Add(element);
        }
        public void Pop()
        {
            List.RemoveAt(List.Count - 1);
        }
    }
}
