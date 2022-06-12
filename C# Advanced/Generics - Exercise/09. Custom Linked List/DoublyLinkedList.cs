namespace _09._Custom_Linked_List
{
    using System;

    public class DoublyLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }
        public int Count { get; set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                Head = Tail = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newHead = new ListNode<T>(element);
                newHead.NextNode = Head;
                Head.PreviousNode = newHead;
                Head = newHead;
            }
            Count++;
        }
        public void AddLast(T element)
        {
            if (Count == 0)
            {
                Head = Tail = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newTail = new ListNode<T>(element);
                newTail.PreviousNode = Tail;
                Tail.NextNode = newTail;
                Tail = newTail;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T element = Head.Value;
            Head = Head.NextNode;
            if (Head != null)
            {
                Head.PreviousNode = null;
            }
            else
            {
                Tail = null;
            }
            Count--;
            return element;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T element = Tail.Value;
            Tail = Tail.PreviousNode;
            if (Tail != null)
            {
                Tail.NextNode = null;
            }
            else
            {
                Head = null;
            }
            Count--;
            return element;
        }

        public void ForEach(Action<T> action)
        {
            ListNode<T> current = Head;
            while (current != null)
            {
                action(current.Value);
                current = current.NextNode;
            }
        }
        public T[] ToArray()
        {
            T[] result = new T[Count];
            int counter = 0;
            ListNode<T> current = Head;
            while (current != null)
            {
                result[counter] = current.Value;
                current = current.NextNode;
                counter++;
            }
            return result;
        }
    }
}
