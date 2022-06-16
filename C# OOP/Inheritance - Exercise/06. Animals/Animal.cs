namespace _06._Animals
{
    using System;
    using System.Text;

    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid input!");
                }

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
                if (value <= 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    Console.WriteLine("Invalid input!");
                }
                gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.Append($"{ProduceSound()}");
            return sb.ToString();
        }
    }
}
