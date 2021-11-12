using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Bst bst = new Bst();
            bst.Insert(56);//this will first insert 56.
            bst.Insert(30);//this will be added towards the left.
            bst.Insert(70);//this will be added towards the right.
            bst.displayTree();
        }
    }
}
