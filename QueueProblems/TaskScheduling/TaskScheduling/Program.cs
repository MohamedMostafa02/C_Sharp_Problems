using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskScheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to store tasks
            Queue<string> Tasks = new Queue<string>();

            // Enqueue tasks into the queue
            Tasks.Enqueue("Task1");
            Tasks.Enqueue("Task2");
            Tasks.Enqueue("Task3");
            Tasks.Enqueue("Task4");

            // Print a message indicating task execution
            Console.WriteLine("Executing Tasks: ");

            // Process tasks while the queue is not empty
            while (Tasks.Count > 0)
            {
                // Dequeue the next task (FIFO order)
                string task = Tasks.Dequeue();

                // Display the task being processed
                Console.WriteLine($"Processing: {task}");
            }

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
