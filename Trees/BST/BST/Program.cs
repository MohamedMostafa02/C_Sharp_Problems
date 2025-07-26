using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversals
{
    public class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTreeNode<T> Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(T Value)
        {
            Root = Insert(Root, Value);
        }
        private BinarySearchTreeNode<T> Insert(BinarySearchTreeNode<T> node, T Value)
        {


            if (node == null)
            {
                return new BinarySearchTreeNode<T>(Value);
            }
            else if (Value.CompareTo(node.Value) < 0)
            {
                node.Left = Insert(node.Left, Value);
            }
            else if (Value.CompareTo(node.Value) > 0)
            {
                node.Right = Insert(node.Right, Value);
            }

            return node;
        }

        public bool Search(T Value)
        {
            return Search(Root, Value) != null;
        }

        private BinarySearchTreeNode<T> Search(BinarySearchTreeNode<T> node,T Value)
        {

            if(node == null || node.Value.Equals(Value))
            {
                return node;
            }
            if(Value.CompareTo(node.Value) < 0)
            {
                return Search(node.Left, Value);
            }
            else
            {
                return Search(node.Right, Value);
            }

          

        }
        public void LevelOrderTraversal()
        {
            if (Root == null)
                return;

            Queue<BinarySearchTreeNode<T>> queue = new Queue<BinarySearchTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Value + " ");

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinarySearchTreeNode<T> Root, int space)
        {
            int count = 10;
            if (Root == null)
                return;

            space += count;

            PrintTree(Root.Right, space);

            Console.WriteLine();
            for (int i = count; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Root.Value);

            PrintTree(Root.Left, space);
        }

        private void PreOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null) return;

            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");

        }


        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }

        private void InOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree<int>();

            Console.WriteLine("Values to be inserted : 45,15,79,90,10,55,12,20,50\r\n");

            bst.Insert(45);
            bst.Insert(15);
            bst.Insert(79);
            bst.Insert(90);
            bst.Insert(10);
            bst.Insert(55);
            bst.Insert(12);
            bst.Insert(20);
            bst.Insert(50);

            bst.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current - Left SubTree - Right SubTree): ");
            bst.PreOrderTraversal();

            Console.WriteLine("\nInOrder Traversal ( Left SubTree - Current - Right SubTree): ");
            bst.InOrderTraversal();

            Console.WriteLine("\nPostOrder Traversal ( Left SubTree -  Right SubTree - Current ): ");
            bst.PostOrderTraversal();

            Console.WriteLine("\nLevel-Order Traversal : ");
            bst.LevelOrderTraversal();

            Console.WriteLine("\nDoes The BST Contains 79 ? " + bst.Search(79));
            Console.WriteLine("Does The BST Contains 100 ? "+ bst.Search(100));


        }
    }
}
