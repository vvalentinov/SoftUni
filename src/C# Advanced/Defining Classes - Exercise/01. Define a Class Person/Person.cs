namespace _01._Define_a_Class_Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            } 
        }
    }
}
