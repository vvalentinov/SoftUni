﻿namespace _02._Salary
{
    public class Person
    {
        public Person(string firtName, string lastName, int age, decimal salary) : this(firtName, lastName, age)
        {
            Salary = salary;
        }
        public Person(string firtName, string lastName, int age)
        {
            FirstName = firtName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
