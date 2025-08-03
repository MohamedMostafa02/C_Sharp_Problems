# CountWordFrequenciesInText

A simple C# console application that counts how many times each word appears in a given string.

## Features
- Uses Dictionary<string, int> to track word frequencies.
- Splits the input text by spaces and counts each word.
- Displays the frequency of each word in the console.

## Example Input
hello world hello universe

## Example Output
hello: 2  
world: 1  
universe: 1

## Code Overview
- The input string is hardcoded as 'text'.
- The string is split into words using Split(' ').
- A dictionary is used to count how many times each word appears.
- The results are printed using a foreach loop.

## How to Run
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the project.
3. View the word frequency output in the console.

## Author
Mohamed Mostafa
