using System;

namespace Templates.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ////STACK
            //Console.WriteLine("START STACK");
            //Templates.DataStructures.Stack<int> myStack = new Templates.DataStructures.Stack<int>();

            //myStack.push(10);
            //myStack.push(5);

            //Console.WriteLine(myStack.pop());
            //Console.WriteLine("");

            ////QUEUE
            //Console.WriteLine("START QUEUE");
            //Templates.DataStructures.Queue<string> myQueue = new Templates.DataStructures.Queue<string>();

            //myQueue.enqueue("Hello");
            //myQueue.enqueue("World!");

            //Console.WriteLine(myQueue.dequeue() + " " + myQueue.dequeue());
            //Console.WriteLine();

            //try
            //{
            //    myQueue.dequeue();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //Console.WriteLine();


            ////MAP 
            //Console.WriteLine("START MAP");
            //Templates.DataStructures.Map<int, string> myMap = new Templates.DataStructures.Map<int, string>();

            //myMap.add(0, "Hello");

            //try
            //{
            //    myMap.add(0, "rob");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //    Console.WriteLine();
            //}

            //myMap.add(1, "World");
            //myMap.add(2, "!");

            //Console.WriteLine();
            //Console.WriteLine(myMap.get(0) + " " + myMap.get(1) + myMap.get(2));
            //Console.WriteLine();

            //myMap.remove(0);
            //myMap.remove(1, "World");
            //myMap.remove("!");

            //try
            //{
            //    myMap.remove(5);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}


            //myMap.add(10, "woops");
            //myMap.get(4);

            //LINKED LIST
            LinkedList<Person> peopleList = new LinkedList<Person>(new Person("rob", 22));

            peopleList.Add(new Person("Jim", 21));
            peopleList.Add(new Person("John", 20));
            peopleList.Add(new Person("Akhil", 21));

            peopleList.Remove(new Person("John", 20));


            foreach(var obj in peopleList.GetList())
            {
                Console.WriteLine(obj._Name + " / " + obj._Age);
            }           

            var x = peopleList;   
            
            Console.Read();
        }

        public class Person
        {
            public Person(string name, int age)
            {
                _Name = name;
                _Age = age;
            }

            public string _Name { get; set; }
            public int _Age { get; set; }
        }

    }
}