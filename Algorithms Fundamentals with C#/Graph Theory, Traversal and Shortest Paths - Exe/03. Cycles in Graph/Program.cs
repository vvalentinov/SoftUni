namespace _03._Cycles_in_Graph
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static HashSet<string> visited;
        private static HashSet<string> cycles;

        static void Main(string[] args)
        {
            graph = new Dictionary<string, List<string>>();
            visited = new HashSet<string>();
            cycles = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] edge = line.Split('-', StringSplitOptions.RemoveEmptyEntries);

                string from = edge[0];
                string to = edge[1];

                if (graph.ContainsKey(from) == false)
                {
                    graph.Add(from, new List<string>());
                }

                if (graph.ContainsKey(to) == false)
                {
                    graph.Add(to, new List<string>());
                }

                graph[from].Add(to);
            }

            try
            {
                foreach (var node in graph.Keys)
                {
                    DFS(node);
                }

                Console.WriteLine("Acyclic: Yes");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Acyclic: No");
            }
        }

        private static void DFS(string node)
        {
            if (cycles.Contains(node))
            {
                throw new InvalidOperationException();
            }

            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            cycles.Add(node);

            foreach (var child in graph[node])
            {
                DFS(child);
            }

            cycles.Remove(node);
        }
    }
}