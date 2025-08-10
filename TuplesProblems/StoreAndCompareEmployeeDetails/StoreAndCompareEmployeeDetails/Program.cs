using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAndCompareEmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a tuple for the first employee with Name and Salary
            var employee1 = (Name: "Alice", Salary: 50000);

            // Create a tuple for the second employee with Name and Salary
            var employee2 = (Name: "Bob", Salary: 60000);

            /* 
             * Compare the salaries of the two employees using a ternary operator.
             * If employee1's salary is greater than employee2's salary, print "higher".
             * Otherwise, print "lower".
             */
            Console.WriteLine($"{employee1.Name} has {(employee1.Salary > employee2.Salary ? "higher" : "lower")} salary than {employee2.Name}");

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
