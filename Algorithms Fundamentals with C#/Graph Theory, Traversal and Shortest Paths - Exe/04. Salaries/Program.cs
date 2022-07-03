namespace _04._Salaries
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static List<int>[] graph;
        private static Dictionary<int, int> visited;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            graph = new List<int>[n];
            visited = new Dictionary<int, int>();

            for (int node = 0; node < n; node++)
            {
                graph[node] = new List<int>();

                string nodeChildren = Console.ReadLine();

                for (int child = 0; child < nodeChildren.Length; child++)
                {
                    if (nodeChildren[child] == 'Y')
                    {
                        graph[node].Add(child);
                    }
                }
            }

            int salary = 0;

            for (int node = 0; node < graph.Length; node++)
            {
                salary += DFS(node);
            }

            Console.WriteLine(salary);
        }

        private static int DFS(int node)
        {
            if (visited.ContainsKey(node))
            {
                return visited[node];
            }

            int salary = 0;

            if (graph[node].Count == 0)
            {
                salary = 1;
            }
            else
            {
                foreach (var child in graph[node])
                {
                    salary += DFS(child);
                }
            }

            visited[node] = salary;

            return salary;
        }
    }
}