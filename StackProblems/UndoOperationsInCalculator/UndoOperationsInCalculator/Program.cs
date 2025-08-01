using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoOperationsInCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack to store results
            Stack<int> CalculatorStack = new Stack<int>();

            // Add some values to the stack
            CalculatorStack.Push(10);
            CalculatorStack.Push(20);
            CalculatorStack.Push(30);

            // Undo last operation (remove the last value)
            Console.WriteLine("Undo: " + CalculatorStack.Pop());

            // Show the current result (top value in the stack)
            Console.WriteLine("Current Result: " + CalculatorStack.Peek());

            // Wait for key press to close the program
            Console.ReadKey();
        }
    }
}
