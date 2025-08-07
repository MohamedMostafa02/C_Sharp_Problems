using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;     // For NotifyCollectionChangedAction
using System.Collections.ObjectModel;     // For ObservableCollection<T>

namespace LivechatAppliction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ObservableCollection to store chat messages
            ObservableCollection<string> chatMessages = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to monitor incoming messages
            chatMessages.CollectionChanged += (sender, e) =>
            {
                // When a new message is added to the collection, display it
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Message: {e.NewItems[0]}");
            };

            // Simulate receiving two messages
            chatMessages.Add("Hello");
            chatMessages.Add("How Are You?");

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
