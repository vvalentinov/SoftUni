namespace _01._Generic_Box_of_String
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}
