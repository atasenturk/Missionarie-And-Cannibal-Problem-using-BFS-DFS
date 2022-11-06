using AiLab2.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLab2.Stack
{
    public class Stack<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Stack()
        {
            head = null;
            tail = null;
        }

        public void Push(T Value)
        {
            if (head == null && tail == null)
            {
                head = new Node<T>(Value);
                tail = head;
            }

            else
            {
                tail.next = new Node<T>(Value);
                Node<T> temp = tail;
                tail = temp.next;
                tail.prev = temp;
            }
        }

        public T Pop()
        {
            if (head == null && tail == null)
            {
                Console.WriteLine("Queue is empty! Can not dequeue");
                return default;
            }
            T Value = tail.Value;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }

            return Value;
        }

        public int Size()
        {
            Node<T> temp = head;
            int counter = 0;
            while (temp != null)
            {
                counter++;
                temp = temp.next;
            }
            return counter;
        }

        public void List()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.next;
            }
        }

        public void Reverse_List()
        {
            Node<T> temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.prev;
            }
        }

        public T Peek()
        {
            if (head == null && tail == null)
            {
                Console.WriteLine("Queue is empty! Can not dequeue");
                return default;
            }

            return tail.Value;

        }

        //private void sortedInsert(T x)
        //{
        //    if (Size() == 0 || x.CompareTo(Peek()) > 0)
        //    {
        //        Push(x);
        //        return;
        //    }

        //    T temp = Peek();
        //    Pop();
        //    sortedInsert(x);
        //    Push(temp);
        //}

        //public void Sort()
        //{
        //    if (Size() > 0)
        //    {
        //        T x = Peek();
        //        Pop();
        //        Sort();
        //        sortedInsert(x);
        //    }
        //}

        //public void Delete_Duplicates()
        //{
        //    Sort();
        //    if (head == null || head == tail) return;
        //    Node<T> p = head;
        //    Node<T> q = head.next;
        //    while (q != null)
        //    {
        //        if (p.Value.CompareTo(q.Value) == 0)
        //        {
        //            p.next = q.next;
        //            q = q.next;
        //            if (q != null)
        //                q.prev = p;
        //        }
        //        else
        //        {
        //            p = p.next;
        //            q = q.next;
        //        }
        //    }
        //}

        //public bool Contains(T Value)
        //{
        //    Node<T> temp = head;
        //    while (temp != null)
        //    {
        //        if (temp.Value.CompareTo(Value) == 0) return true;
        //        temp = temp.next;
        //    }

        //    return false;
        //}

    }
}
