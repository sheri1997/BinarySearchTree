using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Bst
    {
        public Node root;
        Node node = new Node();
        public void Insert(int value)//method foor inserting data in the tree
        {
            node.Data = value;//data will be equal to the value entered.
            if(root==null)//if the tree is empty
            {
                root = node;//data entered will become the root node.
            }
            else//if the tree is not empty.
            {
                Node current = root;//current position will become the root node initailay
                Node parentNode;
                while(true)//till the value is true
                {
                    parentNode = current;//parent node will become the current node.
                    if(value<current.Data)//if the value is less than the root node.
                    {
                        current = current.Left;//value will be inserted at the left side of the root node.
                        if(current==null)//if there is no root node present at the left.
                        {
                            parentNode.Left = node;//the value will become the root node.
                            break;
                        }
                        else//if there is a root node at the left.
                        {
                            current = current.Right;//the value will be shifted to the right of the root.
                            if(current==null)
                            {
                                parentNode.Right = node;//the data will be entered toward the right of the root node.
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void displayTree()
        {
            Console.WriteLine("Tree = " + node.Data);
        }
    }
}
