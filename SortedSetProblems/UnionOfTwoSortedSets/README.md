# UnionOfTwoSortedSets

This C# console application demonstrates how to perform a union operation between two `SortedSet<int>` collections.

## What It Does

- Creates two sorted sets: `set1` and `set2`
- Uses `UnionWith()` to merge `set2` into `set1` (removing duplicates automatically)
- Prints the result to the console

## Example

Input:
set1 = { 1, 2, 3 }
set2 = { 3, 4, 5 }

Output:
1, 2, 3, 4, 5

## Key Concepts

- `SortedSet<T>`: Stores unique elements in sorted order
- `UnionWith()`: Adds all elements from another set, ignoring duplicates
- `Console.WriteLine()`: Displays output
- `string.Join()`: Joins elements into a string separated by commas

## How to Run

1. Open the project in Visual Studio or another C# IDE
2. Run the program
3. The result of the union will be displayed in the console

## Author

Mohamed Mostafa
