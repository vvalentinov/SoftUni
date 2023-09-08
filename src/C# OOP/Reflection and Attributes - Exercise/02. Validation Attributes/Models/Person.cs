namespace _02._Validation_Attributes.Models
{
    using _02._Validation_Attributes.CustomAttributes;

    public class Person
    {
        public Person(string fullname, int age)
        {
            this.FullName = fullname;
            this.Age = age;
        }
        [MyRequiredAttribute]
        public string FullName { get; set; }
        [MyRangeAttribute(12, 90)]
        public int Age { get; set; }
    }
}
