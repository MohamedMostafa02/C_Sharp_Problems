using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightSeatReservations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to represent seat availability for 2 flights
            // Each flight has an array of bools where:
            // true  = seat is available
            // false = seat is occupied
            bool[][] flightSeats = new bool[2][];

            // Initialize seat availability for flight 1 with 3 seats
            flightSeats[0] = new bool[] { true, false, true };
            // Initialize seat availability for flight 2 with 4 seats
            flightSeats[1] = new bool[] { false, false, true, true };

            // Print a header for seat availability output
            Console.WriteLine("Seat Availability");

            // Loop through each flight in the jagged array
            for (int i = 0; i < flightSeats.Length; i++)
            {
                // Print flight number (index + 1 for human-readable)
                Console.WriteLine($"Flight {i + 1}");

                // Loop through each seat in the current flight
                foreach (bool seat in flightSeats[i])
                {
                    // Use a ternary operator to print "Available" if seat is true,
                    // otherwise print "Occupied"
                    Console.Write(seat ? "Available " : "Occupied ");
                }

                // Move to next line after printing all seats for the flight
                Console.WriteLine();
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
