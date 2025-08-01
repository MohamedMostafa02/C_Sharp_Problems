using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterJobScheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to store print jobs
            Queue<string> printQueue = new Queue<string>();

            // Add print jobs to the queue
            printQueue.Enqueue("Document1");
            printQueue.Enqueue("Document2");
            printQueue.Enqueue("Document3");

            // Process (remove and show) the first job in the queue
            Console.WriteLine("Processing: " + printQueue.Dequeue());

            // Show the next job in the queue without removing it
            Console.WriteLine("Next Job: " + printQueue.Peek());
        }
    }
}
