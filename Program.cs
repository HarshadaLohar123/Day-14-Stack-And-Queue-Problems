using System;

namespace Uc_4_Queue
{
    internal class Node
    {
        public int key;
        public Node next;

        public Node(int key)
        {
            this.key = key;
        }
    }
    internal class QueueOperation
    {
        internal Node front, rear;
        public void Enqueue(int key)
        {
            Node temp = new Node(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                Console.WriteLine("{0} Enqueued into the Queue", key);
                return;
            }
            this.rear.next = temp;
            Console.WriteLine("{0} Enqueued into the Queue", key);
            this.rear = temp;
        }

        public void Dequeue()
        {
            if (this.front == null)
            {
                return;
            }

            Node temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
        }

        internal void Display()
        {
            Node t = front;
            if (t == null)
            {
                Console.WriteLine(" Queue is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.key + " ");
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

            Console.WriteLine("statrting element is: " + obj.front.key);
            Console.WriteLine("Last element is: " + obj.rear.key);
            Console.WriteLine("Dequeuing elements from the Queue");
            obj.Dequeue();
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("All elements are Dequeued");

        }
    }
}
