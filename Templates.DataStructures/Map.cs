using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.DataStructures
{
    public class Map<T, K>
    {
        public Map()
        {
            _Keys = new List<T>();
            _Elements = new List<K>();
        }

        
        /// <summary>
        /// add an element with a key element match
        /// </summary>
        /// <param name="key"></param>
        /// <param name="element"></param>
        public void Add(T key, K element)
        {
            if(_Keys.FindAll(x=>x.Equals(key)).Count == 0)
            {
                _Keys.Add(key);
                _Elements.Add(element);
            }
            else
            {
                throw new Exception("key already exists");
            }
            
        }


        /// <summary>
        /// removes an element based on a key and verifies the element 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="element"></param>
        public void Remove(T key, K element)
        {
            int index = _Keys.FindIndex(x => x.Equals(key));

            if (_Elements[index].Equals(element))
            {
                _Keys.RemoveAt(index);
                _Elements.RemoveAt(index);
            }
        }


        /// <summary>
        /// removes an element bassed on a key
        /// </summary>
        /// <param name="key"></param>
        public void Remove(T key)
        {
            int index = _Keys.FindIndex(x => x.Equals(key));

            _Keys.RemoveAt(index);
            _Elements.RemoveAt(index);            
        }


        /// <summary>
        /// removes and element based on the element itself
        /// </summary>
        /// <param name="element"></param>
        public void Remove(K element)
        {
            int index = _Elements.FindIndex(x => x.Equals(element));

            _Keys.RemoveAt(index);
            _Elements.RemoveAt(index);
        }


        /// <summary>
        /// gets an element basedx on the key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public K Get(T key)
        {
            if(_Keys.Count < 1)
            {
                throw new Exception("Empty map err.");
            }

            int index = _Keys.FindIndex(x => x.Equals(key));

            if(index == -1)
            {
                throw new Exception("No match found");
            }       

            return _Elements[index];
        }


        private List<T> _Keys { get; set; }
        private List<K> _Elements { get; set; }
    }
}
