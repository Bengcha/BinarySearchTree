using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Top;

        public BinarySearchTree(T value)
        {
            Top = new Node<T>(value);
        }

        public void AddToTree(T value)
        {
            Node<T> NodeLocation = new Node<T>(value);
            int currentNode;
            Node<T> NodeNow = Top, parent = null;
            while (NodeNow!= null)
            {
                currentNode = NodeLocation.value.CompareTo(NodeNow.value);
                if (currentNode == 0)
                {
                    return;
                }
                else if (currentNode > 0)
                {
                    parent = NodeNow;
                    NodeNow = NodeNow.leftChild;
                }
                else if (currentNode < 0)
                {
                    parent = NodeNow;
                    NodeNow = NodeNow.rightChild;
                }

            }
            if (parent == null)
            {
                Top = NodeLocation;              
            }
            else
            {
                currentNode = NodeLocation.value.CompareTo(parent.value);
                if (currentNode > 0)
                {
                    parent.leftChild = NodeLocation;
                }
                else
                {
                    parent.rightChild = NodeLocation;
                }
                
            }
        }
    }
}




