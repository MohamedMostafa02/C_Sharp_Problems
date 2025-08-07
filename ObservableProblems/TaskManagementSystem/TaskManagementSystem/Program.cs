using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;   // Provides ObservableCollection<T>
using System.Collections.Specialized;   // Provides NotifyCollectionChangedAction

namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ObservableCollection to hold task names
            ObservableCollection<string> tasks = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to track real-time updates
            tasks.CollectionChanged += (sender, e) =>
            {
                // If a new task is added, display it
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Task Added: {e.NewItems[0]}");

                // If a task is removed, display it
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Task Removed: {e.OldItems[0]}");
            };

            // Add two tasks to the collection
            tasks.Add("Complete report");
            tasks.Add("Attend meeting");

            // Remove one task from the collection
            tasks.Remove("Complete report");

            // Wait for key press before closing the console
            Console.ReadKey();
        }
    }
}
