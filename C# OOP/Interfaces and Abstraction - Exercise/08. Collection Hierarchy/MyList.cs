namespace _08._Collection_Hierarchy
{
    public class MyList : IMyList
    {
        private readonly List<string> data;
        public MyList()
        {
            data = new List<string>();
        }
        public int Add(string item)
        {
            data.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string item = data[0];
            data.RemoveAt(0);
            return item;
        }

        public int Used()
        {
            return data.Count;
        }
    }
}
