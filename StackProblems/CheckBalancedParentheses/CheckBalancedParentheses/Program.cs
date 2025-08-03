using System;
using System.Collections.Generic;

namespace CheckBalancedParentheses
{
    internal class Program
    {
        // Method to check if the input string has balanced parentheses
        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>(); // Stack to hold opening brackets

            foreach (char c in input)
            {
                // If the character is an opening bracket, push it to the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // If the character is a closing bracket
                else if (c == ')' || c == '}' || c == ']')
                {
                    // If stack is empty, there's no matching opening bracket
                    if (stack.Count == 0)
                        return false;

                    // Pop the top element from the stack
                    char top = stack.Pop();

                    // Check if the popped opening bracket matches the closing one
                    if (c == ')' && top != '(' ||
                        c == '}' && top != '{' ||
                        c == ']' && top != '[')
                    {
                        // Mismatched brackets
                        return false;
                    }
                }
            }

            // If stack is empty at the end, all brackets matched correctly
            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            // Test case 1: Balanced brackets
            string input = "({[]})";
            Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");

            // Test case 2: Incorrectly nested brackets
            input = "({[)]}";
            Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");

            Console.ReadKey();
        }
    }
}
