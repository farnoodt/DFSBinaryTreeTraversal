using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstBinaryTreeTraversal
{
    class PreOrder
    {
        public void preorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " , ");
                preorder(node.left);
                preorder(node.right);
            }
        }
    }
}
