using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySalesForDifferentProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to store sales data for 3 different products
            int[][] productSales = new int[3][];

            // Assign sales data for each product
            // Product 1 has sales for 3 days
            productSales[0] = new int[] { 100, 200, 300 };
            // Product 2 has sales for 2 days
            productSales[1] = new int[] { 300, 400 };
            // Product 3 has sales for 4 days
            productSales[2] = new int[] { 500, 600, 550, 700 };

            // Display the sales data
            Console.WriteLine("Sales Data:");

            // Loop through each product
            for (int i = 0; i < productSales.Length; i++)
            {
                // Print the product number (i+1 because arrays start from index 0)
                Console.WriteLine($"Product {i + 1}");

                // Loop through each sale of the current product
                foreach (int sale in productSales[i])
                {
                    // Print the sale amount followed by a space
                    Console.Write(sale + " ");
                }

                // Move to the next line after printing all sales for the product
                Console.WriteLine();
            }

            // Wait for the user to press a key before closing the program
            Console.ReadKey();
        }
    }
}
