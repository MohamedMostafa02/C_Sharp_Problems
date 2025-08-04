
# Find Duplicate Elements  
## Overview  
This C# console application finds all duplicate elements in a given integer array. A duplicate is any value that appears more than once. Each duplicate will appear only once in the result list, even if it appears multiple times in the input.  

## Features  
- Detects elements that occur more than once  
- Uses a Dictionary to count frequencies  
- Adds an element to the result only when its count reaches exactly 2  
- Efficient, simple, and easy to read  

## How It Works  
1. Create a Dictionary<int, int> to store the frequency of each number  
2. Iterate through the array  
   - If the number exists in the dictionary, increment its count  
   - If the count becomes exactly 2, add it to the duplicates list  
   - If it's not in the dictionary, add it with count = 1  
3. Return the list of duplicate elements  

## Example  
Input:  
int[] nums = { 1, 2, 3, 4, 2, 5, 6, 1 };  

Output:  
1, 2  

Explanation:  
The numbers 1 and 2 each appear twice, so they are returned as duplicates.  

## Code Snippet  
static List<int> FindDublicates(int[] nums)  
{  
    Dictionary<int, int> counts = new Dictionary<int, int>();  
    List<int> duplicates = new List<int>();  

    foreach (int num in nums)  
    {  
        if (counts.ContainsKey(num))  
        {  
            counts[num]++;  
            if (counts[num] == 2)  
            {  
                duplicates.Add(num);  
            }  
        }  
        else  
        {  
            counts[num] = 1;  
        }  
    }  

    return duplicates;  
}  

## Time and Space Complexity  
- Time Complexity: O(n)  
- Space Complexity: O(n)  
Where n is the length of the input array  

## Author  
Mohamed Mostafa
