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
        private Node<T> rightChild;
        private Node<T> leftChild;
        public Node<T> RightChild { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node(T value)
        {
            this.value = value;
        }
            

    }
}
