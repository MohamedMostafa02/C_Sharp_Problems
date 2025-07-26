using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void SelectionSortAsc(int[]arr)
        {
            int n = arr.Length;

            for(int i  = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[j] < arr[minIndex])
                    {
                        minIndex  = j;
                    }
                }

                (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
            }
        }

        static void SelectionSortDesc(int[]arr)
        {
            int n = arr.Length;

            for (int i = 0;i < n - 1; i++)
            {
                int maxIndex = i;

                for(int j =i + 1; j < n;j++)
                {
                    if( arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                (arr[maxIndex], arr[i]) = (arr[i],arr[maxIndex]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array : "   );
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }

            SelectionSortAsc(arr);

            Console.WriteLine("\nSorted Array ASC : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }

            SelectionSortDesc(arr);

            Console.WriteLine("\nSorted Array Desc : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
