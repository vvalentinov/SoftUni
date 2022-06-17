namespace _02._Validation_Attributes.CustomAttributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
