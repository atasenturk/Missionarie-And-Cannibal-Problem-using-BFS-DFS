using AiLab2.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLab2
{
    public class Queue<T> 
    {
        private Node<T> head;
        private Node<T> tail;

        public Queue()
        {
            head = null;
            tail = null;
        }

        public void Enqueue(T Value)
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

        public T Dequeue()
        {
            if (head == null && tail == null)
            {
                Console.WriteLine("Queue is empty! Can not dequeue");
                return default;
            }
            T Value = head.Value;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }

            return Value;
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

        public T Peek()
        {
            if (head == null && tail == null)
            {
                Console.WriteLine("Queue is empty! Can not dequeue");
                return default;
            }

            return head.Value;

        }

        //private int minIndex(int sortedIndex)
        //{
        //    int min_index = -1;
        //    T min_val = (T)(object)int.MaxValue;
        //    int n = Size();
        //    for (int i = 0; i < n; i++)
        //    {
        //        T curr = Peek();
        //        Dequeue();
        //        if (curr.CompareTo(min_val) <= 0 &&
        //               i <= sortedIndex)
        //        {
        //            min_index = i;
        //            min_val = curr;
        //        }
        //        Enqueue(curr);
        //    }
        //    return min_index;
        //}
        private void insertMinToRear(int min_index)
        {
            T min_val = (T)(object)0;
            int n = Size();
            for (int i = 0; i < n; i++)
            {
                T curr = Peek();
                Dequeue();
                if (i != min_index)
                    Enqueue(curr);
                else
                    min_val = curr;
            }
            Enqueue(min_val);
        }

        //public void Sort()
        //{
        //    for (int i = 1; i <= Size(); i++)
        //    {
        //        int min_index = minIndex(Size() - i);
        //        insertMinToRear(min_index);
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
