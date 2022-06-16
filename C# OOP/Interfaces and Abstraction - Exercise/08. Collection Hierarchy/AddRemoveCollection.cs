namespace _08._Collection_Hierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private readonly List<string> data;
        public AddRemoveCollection()
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
            string item = this.data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }
    }
}
