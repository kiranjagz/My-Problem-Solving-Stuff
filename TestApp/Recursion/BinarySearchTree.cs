using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Recursion
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value, Node left, Node right)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        private static long previous = long.MinValue;

        public static bool IsValidBinarySearchTree(Node root)
        {
            if (root != null)
            {
                if (!IsValidBinarySearchTree(root.Left))
                {
                    return false;
                }

                if (root.Value <= previous)
                {
                    return false;
                }

                previous = root.Value;

                return IsValidBinarySearchTree(root.Right);
            }

            return true;

            //if (root.Left == null && root.Right == null)
            //    return false;

            //if (root.Left == null)
            //{
            //    if (root.Value < root.Right.Value)
            //        return true;
            //    else
            //        return false;
            //}
            //else
            //{
            //    bool leftNode = IsValidBinarySearchTree(root.Left);

            //    if (leftNode)
            //        return true;
            //    else
            //        return false;
            //}

            //if (root.Right == null)
            //{
            //    if (root.Value > root.Left.Value)
            //        return true;
            //    else
            //        return false;
            //}
            //else
            //   if (root.Left.Value < root.Value && root.Right.Value > root.Value)
            //    return true;
            //else
            //    return false;
        }
    }
}
