﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void InsertionSort(int[]arr)
        {
            int n = arr.Length;
            for(int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1]  = key;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original Array: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            InsertionSort(arr);
            Console.WriteLine("\nSorted Array: "    );
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
