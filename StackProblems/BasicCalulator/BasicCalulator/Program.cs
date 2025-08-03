using System;
using System.Collections.Generic;

namespace BasicCalculator
{
    internal class Program
    {
        // Method to evaluate a basic mathematical expression with +, -, and parentheses
        static int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>(); // Stack to store previous results and signs
            int result = 0;  // Final result
            int sign = 1;    // Current sign (1 for +, -1 for -)
            int num = 0;     // Current number being built from digits

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    // Build the number digit by digit (to handle multi-digit numbers)
                    num = num * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    // Apply the previous number with its sign to the result
                    result += sign * num;
                    num = 0;
                    sign = 1; // Set current sign to +
                }
                else if (c == '-')
                {
                    // Apply the previous number with its sign to the result
                    result += sign * num;
                    num = 0;
                    sign = -1; // Set current sign to -
                }
                else if (c == '(')
                {
                    // Save the current result and sign before the parentheses
                    stack.Push(result); // Push result first
                    stack.Push(sign);   // Push sign second
                    // Reset for inner expression
                    result = 0;
                    sign = 1;
                }
                else if (c == ')')
                {
                    // Finalize the number inside parentheses
                    result += sign * num;
                    num = 0;

                    // Multiply result by the sign before the parentheses
                    result *= stack.Pop();

                    // Add to the result before the parentheses
                    result += stack.Pop();
                }
                // Ignore spaces
            }

            // Add any remaining number after the loop
            result += sign * num;

            return result;
        }

        static void Main(string[] args)
        {
            // Test expression: 1 + (5 - 3) = 3
            Console.WriteLine(Calculate("1 + (5 - 3)"));
            Console.ReadKey(); // Wait for key press before closing
        }
    }
}
