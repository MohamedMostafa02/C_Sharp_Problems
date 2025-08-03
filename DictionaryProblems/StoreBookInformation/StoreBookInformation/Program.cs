using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBookInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store book information with ISBN as the key,
            // and a tuple containing Title and Author as the value
            Dictionary<string, (string Title, string Author)> books = new Dictionary<string, (string Title, string Author)>()
            {
                // Add two books with their ISBNs, titles, and authors
                {"978-3-16-148410-0", ("The Great Gatsby", "F. Scott Fitzgerald") },
                {"978-1-61-729494-5", ("C# in Depth", "Jon Skeet") }
            };

            // Iterate through each book in the dictionary
            foreach (var book in books)
            {
                // Print ISBN, title, and author of the current book
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value.Title}, Author: {book.Value.Author}");
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
