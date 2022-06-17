namespace _01._Stealer
{
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, params string[] fields)
        {
            Type classType = Type.GetType(nameOfClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder builder = new StringBuilder();
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            builder.AppendLine($"Class under investigation: {nameOfClass}");
            foreach (FieldInfo field in classFields.Where(x => fields.Contains(x.Name)))
            {
                builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return builder.ToString().Trim();
        }
    }
}
