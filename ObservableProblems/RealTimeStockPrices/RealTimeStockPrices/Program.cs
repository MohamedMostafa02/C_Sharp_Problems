using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel; // For ObservableCollection
using System.Collections.Specialized; // For NotifyCollectionChangedAction

namespace RealTimeStockPrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ObservableCollection to hold stock prices
            ObservableCollection<string> stockPrices = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to handle real-time updates
            stockPrices.CollectionChanged += (sender, e) =>
            {
                // If a new item is added, display a message
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Stock Price Added: {e.NewItems[0]}");

                // If an item is removed, display a message
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Stock Price Removed: {e.OldItems[0]}");
            };

            // Add some stock prices to the collection
            stockPrices.Add("AAPL: 150.00");   // Apple stock
            stockPrices.Add("MSFT: 240.50");   // Microsoft stock

            // Remove a stock price from the collection
            stockPrices.Remove("AAPL: 150.00");

            // Wait for a key press before closing the program
            Console.ReadKey();
        }
    }
}
