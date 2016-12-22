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
        int result;     
        public BinarySearchTree(T value)
        {
            Top = new Node<T>(value);
        }
        public void AddToTree(T value)
        {
            int result;
            Node<T> NodeLocation = new Node<T>(value);
            Node<T> NodeNow = Top, parent = null;
            while (NodeNow != null)
            {
                result = NodeNow.Value.CompareTo(NodeLocation.Value);
                if (result == 0)
                    return;
                else if (result > 0)
                {
                    parent = NodeNow;
                    NodeNow = NodeNow.LeftChild;
                }
                else if (result < 0)
                {
                    parent = NodeNow;
                    NodeNow = NodeNow.RightChild;
                }
            }
            if (parent == null)
            {
                NodeNow = NodeLocation;
            }
            else
            {
                result = parent.Value.CompareTo(NodeLocation.Value);
                if (result > 0)
                {
                    parent.
                        LeftChild = NodeLocation;
                }
                else
                {
                    parent.RightChild = NodeLocation;
                }
            }
        }
        public bool SearchTree(T value)
        {
            Node<T> NodeNow = Top;
            Node<T> NodeLocation = new Node<T>(value);
            while (NodeNow != null)
            {
                result = NodeNow.Value.CompareTo(NodeLocation.Value);
                if (result == 0)
                    return true;
                else if (result > 0)
                {
                    NodeNow = NodeNow.LeftChild;
                }
                else if (result < 0)
                {
                    NodeNow = NodeNow.RightChild;
                }
            }            
            return false;
        }
        //public bool RemoveNode(T value)
        //{
        //    Node<T> NodeNow = Top, parent = null;
        //    int result = NodeNow.Value.CompareTo(value);
        //    while (result != 0)
        //    {
        //        return false;
        //    }
        //    else if (Top != null)
        //    {
        //        SearchTree(value);
        //        if (NodeLocation == null)
        //        {
                    
        //        }
        //    }

        //}
    }
}




