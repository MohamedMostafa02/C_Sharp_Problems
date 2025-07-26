using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n -1; i++)
            {
                for(int j = 0;j < n -i-1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1] ,arr[j]);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array: "    );
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            BubbleSort(arr);

            Console.WriteLine("\nSorted Array: ");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
