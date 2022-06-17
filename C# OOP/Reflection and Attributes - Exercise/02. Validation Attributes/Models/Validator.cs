namespace _02._Validation_Attributes.Models
{
    using _02._Validation_Attributes.CustomAttributes;
    using System.Reflection;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute customAttribute = (MyValidationAttribute)property.GetCustomAttribute(typeof(MyValidationAttribute), false);
                bool isValid = customAttribute.IsValid(property.GetValue(obj));
                if (isValid == false)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
