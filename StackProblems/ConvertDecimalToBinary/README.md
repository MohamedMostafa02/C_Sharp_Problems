# 🔢 Convert Decimal to Binary using Stack (C#)

This is a simple C# console application that converts a **decimal number to binary** using a **Stack** data structure.

## 📌 Description

The program demonstrates how to convert a decimal number into binary form manually, using the remainder method and storing the bits in a **stack** to reverse the order correctly.

## 🧠 Concepts Used

- `Stack<int>` from `System.Collections.Generic`
- Division by 2 and remainder to generate binary digits
- Reversing order using stack: most significant bit should be printed last

## 💻 Code Sample

```csharp
static string DecimalToBinary(int number)
{
    Stack<int> stack = new Stack<int>();

    while(number > 0)
    {
        stack.Push(number % 2); // Store remainder (0 or 1)
        number /= 2;            // Divide number by 2
    }

    return string.Join("", stack); // Convert stack to binary string
}

static void Main(string[] args)
{
    Console.WriteLine(DecimalToBinary(10)); // Output: 1010
    Console.ReadKey();
}
```

## 🧪 Output

```
1010
```

## 📁 Project Structure

```
ConvertDecimalToBinary/
│
├── Program.cs       # Main program file
├── README.md        # Project documentation (this file)
```

## ✅ Requirements

- .NET Framework / .NET Core
- Visual Studio or any C# compiler
