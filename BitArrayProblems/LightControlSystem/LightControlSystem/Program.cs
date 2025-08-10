using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BitArray of 8 lights, all initially set to false (off)
            BitArray lights = new BitArray(8, false);

            // Turn on the first light (index 0)
            lights[0] = true;

            // Turn on the sixth light (index 5)
            lights[5] = true;

            // Display the status of the first and sixth lights
            Console.WriteLine($"Light 1: {lights[0]}, Light 6: {lights[5]}");

            // Reset all lights to off
            lights.SetAll(false);

            // Display the status of the first light after reset
            Console.WriteLine($"Light 1 After reset: {lights[0]}");

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
