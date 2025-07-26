using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{

   
    internal class Program
    {

        static int LinearSearch(int[] arr, int target)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
               if( arr[i] == target)
                return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            int target = 99;

            Console.WriteLine("Original Array: ");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }

            int result = LinearSearch(arr, target);
            
            if(result == -1)
                Console.WriteLine("Element not Fount in the array.."    );
            else
                Console.WriteLine("Element fount at index : "+ result);
        }
    }
}
