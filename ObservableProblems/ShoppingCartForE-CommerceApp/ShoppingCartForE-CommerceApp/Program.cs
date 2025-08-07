using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ShoppingCartForE_CommerceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ObservableCollection to represent the shopping cart
            ObservableCollection<string> cart = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event to detect changes in the cart
            cart.CollectionChanged += (sender, e) =>
            {
                // Handle item addition to the cart
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Item Added to cart: {e.NewItems[0]}");

                // Handle item removal from the cart
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Item Removed from cart: {e.OldItems[0]}");

                // Handle item replacement in the cart
                if (e.Action == NotifyCollectionChangedAction.Replace)
                    Console.WriteLine($"Item Replaced: {e.OldItems[0]} with {e.NewItems[0]}");
            };

            // Add an item to the cart
            cart.Add("Laptop");

            // Add another item to the cart
            cart.Add("Mouse");

            // Replace the second item ("Mouse") with "Keyboard"
            cart[1] = "keyboard";

            // Remove the first item ("Laptop") from the cart
            cart.Remove("Laptop");

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
