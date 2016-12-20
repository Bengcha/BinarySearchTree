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
            Node<T> NodeNow = Top;
            Node<T> NodeLocation = new Node<T>(value);
            bool setLocation = true;

        }
    }

}


