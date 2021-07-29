using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstBinaryTreeTraversal
{
    class InOrder
    {
        public void Inorder(Node node)
        {
            if(node != null)
            {
                Inorder(node.left);
                Console.Write(node.data + " , ");
                Inorder(node.right);
            }
        }
    }
}
