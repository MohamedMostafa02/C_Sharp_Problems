using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBackTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack to store the path or visited locations
            Stack<string> stack = new Stack<string>();

            // Push locations to the stack (like a path followed by a person)
            stack.Push("Start");
            stack.Push("Go To Gaz Station");
            stack.Push("Go To Super Market");
            stack.Push("Go To Work");
            stack.Push("Go To Cafe");
            stack.Push("Go Home");

            Console.WriteLine("BackTracking.....\n");

            // Loop through the stack (from top to bottom) to simulate backtracking
            foreach (var item in stack)
            {
                Console.WriteLine($"Back to: {item}");
            }

            Console.ReadKey(); // Wait for a key press before closing
        }
    }
}
