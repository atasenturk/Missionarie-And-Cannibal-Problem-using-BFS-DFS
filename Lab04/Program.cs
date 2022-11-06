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

            State initial = new State(3, 3, 0, 0, false);
            State final = bfs.Perform_BFS(initial);

            Console.WriteLine(final.LeftM + " " + final.LeftC + " " + final.RightM + " " + final.RightC);

        }
    }
}
