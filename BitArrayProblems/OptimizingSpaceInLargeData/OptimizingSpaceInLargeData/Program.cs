using System;
using System.Collections; // Needed for BitArray
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingSpaceInLargeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BitArray with 1000 bits, all initially set to 'false'
            // 'false' here means the seat is not booked.
            BitArray seats = new BitArray(1000, false);

            // Book seat number 101 (index 100 because indexes start at 0)
            seats[100] = true;

            // Book seat number 1000 (index 999)
            seats[999] = true;

            // Display the booking status of seat 101
            Console.WriteLine($"Seat 101 booked: {seats[100]}");

            // Display the booking status of seat 1000
            Console.WriteLine($"Seat 1000 booked: {seats[999]}");

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
