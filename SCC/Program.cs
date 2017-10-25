using Graph;
using System;

namespace SCC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t = 0; // finishing time
            long? s = null; // leaders in 2nd pass

            long[] nodes = { 1, 2, 2, 4, 4, 3, 2 };


            for (var i = nodes.Length - 1; i > -1; i--)
            {

            }


            Console.ReadLine();
        }

        void DFS(Vertex<int> graph)
        {

            foreach (var neib in graph.Neighbours)
                if (!neib.Explored)
                {
                    neib.Explored = true;
                    DFS(neib);
                }
        }
    }


}
