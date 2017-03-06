using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.DataStructures
{
    public class Queue<T>
    {
        public Queue()
        {
            _Queue = new List<T>();
        }


        public void Enqueue(T element)
        {
            _Queue.Add(element);
        }


        public T Dequeue()
        {
            if (_Queue.Count > 0)
            {
                T element = _Queue[0];
                _Queue.RemoveAt(0);
                return element;
            }
            else
            {
                throw new Exception("Empty Queue err.");
            }
        }


        private List<T> _Queue { get; set; }
    }
}
