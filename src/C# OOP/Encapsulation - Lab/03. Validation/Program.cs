﻿namespace _03._Validation
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                try
                {
                    Person person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }

            }
            decimal parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
