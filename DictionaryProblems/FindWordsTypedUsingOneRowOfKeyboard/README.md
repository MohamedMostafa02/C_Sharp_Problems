
# Project: FindWordsTypedUsingOneRowOfKeyboard

## Description:
This simple C# console application filters and returns the words from a given array that can be typed using letters from only **one row** of a QWERTY keyboard.

## How it Works:
- The QWERTY keyboard is divided into three rows:
  - Row 0: `"qwertyuiop"`
  - Row 1: `"asdfghjkl"`
  - Row 2: `"zxcvbnm"`
- A dictionary (`charRow`) maps each character to its corresponding row index.
- For each word in the input array:
  - The row index of its first letter (lowercased) is taken as the reference.
  - All characters are checked to ensure they belong to the same row.
  - If valid, the word is added to the result list.

## Example:
Input: `["Hello", "Alaska", "Dad", "Peace"]`  
Output: `Alaska, Dad`

## Key Components:
- **Dictionary<char, int> charRow**: Maps each character to its row index.
- **List<string> result**: Holds the words that can be typed using one row.
- **char.ToLower**: Ensures case-insensitive comparison.

## How to Run:
1. Compile the C# code in a .NET-compatible IDE or with `csc`.
2. Run the executable.
3. It will display the valid words from the input.

## Author:
Generated with explanation for learning purposes.

