namespace _04._Collector
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
            Object classInstance = Activator.CreateInstance(classType, new object[] { });
            builder.AppendLine($"Class under investigation: {nameOfClass}");
            foreach (FieldInfo field in classFields.Where(x => fields.Contains(x.Name)))
            {
                builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return builder.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder builder = new StringBuilder();
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (FieldInfo field in classFields)
            {
                builder.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                builder.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(x => x.Name.StartsWith("set")))
            {
                builder.AppendLine($"{method.Name} have to be private!");
            }
            return builder.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"All Private Methods of Class: {className}");
            builder.AppendLine($"Base Class: {classType.BaseType.Name}");
            foreach (MethodInfo method in classMethods)
            {
                builder.AppendLine(method.Name);
            }
            return builder.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            StringBuilder builder = new StringBuilder();
            foreach (MethodInfo method in classMethods.Where(x => x.Name.StartsWith("get")))
            {
                builder.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (MethodInfo method in classMethods.Where(x => x.Name.StartsWith("set")))
            {
                builder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return builder.ToString().Trim();
        }
    }
}
