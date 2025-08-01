using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystemSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to store ticket numbers
            Queue<int> q = new Queue<int>();

            // Issue tickets from 101 to 105 and add them to the queue
            for (int i = 101; i <= 105; i++)
            {
                q.Enqueue(i); // Add ticket to the queue
                Console.WriteLine($"Ticket {i} is issued.");
            }

            Console.WriteLine("\nTicketing System Simulation Started...\n");

            // Process tickets one by one in FIFO order
            while (q.Count > 0)
            {
                // Remove the first ticket in the queue
                int ticket = q.Dequeue();

                Console.WriteLine($"Processing Ticket: {ticket}");

                // Show remaining tickets in the queue
                if (q.Count > 0)
                {
                    Console.WriteLine("Remaining Tickets: " + string.Join(", ", q));
                }
                else
                {
                    Console.WriteLine("No More Tickets in the Queue.");
                }
            }

            // End of simulation
            Console.WriteLine("Ticketing System Simulation Ended.");

            // Wait for user key press before closing
            Console.ReadKey();
        }
    }
}
