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
    }
}
