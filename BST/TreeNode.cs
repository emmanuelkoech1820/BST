using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class TreeNodelib
    {
        public class TreeNode<T> where T : IComparable<T>
        {
            public T Value { get; private set; }
            public TreeNode<T> Left { get; private set; }
            public TreeNode<T> Right { get; private set; }
            public TreeNode(T value)
            {
                Value = value;
            }
            public void Insert(T newValue)
            {
                int compare = newValue.CompareTo(Value);
                if (compare == 0)
                    return;
                if (compare < 0)
                {
                    if (Left == null)
                    {
                        Left = new TreeNode<T>(newValue);
                    }
                    else
                    {
                        Left.Insert(newValue);
                    }

                }
                else
                {
                    if (Right == null)
                    {
                        Right = new TreeNode<T>(newValue);
                    }
                    else
                    {
                        Right.Insert(newValue);
                    }
                }
            }

            public TreeNode<T> Get(T value)
            {
                int compare = value.CompareTo(Value);
                if (compare == 0)
                {
                    return this;
                }
                if (compare < 0)
                {
                    if (Left != null)
                        return Left.Get(value);
                }
                else
                {
                    if (Right != null)
                        return Right.Get(value);
                }
                return null;
            }

            public IEnumerable<T> TraverseInOrder()
            {

                var list = new List<T>();

                InnerTravers(list);
                return list;
            }

            private void InnerTravers(List<T> list)
            {
                if (Left != null)
                    Left.InnerTravers(list);

                list.Add(Value);

                if (Right != null)
                    Right.InnerTravers(list);


            }
            public T min()
            {
                if (Left != null)
                    return Left.min();
                return Value;
            }

            public T Max()
            {
                if (Right != null)
                    return Right.Max();
                return Value;

            }
        }
    }
}
