// 📂 Project: Reverse String Using Stack
// This C# console application demonstrates how to reverse a string using a stack.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        // Function to reverse a string using a stack
        static string Reverse(string word)
        {
            // Create a stack to hold characters
            Stack<char> stack = new Stack<char>();

            // Push each character from the string into the stack
            foreach (char c in word)
            {
                stack.Push(c);
            }

            string result = ""; // To store the reversed string

            // Pop characters from the stack and append to result
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result; // Return the reversed string
        }

        static void Main(string[] args)
        {
            string input = "hello"; // Original input string

            // Print the original string
            Console.WriteLine($"Original: {input}");

            // Print the reversed string
            Console.WriteLine($"Reversed: {Reverse(input)}");

            // Wait for user input before closing console
            Console.ReadKey();
        }
    }
}

/*
📌 Features:
- Reverses a string using a stack
- Demonstrates stack Push and Pop operations
- Simple and clear logic with comments

🧠 Logic:
Characters are pushed into a stack one by one.
Due to the LIFO nature of stacks, popping them gives the reversed string.

💻 Sample Output:
Original: hello
Reversed: olleh

👨‍💻 Author:
Mohamed Mostafa
GitHub: https://github.com/MohamedMostafa02
Project Path: QueueProblems/ReverseString/
*/
