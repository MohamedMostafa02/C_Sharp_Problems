using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestConsecutiveSequence
{
    internal class Program
    {
        // Method 1: Efficient approach using HashSet (O(n) time)
        static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            // Use HashSet for O(1) lookup times
            HashSet<int> set = new HashSet<int>(nums);

            int longestStreak = 0;

            foreach (int num in set)
            {
                // Only start counting if it's the beginning of a sequence
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    // Keep incrementing as long as the next number exists in the set
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    // Update the maximum streak found so far
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        // Method 2: Simpler approach using sorting (O(n log n) time)
        static int LongestConsecutive2(int[] nums)
        {
            if (nums.Length == 0) return 0;

            // Sort the array
            Array.Sort(nums);

            int longestStreak = 1;
            int currentStreak = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                // Skip duplicates
                if (nums[i] == nums[i - 1])
                {
                    continue;
                }
                // If current number is consecutive to previous, increase streak
                else if (nums[i] == nums[i - 1] + 1)
                {
                    currentStreak++;
                }
                // Not consecutive, reset streak
                else
                {
                    currentStreak = 1;
                }

                // Update the max streak
                longestStreak = Math.Max(longestStreak, currentStreak);
            }

            return longestStreak;
        }

        static void Main(string[] args)
        {
            // Input array
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            // Output using HashSet-based method
            Console.WriteLine(LongestConsecutive(nums)); // Output: 4

            // Output using sort-based method
            Console.WriteLine(LongestConsecutive2(nums)); // Output: 4

            Console.ReadKey();
        }
    }
}
