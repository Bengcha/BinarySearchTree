using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T value;
        public Node<T> parent;
        public Node<T> rightChild;
        public Node<T> leftChild;

        public Node(T value)
        {
            this.value = value;
        }
            

    }
}
