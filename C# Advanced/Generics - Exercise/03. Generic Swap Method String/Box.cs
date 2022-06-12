namespace _03._Generic_Swap_Method_String
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box(List<T> values)
        {
            Values = values;
        }
        public List<T> Values { get; set; } = new List<T>();

        public void Swap(int firstIdx, int secondIdx)
        {
            T tempValue = Values[firstIdx];
            Values[firstIdx] = Values[secondIdx];
            Values[secondIdx] = tempValue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }
    }
}
