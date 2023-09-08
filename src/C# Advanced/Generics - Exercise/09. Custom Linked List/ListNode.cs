namespace _09._Custom_Linked_List
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public ListNode<T> NextNode { get; set; }

        public ListNode<T> PreviousNode { get; set; }
    }
}
