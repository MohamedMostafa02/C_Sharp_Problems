using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel; // For ObservableCollection
using System.Collections.Specialized; // For NotifyCollectionChangedEventArgs

namespace DynamicListOfStudentsInClassroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dynamic list of students using ObservableCollection
            ObservableCollection<string> students = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to detect when items are added or removed
            students.CollectionChanged += (sender, e) =>
            {
                // If a new item was added to the collection
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");

                // If an item was removed from the collection
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");
            };

            // Add students to the collection (this will trigger the "Add" event)
            students.Add("Alice");
            students.Add("Bob");

            // Remove a student from the collection (this will trigger the "Remove" event)
            students.Remove("Alice");

            // Wait for a key press before closing the program
            Console.ReadKey();
        }
    }
}
