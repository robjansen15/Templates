using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.DataStructures
{
    public class Stack<T>
    {
        public Stack()
        {
            _Stack = new List<T>();
        }
        

        public void Push(T element)
        {
            //Dont actually need to check type of element... VS does this for you.
            _Stack.Add(element);
        }


        public T Pop()
        {
            if (_Stack.Count > 0)
            {
                T element = _Stack[_Stack.Count-1];
                _Stack.RemoveAt(_Stack.Count-1);
                return element;
            }
            else
            {
                throw new Exception("Empty stack err.");
            }
        }


        private List<T> _Stack { get; set; }
    }
}
