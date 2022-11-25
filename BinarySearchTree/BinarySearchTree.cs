using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Root;
        public void Add(T data)
        {
            Node<T> parent = null, current = Root;

            while (current != null)
            {
                parent = current;
                if (current.Data.CompareTo(data) >= 0)
                    current = current.leftNode;
                else if (data.CompareTo(current.Data) >= 0)
                    current = current.rightNode;
                else
                {
                    Console.WriteLine($"{data} is already present in Binary Tree");
                }
            }

            Node<T> newNode = new Node<T>(data);

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (parent.Data.CompareTo(data) >= 0)
                    parent.leftNode = newNode;
                else
                    parent.rightNode = newNode;
            }
        }
        public void DisplayInorder(Node<T> parent)
        {
            if (parent != null)
            {
                DisplayInorder(parent.leftNode);
                Console.Write(parent.Data + " ");
                DisplayInorder(parent.rightNode);
            }
        }
    }
}
