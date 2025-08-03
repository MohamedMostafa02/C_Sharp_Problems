using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveInvalidParentheses
{
    internal class Program
    {
        // Function to remove invalid parentheses from a string
        static string RemoveInvalidParentheses(string s)
        {
            // Stack to keep track of indices of opening parentheses '('
            Stack<int> stack = new Stack<int>();

            // HashSet to store indices of invalid parentheses to remove later
            HashSet<int> invalidIndices = new HashSet<int>();

            // Iterate through the string character by character
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    // If it's an opening parenthesis, push its index to the stack
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        // If there's no matching opening parenthesis, mark it as invalid
                        invalidIndices.Add(i);
                    }
                    else
                    {
                        // If there's a match, pop the opening parenthesis index
                        stack.Pop();
                    }
                }
            }

            // Any remaining indices in the stack are unmatched opening parentheses
            while (stack.Count > 0)
            {
                invalidIndices.Add(stack.Pop());
            }

            // Build the result string, skipping invalid parentheses
            char[] result = new char[s.Length - invalidIndices.Count];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Add characters that are not in the invalid indices
                if (!invalidIndices.Contains(i))
                {
                    result[index++] = s[i];
                }
            }

            // Return the final cleaned-up string
            return new string(result);
        }

        static void Main(string[] args)
        {
            // Test the function with a string containing extra closing parenthesis
            Console.WriteLine(RemoveInvalidParentheses("(()))")); // Expected output: "(())"
            Console.ReadKey();
        }
    }
}
