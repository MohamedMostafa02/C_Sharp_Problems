# FindElementsLessThanValue - C# Console Application

This simple C# console application demonstrates how to retrieve all elements from a SortedSet<int> that are less than a specified value using GetViewBetween.

## Features
- Uses SortedSet<int> to maintain a sorted collection automatically.
- Retrieves elements less than a specified value using GetViewBetween(int.MinValue, value - 1).
- Demonstrates LINQ-friendly and efficient data filtering.

## How It Works
- The method ElementsLessThan takes a SortedSet and a value.
- It returns all elements less than the given value by creating a view between int.MinValue and value - 1.
- In Main, a sample set {1, 2, 3, 4, 5} is used with value = 4, and the matching elements are printed.

## Example Output
1, 2, 3

## Usage
- Open the project in Visual Studio.
- Run the application.
- Modify the SortedSet or value to test with different data.

## Author
Written in C# as a basic demonstration of SortedSet filtering logic.

