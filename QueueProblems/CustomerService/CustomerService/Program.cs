using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to store customer names
            Queue<string> customers = new Queue<string>();

            // Enqueue customers into the queue
            customers.Enqueue("Customer1");
            customers.Enqueue("Customer2");
            customers.Enqueue("Customer3");

            // Display the start of customer service
            Console.WriteLine("Serving Customers:\n");

            // Serve customers while the queue is not empty
            while (customers.Count > 0)
            {
                // Dequeue the next customer (FIFO order)
                string customer = customers.Dequeue();

                // Display the customer being served
                Console.WriteLine($"Serving: {customer}");
            }

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
