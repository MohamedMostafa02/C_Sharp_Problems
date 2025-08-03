using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to act as a phone book
            // Keys are names (strings), values are phone numbers (strings)
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                {"Alice", "123-456-7890" },
                {"Bob", "987-654-3210" }
            };

            // Print Alice's phone number using dictionary lookup
            Console.WriteLine($"Alice's Phone: {phoneBook["Alice"]}");

            // Print Bob's phone number using dictionary lookup
            Console.WriteLine($"Bob's Phone: {phoneBook["Bob"]}");

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
