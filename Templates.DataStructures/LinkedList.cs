using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.DataStructures
{
    /// <summary>
    /// Not neccessarily your traditional Linked List. Worked within the parameters of how well I know C#.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        public LinkedList(T element)
        {
            _LinkedList = new Node<T>(element);
        }

        /// <summary>
        /// resets the head back to where we want to be
        /// </summary>
        private void Reset()
        {
            while(_LinkedList._Previous != null)
            {
                _LinkedList = _LinkedList._Previous;
            }
        }


        /// <summary>
        /// adds elements to the linked list
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            while (true)
            {
                if(_LinkedList._Next == null)
                {
                    _LinkedList._Next = new Node<T>(_LinkedList, element);
                    break;
                }

                _LinkedList = _LinkedList._Next;
            }

            Reset();
        }


        /// <summary>
        /// removes an item from the linked list. you need to know all attributes of this item.
        /// </summary>
        /// <param name="element"></param>
        public void Remove(T element)
        {
            while(_LinkedList._Next != null)
            {
                if (_LinkedList._Obj.Equals(element))
                {
                    _LinkedList._Previous._Next = _LinkedList._Next;
                    _LinkedList._Next._Previous = _LinkedList._Previous;
                }

                _LinkedList = _LinkedList._Next;
            }

            Reset();
        }


        /// <summary>
        /// builds a list of the objects in the linked list
        /// </summary>
        /// <returns></returns>
        public List<T> GetList()
        {
            List<T> tempList = new List<T>();

            while (_LinkedList._Next != null)
            {
                tempList.Add(_LinkedList._Obj);
                _LinkedList = _LinkedList._Next;
            }

            Reset();

            return tempList;
        }


        private Node<T> _LinkedList { get; set; }
    }

    public class Node<T>
    {
        public Node(Node<T> previous, T obj)
        {
            _Previous = previous;
            _Next = null;
            _Obj = obj;
        }


        public Node(T obj)
        {
            _Previous = null;
            _Next = null;
            _Obj = obj;
        }


        public Node<T> _Next { get; set; }
        public T _Obj { get; set; }
        public Node<T> _Previous { get; set; }
    }

}
