using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackUniqueVisitors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a HashSet to store unique visitor IP addresses
            // HashSet automatically prevents duplicates
            HashSet<string> uniqueVisitors = new HashSet<string>();

            // Add IP addresses to the HashSet
            uniqueVisitors.Add("192.168.1.1"); // first visitor
            uniqueVisitors.Add("192.168.1.2"); // second visitor
            uniqueVisitors.Add("192.168.1.2"); // duplicate, will not be added again

            // Display the number of unique visitors
            Console.WriteLine("Unique Visitors: " + uniqueVisitors.Count);

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
