﻿namespace _04._Random_List
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        private Random rnd;
        public RandomList()
        {
            rnd = new Random();
        }
        public string RandomString()
        {
            int index = rnd.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
