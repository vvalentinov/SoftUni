namespace _04.Students
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        class Student
        {
            public Student(string firstName, string lastName, string age, string hometown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Hometown = hometown;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Hometown { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] arr = line.Split();
                string firstName = arr[0];
                string lastName = arr[1];
                string age = arr[2];
                string hometown = arr[3];
                Student student = new Student(firstName, lastName, age, hometown);
                students.Add(student);
                line = Console.ReadLine();
            }

            string town = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.Hometown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
