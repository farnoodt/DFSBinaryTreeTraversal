using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstBinaryTreeTraversal
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            this.data = item;
            this.left = this.right = null;
        }
    }
}
