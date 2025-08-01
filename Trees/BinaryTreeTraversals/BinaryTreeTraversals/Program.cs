﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversals
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T Value)
        {
            var newNode = new BinaryTreeNode<T>(Value);

            if(Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                if(current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }

        }
        public void LevelOrderTraversal()
        {
            if (Root == null)
                return;

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Value + " "   );

                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinaryTreeNode<T> Root, int space )
        {
            int count = 10;
            if (Root == null)
                return;

            space += count;

            PrintTree(Root.Right,space);

            Console.WriteLine(  );
            for(int i = count; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Root.Value);

            PrintTree(Root.Left,space);
        }

        private void PreOrderTraversal(BinaryTreeNode<T> node)
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

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if(node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
           
        }


        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }

        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if(node == null) return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right );
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
            var binaryTree = new BinaryTree<int>();

            Console.WriteLine("Values to be inserted : 5,3,8,1,4,6,9\n");

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);

            binaryTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current - Left SubTree - Right SubTree): ");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("\nInOrder Traversal ( Left SubTree - Current - Right SubTree): ");
            binaryTree.InOrderTraversal();

            Console.WriteLine("\nPostOrder Traversal ( Left SubTree -  Right SubTree - Current ): ");
            binaryTree.PostOrderTraversal();

            Console.WriteLine("\nLevel-Order Traversal : ");
            binaryTree.LevelOrderTraversal();


        }
    }
}
