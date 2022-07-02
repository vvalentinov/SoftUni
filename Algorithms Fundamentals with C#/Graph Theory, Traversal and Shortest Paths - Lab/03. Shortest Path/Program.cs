namespace _03._Shortest_Path
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        private static int[] parent;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int e = int.Parse(Console.ReadLine());

            graph = new List<int>[n + 1];

            visited = new bool[graph.Length];

            parent = new int[graph.Length];

            Array.Fill(parent, -1);

            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<int>();
            }

            for (int i = 0; i < e; i++)
            {
                int[] edge = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

                int firstNode = edge[0];
                int secondNode = edge[1];

                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }

            int start = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            BFS(start, destination);
        }

        private static void BFS(int startNode, int destination)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(startNode);

            visited[startNode] = true;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                if (node == destination)
                {
                    Stack<int> path = GetPath(destination);

                    Console.WriteLine($"Shortest path length is: {path.Count - 1}");

                    Console.WriteLine(string.Join(' ', path));

                    break;
                }

                foreach (var child in graph[node])
                {
                    if (visited[child] == false)
                    {
                        parent[child] = node;
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }
        }

        private static Stack<int> GetPath(int destination)
        {
            Stack<int> path = new Stack<int>();

            int node = destination;

            while (node != -1)
            {
                path.Push(node);
                node = parent[node];
            }

            return path;
        }
    }
}