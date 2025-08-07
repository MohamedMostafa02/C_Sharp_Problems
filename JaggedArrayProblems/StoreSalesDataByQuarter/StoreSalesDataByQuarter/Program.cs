using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSalesDataByQuarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jagged array to store sales data for different regions
            // Each region can have different number of quarters
            int[][] salesData = new int[][]
            {
                new int[] { 10000, 12000, 11000 },      // Region 1: 3 quarters of data
                new int[] { 15000, 16000 },             // Region 2: 2 quarters of data
                new int[] { 9000, 9500, 9800, 10200 }    // Region 3: 4 quarters of data
            };

            // Loop through each region
            for (int i = 0; i < salesData.Length; i++)
            {
                // Display region number (starting from 1)
                Console.WriteLine($"Region {i + 1}");

                // Display sales data for that region using string.Join to format the output
                Console.WriteLine(string.Join(", ", salesData[i]));
            }

            // Wait for key press to keep the console open
            Console.ReadKey();
        }
    }
}
