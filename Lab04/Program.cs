using Lab04.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BFS bfs = new BFS();
            DFS dfs = new DFS();
            State initial = new State(3, 0, 3, 0, false);
            State finalBFS = bfs.Perform_BFS(initial);
            State finalDFS = dfs.Perform_DFS(initial);

            Console.WriteLine("   BFS PATH");
            Console.WriteLine(finalBFS.GetPath());

            Console.WriteLine("\n\n\n   DFS PATH");
            Console.WriteLine(finalDFS.GetPath());

            Console.ReadKey();
        }
    }
}
