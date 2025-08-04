# Find Majority Element
## Overview  
This C# console application finds the majority element in a given integer array. A majority element is defined as an element that appears more than half of the array size (> n/2 times).
## Features
- Efficiently counts frequency of each element using a dictionary.
- Returns the majority element immediately when found.
- Returns -1 if no majority element exists.
- Clear and simple implementation suitable for educational purposes.
## How It Works
1. Initialize an empty dictionary to keep count of each element.
2. Traverse the array, incrementing count for each element.
3. Check if current element's count exceeds half the array length.
4. If yes, return that element as the majority.
5. If no element qualifies, return -1.
## Example
Input: int[] nums = { 3, 3, 4, 2, 3, 3, 3 };
Output: 3
Explanation: 3 appears 5 times out of 7, which is more than 7/2 = 3.5.
## Code Snippet
static int MajorityElement(int[] nums)
{
    Dictionary<int, int> counts = new Dictionary<int, int>();
    int majorityCount = nums.Length / 2;
    foreach (int num in nums)
    {
        if (counts.ContainsKey(num))
            counts[num]++;
        else
            counts[num] = 1;
        if (counts[num] > majorityCount)
            return num;
    }
    return -1;
}
## Complexity
- Time Complexity: O(n), where n is the number of elements in the array.
- Space Complexity: O(n) for storing counts in the dictionary.
## Alternative Approaches
- Boyer-Moore Voting Algorithm: Uses O(1) space and O(n) time, ideal when the majority element is guaranteed to exist.
## Author
Mohamed Mostafa
