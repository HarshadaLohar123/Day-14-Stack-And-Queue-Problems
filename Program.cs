using System;

namespace Uc_3_Queue
{
    internal class Node
    {

        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class QueueOperation
    {
        internal Node head;

        public bool Enqueue(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} inserted into the Queue", n.data);
                return true;
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} inserted into the Queue", n.data);
                return true;
            }
        }

        internal void Display()
        {
            Node t = head;
            if (t == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.data + " ");
                t = t.next;
            }
        }
        static void Main(string[] args)
        {
            QueueOperation obj = new QueueOperation();
            obj.Enqueue(70);
            obj.Enqueue(30);
            obj.Enqueue(56);
            obj.Display();

        }
    }
}
