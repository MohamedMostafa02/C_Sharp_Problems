using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMarksOfStudentsInMultipleSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a jagged array where each element represents a student's marks in multiple subjects.
            // Each student can have a different number of subjects.
            int[][] studentMarks = new int[][]
            {
                new int[] {90, 85, 88},       // Student 1: 3 subjects
                new int[] {76, 80},           // Student 2: 2 subjects
                new int[] {92, 93, 89, 85}    // Student 3: 4 subjects
            };

            // Loop through each student in the jagged array
            for (int i = 0; i < studentMarks.Length; i++)
            {
                // Print the student number
                Console.WriteLine($"Student {i + 1}:");

                // Join the student's marks with commas and print them
                Console.WriteLine(string.Join(", ", studentMarks[i]));
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
