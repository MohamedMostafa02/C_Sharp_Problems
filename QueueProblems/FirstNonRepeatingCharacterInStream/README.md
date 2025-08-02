# First Non-Repeating Character in Stream

## Description

This project implements a solution to find the **first non-repeating character** in a stream of characters at each step of input.

Given a stream (sequence) of characters, the program processes characters one by one and prints the first character that has not been repeated so far after reading each character. If all characters read so far are repeating, it prints `-`.

## How It Works

- Uses a **Dictionary** to keep track of the count of each character.
- Uses a **Queue** to maintain the order of characters as they appear in the stream.
- For each new character read:
  - Increment its count in the dictionary.
  - Enqueue it in the queue.
  - Remove characters from the front of the queue while their count is more than 1 (meaning they repeated).
- The front of the queue after this cleanup is the first non-repeating character.
- If the queue is empty, print `-`.

## Example

Input stream: `aabc`

Step-by-step output:

| Input char | First non-repeating char |
|------------|--------------------------|
| a          | a                        |
| a          | -                        |
| b          | b                        |
| c          | b                        |

## Usage

1. Clone or download the repository.
2. Open the solution in Visual Studio (or your preferred C# IDE).
3. Run the program.
4. Modify the input string in the `Main` method to test different streams.

## Code Example

```csharp
FindFirstNonRepeating("aabc");

a
-
b
b

Author
Mohamed Mostafa
