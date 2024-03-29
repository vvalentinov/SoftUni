﻿namespace _03._Generic_Scale
{
    public class EqualityScale<T>
    {
        private T first;
        private T second;

        public EqualityScale(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public bool AreEqual()
        {
            return first.Equals(second);
        }
    }
}
