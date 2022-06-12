namespace _04._Generic_Swap_Method_Integer
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box(List<T> list)
        {
            List = list;
        }
        public List<T> List { get; set; } = new List<T>();

        public void Swap(int first, int second)
        {
            T temp = List[first];
            List[first] = List[second];
            List[second] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in List)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
    }
}
