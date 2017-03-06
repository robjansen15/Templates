using System;

namespace Templates.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACK
            Templates.DataStructures.Stack<int> myStack = new Templates.DataStructures.Stack<int>();

            myStack.push(10);
            myStack.push(5);

            Console.WriteLine(myStack.pop());
            Console.WriteLine("");

            //QUEUE
            Templates.DataStructures.Queue<string> myQueue = new Templates.DataStructures.Queue<string>();

            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World!");

            Console.WriteLine(myQueue.Dequeue() + " " + myQueue.Dequeue());
            Console.WriteLine();

            try
            {
                myQueue.Dequeue();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();
        }
    }
}