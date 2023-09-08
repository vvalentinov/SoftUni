namespace _01._Persons
{
    public class Person
    {
        public Person(string firtName, string lastName, int age)
        {
            FirstName = firtName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
