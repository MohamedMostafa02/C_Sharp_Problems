using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingTwoStacks
{
    // Custom implementation of a queue using two stacks
    class MyQueue
    {
        // stack1 is used for enqueueing new elements
        private Stack<int> stack1 = new Stack<int>();

        // stack2 is used for dequeuing elements (in reversed order)
        private Stack<int> stack2 = new Stack<int>();

        // Adds an element to the queue
        public void Enqueue(int value)
        {
            // Always push into stack1
            stack1.Push(value);
        }

        // Removes and returns the front element from the queue
        public int Dequeue()
        {
            // If stack2 is empty, transfer all elements from stack1 to stack2
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            // Pop from stack2 (which now has elements in correct queue order)
            return stack2.Pop();
        }

        // Checks if the queue is empty
        public bool IsEmpty()
        {
            // Queue is empty only if both stacks are empty
            return stack1.Count == 0 && stack2.Count == 0;
        }

        // Returns the front element without removing it
        public int Peek()
        {
            // If both stacks are empty, the queue is empty
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            // If stack2 is empty, transfer elements from stack1
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            // Return the top element from stack2 (front of queue)
            return stack2.Peek();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyQueue
            MyQueue queue = new MyQueue();

            // Add two elements to the queue
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Peek at the front element (should be 1)
            Console.WriteLine(queue.Peek());

            // Remove and print the front element (should be 1)
            Console.WriteLine(queue.Dequeue());

            // Remove and print the next element (should be 2)
            Console.WriteLine(queue.Dequeue());

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
