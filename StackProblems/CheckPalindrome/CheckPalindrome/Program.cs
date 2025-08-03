using System;
using System.Collections.Generic;

namespace CheckPalindrome
{
    internal class Program
    {
        // Method to check if a given string is a palindrome using a stack
        static bool IsPalindrome(string input)
        {
            Stack<char> stack = new Stack<char>(); // Stack to reverse the string

            // Push all characters of the string into the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Compare each character of the original string
            // with the one popped from the stack (i.e., reversed string)
            foreach (char c in input)
            {
                if (stack.Pop() != c)
                {
                    // If any character doesn't match, it's not a palindrome
                    return false;
                }
            }

            // All characters matched in reverse order, so it's a palindrome
            return true;
        }

        static void Main(string[] args)
        {
            // Test case 1: Palindrome word
            string input = "madam";
            Console.WriteLine($"Is \"{input}\" a palindrome? {IsPalindrome(input)}");

            // Test case 2: Not a palindrome
            input = "hello";
            Console.WriteLine($"Is \"{input}\" a palindrome? {IsPalindrome(input)}");

            Console.ReadKey(); // Wait for a key press before closing the console
        }
    }
}
