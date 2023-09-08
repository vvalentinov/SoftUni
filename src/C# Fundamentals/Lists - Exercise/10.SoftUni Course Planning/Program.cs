namespace _10.SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            string line = Console.ReadLine();
            while (line != "course start")
            {
                string[] arr = line.Split(":");
                string command = arr[0];
                string lesson = arr[1];
                if (command == "Add")
                {
                    if (!input.Contains(lesson))
                    {
                        input.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arr[2]);
                    if (!input.Contains(lesson))
                    {
                        input.Insert(index, lesson);
                    }
                }
                else if (command == "Remove")
                {
                    if (input.Contains(lesson) && input.Contains($"{lesson}-Exercise"))
                    {
                        input.Remove(lesson);
                        input.Remove($"{lesson}-Exercise");
                    }
                    else if (input.Contains(lesson))
                    {
                        input.Remove(lesson);
                    }
                }
                else if (command == "Swap")
                {
                    string otherLesson = arr[2];
                    if (input.Contains(lesson) && input.Contains(otherLesson))
                    {
                        if (input.Contains($"{lesson}-Exercise") && input.Contains($"{otherLesson}-Exercise"))
                        {
                            int indexLesson = input.IndexOf(lesson);
                            int indexOtherLesson = input.IndexOf(otherLesson);
                            int indexLessonExercise = input.IndexOf($"{lesson}-Exercise");
                            int indexOtherLessonExercise = input.IndexOf($"{otherLesson}-Exercise");
                            input[indexLesson] = otherLesson;
                            input[indexOtherLesson] = lesson;
                            input[indexLessonExercise] = $"{otherLesson}-Exercise";
                            input[indexOtherLessonExercise] = $"{lesson}-Exercise";
                        }
                        else if (input.Contains($"{lesson}-Exercise"))
                        {
                            int indexLesson = input.IndexOf(lesson);
                            int indexLessonExercise = input.IndexOf($"{lesson}-Exercise");
                            int indexOtherLesson = input.IndexOf(otherLesson);
                            input[indexLesson] = otherLesson;
                            input[indexOtherLesson] = lesson;
                            int newIndexLesson = input.IndexOf(lesson);
                            input.Remove($"{lesson}-Exercise");
                            input.Insert(newIndexLesson + 1, $"{lesson}-Exercise");
                        }
                        else if (input.Contains($"{otherLesson}-Exercise"))
                        {
                            int indexLesson = input.IndexOf(lesson);
                            int indexOtherLessonExercise = input.IndexOf($"{otherLesson}-Exercise");
                            int indexOtherLesson = input.IndexOf(otherLesson);
                            input[indexLesson] = otherLesson;
                            input[indexOtherLesson] = lesson;
                            int newIndexLesson = input.IndexOf(otherLesson);
                            input.Remove($"{otherLesson}-Exercise");
                            input.Insert(newIndexLesson + 1, $"{otherLesson}-Exercise");
                        }
                        else
                        {
                            int indexLesson = input.IndexOf(lesson);
                            int indexOtherLesson = input.IndexOf(otherLesson);
                            input[indexLesson] = otherLesson;
                            input[indexOtherLesson] = lesson;
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (input.Contains(lesson) && !input.Contains($"{lesson}-Exercise"))
                    {
                        int indexOfLesson = input.IndexOf(lesson);
                        input.Insert(indexOfLesson + 1, $"{lesson}-Exercise");
                    }
                    else if (!input.Contains(lesson))
                    {
                        input.Add(lesson);
                        input.Add($"{lesson}-Exercise");
                    }
                }
                line = Console.ReadLine();
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
