using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static int BinarySearch(int[] arr , int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            int count  = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                count++;
                Console.WriteLine(count);

                if (arr[mid] == target)
                {
                    return mid;
                }

                if(target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 };

            int target = 51;

            Console.WriteLine("Sorted Array : "  );
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");

            }
            Console.WriteLine();

            int result = BinarySearch(arr, target);

            if (result == -1)
                Console.WriteLine("Element Not fount in the array..");
            else
                Console.WriteLine("Elemnt was found in the index : " + result);
        }
    }
}
