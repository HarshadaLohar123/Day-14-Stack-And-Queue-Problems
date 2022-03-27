using System;

namespace Uc_1_Stack
{
    public class CreateStack
    {
        private class Node
        {
            public int data;
            public Node link;
        }
        Node top;
        public CreateStack()
        {
            this.top = null;
        }

        public void Push(int x)
        {
            Node temp = new Node();

            temp.data = x;
            temp.link = top;
            top = temp;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("The Elements of Stack Is:");
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0} ", temp.data);
                    temp = temp.link;
                }
            }
        }


        static void Main(string[] args)
        {
            CreateStack obj = new CreateStack();

            obj.Push(56);
            obj.Push(30);
            obj.Push(70);

            obj.Display();

        }
    }
}
