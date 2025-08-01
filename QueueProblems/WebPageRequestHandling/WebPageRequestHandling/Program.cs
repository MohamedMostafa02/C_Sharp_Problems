using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageRequestHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to simulate incoming web page requests
            Queue<string> Requests = new Queue<string>();

            // Enqueue simulated web requests
            Requests.Enqueue("Request1");
            Requests.Enqueue("Request2");
            Requests.Enqueue("Request3");
            Requests.Enqueue("Request4");

            // Print header for request processing
            Console.WriteLine("Processing Web Page Requests:\n");

            // Process each request in FIFO order
            while (Requests.Count > 0)
            {
                // Dequeue the next request from the queue
                string request = Requests.Dequeue();

                // Simulate processing of the request
                Console.WriteLine($"Processed: {request}");
            }

            // Wait for user to press a key before closing the console
            Console.ReadKey();
        }
    }
}
