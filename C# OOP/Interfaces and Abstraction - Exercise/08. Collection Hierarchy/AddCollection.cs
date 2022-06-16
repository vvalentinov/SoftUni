namespace _08._Collection_Hierarchy
{
    public class AddCollection : IAddCollection
    {
        private readonly List<string> data;
        public AddCollection()
        {
            data = new List<string>(100);
        }
        public int Add(string item)
        {
            data.Add(item);
            return data.Count - 1;
        }
    }
}
