using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>(45);
            BST.AddToTree(50);
            BST.AddToTree(20);
            BST.AddToTree(60);
            BST.AddToTree(15);
            BST.AddToTree(55);
            BST.AddToTree(75);

            Console.WriteLine("");
            Console.ReadKey();


        }
    }
}
