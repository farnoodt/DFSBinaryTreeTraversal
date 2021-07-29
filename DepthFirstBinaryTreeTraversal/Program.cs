using System;

namespace DepthFirstBinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(20);
            
            tree.left = new Node(10);
            tree.right = new Node(30);
            tree.left.left = new Node(5);
            tree.left.right = new Node(15);
            tree.right.left = new Node(25);
            tree.right.right = new Node(35);


            PreOrder PO = new PreOrder();
            PO.preorder(tree);

            Console.WriteLine();

            InOrder IO = new InOrder();
            IO.Inorder(tree);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
