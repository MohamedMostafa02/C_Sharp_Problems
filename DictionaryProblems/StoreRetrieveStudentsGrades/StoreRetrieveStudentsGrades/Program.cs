using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRetrieveStudentsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store student names and their corresponding grades
            Dictionary<string, double> students = new Dictionary<string, double>()
            {
                {"Alice", 85.5 },
                {"Bob", 90.0 },
                {"Charlie", 78.5 }
            };

            // Retrieve and print Bob's grade from the dictionary
            Console.WriteLine($"Student: Bob, Grade: {students["Bob"]}");

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
