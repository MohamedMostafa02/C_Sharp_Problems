using System;
using System.Collections.Generic;

namespace EvaluatePostfixExpression
{
    internal class Program
    {
        // Method to evaluate a postfix expression using a stack
        static int EvalutaePostfix(string expression)
        {
            Stack<int> stack = new Stack<int>(); // Stack to hold numbers during evaluation

            foreach (char c in expression)
            {
                if (c == ' ')
                    continue; // Skip spaces

                if (char.IsDigit(c))
                {
                    // Convert char digit to integer and push to stack
                    stack.Push(c - '0');  // e.g., '2' - '0' = 2
                }
                else
                {
                    // Ensure there are at least two operands before applying operator
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("Invalid expression: not enough operands.");
                        return 0;
                    }

                    // Pop the top two operands from the stack
                    int b = stack.Pop(); // Second operand
                    int a = stack.Pop(); // First operand

                    // Perform the operation and push the result back to the stack
                    switch (c)
                    {
                        case '+':
                            stack.Push(a + b);
                            break;
                        case '-':
                            stack.Push(a - b); // Order matters: a - b
                            break;
                        case '*':
                            stack.Push(a * b);
                            break;
                        case '/':
                            if (b == 0)
                            {
                                Console.WriteLine("Error: Division by zero.");
                                return 0;
                            }
                            stack.Push(a / b); // Order matters: a / b
                            break;
                        default:
                            Console.WriteLine($"Invalid operator: {c}");
                            return 0;
                    }
                }
            }

            // Final result should be the only item left on the stack
            return stack.Pop();
        }

        static void Main(string[] args)
        {
            // Example input: "231*+9-"
            // Which means: 2 + (3 * 1) - 9 = -4
            Console.WriteLine(EvalutaePostfix("231*+9-"));
            Console.ReadKey();
        }
    }
}
