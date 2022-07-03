namespace _01._Distance_Between_Vertices
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        private static Dictionary<int, List<int>> graph;

        static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());
            int pairs = int.Parse(Console.ReadLine());

            graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < nodes; i++)
            {
                string[] nodesAndChildren = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

                int node = int.Parse(nodesAndChildren[0]);

                if (nodesAndChildren.Length == 1)
                {
                    graph[node] = new List<int>();
                }
                else
                {
                    List<int> children = nodesAndChildren[1]
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

                    graph[node] = children;
                }
            }

            for (int i = 0; i < pairs; i++)
            {
                int[] pair = Console.ReadLine()
                             .Split('-', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

                int start = pair[0];
                int destination = pair[1];

                int steps = BFS(start, destination);

                Console.WriteLine($"{{{start}, {destination}}} -> {steps}");
            }
        }

        private static int BFS(int start, int destination)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            HashSet<int> visited = new HashSet<int> { start };

            Dictionary<int, int> parent = new Dictionary<int, int>() { { start, -1 } };

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                if (node == destination)
                {
                    return GetSteps(parent, destination);
                }

                foreach (var child in graph[node])
                {
                    if (visited.Contains(child))
                    {
                        continue;
                    }

                    visited.Add(child);

                    queue.Enqueue(child);

                    parent[child] = node;
                }
            }

            return -1;
        }

        private static int GetSteps(Dictionary<int, int> parent, int destination)
        {
            int steps = 0;

            int node = destination;

            while (node != -1)
            {
                node = parent[node];
                steps++;
            }

            return steps - 1;
        }
    }
}