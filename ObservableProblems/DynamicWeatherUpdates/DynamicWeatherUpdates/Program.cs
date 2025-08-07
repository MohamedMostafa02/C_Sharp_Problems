using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel; // Required for ObservableCollection
using System.Collections.Specialized; // Required for NotifyCollectionChangedEventArgs

namespace DynamicWeatherUpdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an observable collection to hold weather update strings
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to respond to additions or removals
            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                // If a new item is added, print the update to the console
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");
            };

            // Add two sample weather updates to the collection
            weatherUpdates.Add("New York: Sunny, 25°");
            weatherUpdates.Add("London: Rainy, 15°");

            // Wait for user input before closing the program
            Console.ReadKey();
        }
    }
}
