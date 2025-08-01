using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSignalSystemSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to simulate vehicles at a traffic signal
            Queue<string> q = new Queue<string>();

            // Add vehicles to the queue
            q.Enqueue("Car 1");
            q.Enqueue("Truck 1");
            q.Enqueue("Bike 1");
            q.Enqueue("Bus 1");

            // Start the traffic signal simulation
            Console.WriteLine("Traffic Signal Simulation Started....\n");

            // Loop until all vehicles have passed
            while (q.Count > 0)
            {
                // Remove the vehicle at the front of the queue (it's passing the signal)
                string Vehicle = q.Dequeue();
                Console.WriteLine(Vehicle + " has passed the signal.");

                // Check if there are more vehicles waiting
                if (q.Count > 0)
                {
                    // Display the vehicles still waiting in the queue
                    Console.WriteLine("Vehicles Waiting: " + string.Join(", ", q));
                }
                else
                {
                    // No vehicles left in the queue
                    Console.WriteLine("No vehicles waiting.");
                }

                // Add a blank line for spacing
                Console.WriteLine();
            }

            // Simulation ended
            Console.WriteLine("Traffic Signal Ended.");

            // Wait for user input before closing the program
            Console.ReadKey();
        }
    }
}
