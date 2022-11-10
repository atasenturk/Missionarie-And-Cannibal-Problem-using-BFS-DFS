using AiLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Libraries
{
    public class BFS
    {
        public State Perform_BFS(State initial)
        {
            State current;

            AiLab2.Queue<State> Queue = new AiLab2.Queue<State>();

            Queue.Enqueue(initial);
            List<State> visited = new List<State>();
            visited.Add(initial);
            while (Queue.Size() != 0)
            {
                current = Queue.Dequeue();

                if (current.IsFinal())
                {
                    return current;
                }

                current.GenerateChilds();

                foreach (var Node in current.Childs)
                {
                    if (visited.Where(i => i.LeftC == Node.LeftC && i.LeftM == Node.LeftM && i.Boat == Node.Boat).FirstOrDefault() == null)
                    {
                        visited.Add(Node);
                        Node.IsVisited = true;
                        Node.Parent = current;
                        Queue.Enqueue(Node);
                    }
                }
            }


            return null;
        }
    }
}
