using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTree(TreeNode<T> element, int value)
        {
            _BinaryTree = new TreeNode<T>(element, value);
            _BinaryTree._Parent = null;
            _BinaryTree._Left = null;
            _BinaryTree._Right = null;
        }


        public void Add(TreeNode<T> element, int value)
        {

        }


        public void Remove(TreeNode<T> element, int value)
        {

        }


        public void Remove(int value)
        {

        }


        public void Remove(TreeNode<T> element)
        {

        }



        TreeNode<T> _BinaryTree { get; set; }
    }

    public class TreeNode<T>
    {
        public TreeNode(TreeNode<T> obj, int value)
        {
            _NodeObj = obj;
            _NodeValue = value;
        }

        public int _NodeValue { get; set; }
        public TreeNode<T> _NodeObj { get; set; }
        public TreeNode<T> _Right { get; set; }
        public TreeNode<T> _Left { get; set; }
        public TreeNode<T> _Parent { get; set; }
    }
}
