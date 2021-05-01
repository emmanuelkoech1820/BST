using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BST.TreeNodelib;

namespace BSTs
{
    public class BST<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;
        public TreeNode<T> Get(T value)
        {
            return _root?.Get(value);
        }
        public T Min()
        {
            if (_root == null)
                throw new InvalidOperationException(message: "Empty");
            return _root.min();
           
        }
        public T max()
        {
            if (_root == null)
                throw new InvalidOperationException(message: "Empty");
            return _root.Max();

        }
        public void Insert (T value)
        {
            if (_root == null)
                _root = new TreeNode<T>(value);
            else
            {
                _root.Insert(value);
            }
        }
        public IEnumerable<T> TraverseInOrder()
        {
            if(_root != null)
            {
                return _root.TraverseInOrder();
            }
            return Enumerable.Empty<T>();
        }
    }
}
