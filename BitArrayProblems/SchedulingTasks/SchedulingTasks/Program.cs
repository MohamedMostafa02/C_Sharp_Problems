using System;
using System.Collections; // Needed for BitArray
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BitArray of 7 elements, all initialized to 'true'
            // 'true' here means the day is occupied/busy.
            BitArray schedule = new BitArray(7, true);

            // Mark day 6 as free (index 5)
            schedule[5] = false;

            // Mark day 7 as free (index 6)
            schedule[6] = false;

            // Print header for free days
            Console.WriteLine("Free Days:");

            // Loop through each day of the week
            for (int i = 0; i < 7; i++)
            {
                // If the value is 'false', it means the day is free
                if (!schedule[i])
                    // Print the day number (i + 1 to convert from 0-based index to human-readable)
                    Console.WriteLine($"Day {i + 1}");
            }

            // Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
