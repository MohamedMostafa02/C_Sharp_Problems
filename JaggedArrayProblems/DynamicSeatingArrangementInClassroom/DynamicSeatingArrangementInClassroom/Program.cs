using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSeatingArrangementInClassroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array to represent rows of seats in a classroom
            int[][] classroomSeats = new int[3][];

            // Initialize each row with a different number of seats
            classroomSeats[0] = new int[] { 1, 2, 3 };         // Row 1 has 3 seats
            classroomSeats[1] = new int[] { 4, 5 };            // Row 2 has 2 seats
            classroomSeats[2] = new int[] { 6, 7, 8, 9 };      // Row 3 has 4 seats

            // Loop through each row
            for (int i = 0; i < classroomSeats.Length; i++)
            {
                // Print the row number
                Console.WriteLine($"Row {i + 1}");

                // Loop through each seat in the current row and print it
                foreach (int seat in classroomSeats[i])
                {
                    Console.Write(seat + " ");
                }

                // Move to the next line after printing all seats in the row
                Console.WriteLine();
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
