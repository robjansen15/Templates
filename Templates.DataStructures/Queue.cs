﻿using System;
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


        public void enqueue(T element)
        {
            //Dont actually need to check type of element... VS does this for you.
            _Queue.Add(element);
        }


        public T dequeue()
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
        private T _Type { get; set; }
    }
}
