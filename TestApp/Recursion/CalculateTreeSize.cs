using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Recursion
{
    public class CalculateTreeSize
    {
        public class TreeNode
        {
            public TreeNode LeftChild { get; private set; }
            public TreeNode RightChild { get; private set; }

            public TreeNode(TreeNode leftChild, TreeNode rightChild)
            {
                this.LeftChild = leftChild;
                this.RightChild = rightChild;
            }
        }

        public class TreeHeight
        {
            public static int CalculateHeight(TreeNode root)
            {
                int heightleft = 0;
                int heightrigth = 0;

                if (root == null)
                    return -1;
                
                heightleft = CalculateHeight(root.LeftChild);
                heightrigth = CalculateHeight(root.RightChild);

                if (heightleft > heightrigth)
                    return heightleft + 1;    
                else            
                    return heightrigth + 1;
                
            }
        }

        //public static void Main(string[] args)
        //{
        //    TreeNode leaf1 = new TreeNode(null, null);
        //    TreeNode leaf2 = new TreeNode(null, null);
        //    TreeNode node = new TreeNode(leaf1, null);
        //    TreeNode root = new TreeNode(node, leaf2);
        //    Console.WriteLine(TreeHeight.CalculateHeight(root));
        //    Console.ReadLine();
        //}
    }
}
