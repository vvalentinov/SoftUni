namespace _02.TopologicalSorting
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static Dictionary<string, int> dependencies;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            graph = ReadGraph(n);

            dependencies = ExtractDependencies(graph);

            List<string> sorted = new List<string>();

            while (dependencies.Count > 0)
            {
                string nodeToRemove = dependencies.FirstOrDefault(d => d.Value == 0).Key;

                if (nodeToRemove == null)
                {
                    break;
                }

                dependencies.Remove(nodeToRemove);

                sorted.Add(nodeToRemove);

                foreach (var child in graph[nodeToRemove])
                {
                    dependencies[child]--;
                }
            }

            if (dependencies.Count == 0)
            {
                Console.WriteLine($"Topological sorting: {string.Join(", ", sorted)}");
            }
            else
            {
                Console.WriteLine("Invalid topological sorting");
            }
        }

        private static Dictionary<string, int> ExtractDependencies(Dictionary<string, List<string>> graph)
        {
            Dictionary<string, int> dependencies = new Dictionary<string, int>();

            foreach (var kvp in graph)
            {
                string node = kvp.Key;
                List<string> children = kvp.Value;

                if (dependencies.ContainsKey(node) == false)
                {
                    dependencies[node] = 0;
                }

                foreach (var child in children)
                {
                    if (dependencies.ContainsKey(child) == false)
                    {
                        dependencies[child] = 1;
                    }
                    else
                    {
                        dependencies[child]++;
                    }
                }
            }

            return dependencies;
        }

        private static Dictionary<string, List<string>> ReadGraph(int n)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string key = parts[0];

                if (parts.Length == 1)
                {
                    result[key] = new List<string>();
                }
                else
                {
                    List<string> children = parts[1].Split(", ").ToList();

                    result[key] = children;
                }
            }

            return result;
        }
    }
}