using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValuesFromFunction
{
    internal class Program
    {
        // A method that returns multiple values using a tuple
        // The tuple contains a string (name), an int (age), and a double (grade)
        static (string name, int age, double grade) GetStudentDetails()
        {
            // Return a tuple with student details
            return ("Alice", 20, 85.5);
        }

        static void Main(string[] args)
        {
            // Call the method and store the returned tuple in a variable
            var student = GetStudentDetails();

            // Print the values from the tuple by accessing its named fields
            Console.WriteLine($"Name: {student.name}, Age: {student.age}, Grade: {student.grade}");

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
