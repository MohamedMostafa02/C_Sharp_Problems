using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalEmployeeManagement
{
    // Represents an employee in the company hierarchy
    class EmployeeNode
    {
        // Name of the employee
        public string Name { get; set; }

        // Position or job title of the employee
        public string Position { get; set; }

        // List of direct subordinates (employees who report to this employee)
        public List<EmployeeNode> Subordinates { get; set; } = new List<EmployeeNode>();

        // Constructor to initialize an employee with a name and position
        public EmployeeNode(string name, string position)
        {
            Name = name;
            Position = position;
        }

        // Recursive method to print the hierarchy starting from this employee
        public void Print(string indent = "")
        {
            // Print the current employee with indentation
            Console.WriteLine($"{indent}{Position}: {Name}");

            // Recursively print all subordinates with increased indentation
            foreach (var subordinate in Subordinates)
            {
                subordinate.Print(indent + "  ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the CEO
            var ceo = new EmployeeNode("Alice", "CEO");

            // Create VP of Marketing and a Marketing Manager under them
            var vp = new EmployeeNode("Bob", "VP Of Marketing");
            var manager = new EmployeeNode("Charlie", "Marketing Manager");

            // Add the Marketing Manager under the VP of Marketing
            vp.Subordinates.Add(manager);

            // Add the VP of Marketing under the CEO
            ceo.Subordinates.Add(vp);

            // Create VP of Technology and an Architect under them
            vp = new EmployeeNode("Lara", "VP Of Technology");
            manager = new EmployeeNode("Tom", "Architect");

            // Add the Architect under the VP of Technology
            vp.Subordinates.Add(manager);

            // Add the VP of Technology under the CEO
            ceo.Subordinates.Add(vp);

            // Print the company hierarchy starting from the CEO
            Console.WriteLine("Company Hierarchy");
            ceo.Print();

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
