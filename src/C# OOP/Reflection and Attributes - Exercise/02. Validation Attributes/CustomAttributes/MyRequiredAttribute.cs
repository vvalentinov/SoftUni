namespace _02._Validation_Attributes.CustomAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
