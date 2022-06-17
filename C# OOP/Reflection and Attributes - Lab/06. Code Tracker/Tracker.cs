namespace _06._Code_Tracker
{
    using System.Reflection;

    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(Program);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine("{0} is written by {1}", method.Name, attribute.Name);
                    }
                }
            }
        }
    }
}
