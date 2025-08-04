# Project: FindMissingNumberInArray

## Description:
This C# console application finds a single missing number from an array that should contain all numbers from 0 to n (inclusive), with exactly one number missing. The array is assumed to be of length n, containing distinct numbers in the range [0, n].

## How It Works:
- The input array is stored in a HashSet for fast lookup (O(1)).
- The code loops from 0 to n and checks if each number exists in the set.
- The first number not found in the set is returned as the missing number.
- If no number is missing, -1 is returned (this is a fallback and shouldn't happen with valid input).

## Example:
Input:
int[] nums = { 3, 0, 1 };
Output:
2

Explanation:
The array should contain numbers from 0 to 3. The number 2 is missing.

## Code Logic:
HashSet<int> set = new HashSet<int>(nums);
for (int i = 0; i <= n; i++) {
    if (!set.Contains(i))
        return i;
}
return -1;

## Limitations:
- The current code does NOT validate input.
- If the array contains a number greater than n (e.g., 200), the logic may return incorrect results.
- It also doesn't check for duplicate values.
- It assumes the array contains exactly one missing number from the range [0, n].

## Recommended Improvements:
- Add validation to check that all numbers are within the expected range.
- Handle duplicate entries if needed.
- Extend the algorithm to find multiple missing numbers, if the requirement changes.

## How to Run:
1. Open the project in any C# IDE (like Visual Studio).
2. Paste the code into a `.cs` file.
3. Modify the input array in the Main method if needed.
4. Run the project to see the missing number printed in the console.

## Author:
Code provided by the user; documentation and explanation written by ChatGPT for educational purposes.
