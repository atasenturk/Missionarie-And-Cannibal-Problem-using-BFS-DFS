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

            while (Queue.Size() != 0)
            {
                State u = Queue.Dequeue();

                if (u.IsFinal())
                {
                    return u;
                }

                u.GenerateChilds();

                foreach (var Node in u.Childs)
                {
                    if (!Node.IsVisited)
                    {
                        Node.IsVisited = true;
                        Node.Parent = u;
                        Queue.Enqueue(Node);
                    }
                }
            }


            return null;
        }
    }
}
