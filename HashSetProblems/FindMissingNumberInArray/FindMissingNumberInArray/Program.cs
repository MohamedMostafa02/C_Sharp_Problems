using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumberInArray
{
    internal class Program
    {
        static int FindMissingNumber(int[]nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int n = nums.Length;


            for (int i = 0; i <= n; i++)
            {
                if(!set.Contains(i))
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 200, 0, 1 };

            Console.WriteLine(FindMissingNumber(nums));

            Console.ReadKey();
        }
    }
}
