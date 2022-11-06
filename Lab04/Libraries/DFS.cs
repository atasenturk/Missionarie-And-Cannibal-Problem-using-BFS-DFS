using AiLab2.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Libraries
{
    public class DFS
    {
        public State Perform_DFS(State initial)
        {
            State current;

            AiLab2.Stack.Stack<State> stack = new AiLab2.Stack.Stack<State>();

            stack.Push(initial);
            List<State> visited = new List<State>();
            visited.Add(initial);
            while (stack.Size() != 0)
            {
                current = stack.Pop();
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
                        stack.Push(Node);
                    }
                }
            }


            return null;
        }
    }
}
