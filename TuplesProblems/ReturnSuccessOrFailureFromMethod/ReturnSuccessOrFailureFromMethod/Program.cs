using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSuccessOrFailureFromMethod
{
    internal class Program
    {
        // Method that checks a student's status and returns both success flag and the value
        // Returns a tuple: (bool success, int value)
        static (bool success, int value) CheckStudentStatus(int input)
        {
            // Determine success: true if input is >= 50, otherwise false
            bool success = input >= 50 ? true : false;

            // Return the tuple (success flag, original input value)
            return (success, input);
        }

        static void Main(string[] args)
        {
            // Call the method with a sample value of 55 and store the result in a tuple
            var result = CheckStudentStatus(55);

            // Print the result: shows whether success is true/false and the original value
            Console.WriteLine($"Success: {result.success}, Value: {result.value}");

            // Wait for the user to press a key before closing
            Console.ReadKey();
        }
    }
}
