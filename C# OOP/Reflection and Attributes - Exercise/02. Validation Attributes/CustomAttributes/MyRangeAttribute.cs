namespace _02._Validation_Attributes.CustomAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            if (obj is int == false)
            {
                throw new ArgumentException("Invalid data type");
            }
            int valueIsInt = (int)obj;
            bool isInRange = valueIsInt >= minValue && valueIsInt <= maxValue;
            if (isInRange == false)
            {
                return false;
            }
            return true;
        }
    }
}
