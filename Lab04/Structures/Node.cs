using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLab2.Structures
{
    public class Node<T>
    {
        public T Value;
        public Node<T> next;
        public Node<T> prev;

        public Node(T Value)
        {
            this.Value = Value;
            next = null;
            prev = null;
        }
    }
}
