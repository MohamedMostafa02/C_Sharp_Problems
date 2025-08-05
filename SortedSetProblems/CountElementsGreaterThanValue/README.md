# Count Elements Greater Than a Value - C#

This C# console application counts how many elements in a `SortedSet<int>` are greater than a specified value.

---

## ✅ Features
- Uses a **SortedSet<int>** for automatic ordering.
- Efficiently gets all elements **greater than a given value**.
- Uses built-in method `GetViewBetween` for performance.
- Simple, clean, and well-commented C# logic.

---

## 🧠 How It Works

### 1. `CountGreaterThan(SortedSet<int> set, int value)`
- Uses `set.GetViewBetween(value + 1, int.MaxValue)` to create a view of all elements **strictly greater** than the specified value.
- Returns the count of that view using `.Count()`.

### 2. `Main()`
- Initializes a `SortedSet` with example values `{1, 2, 3, 4, 5}`.
- Sets a `value = 3`.
- Calls `CountGreaterThan(set, value)` and prints the result.
- Waits for user input before closing the console.

---

## 🖥 Example Output
```
2
```
> Explanation: Elements greater than `3` in the set are `4` and `5`.

---

## ▶️ How to Compile and Run

### Compile:
```bash
csc Program.cs
```

### Run:
```bash
Program.exe
```

> Or run via Visual Studio / Visual Studio Code with .NET Framework 4.7.2+

---

## 📦 Requirements
- .NET Framework or .NET SDK
- C# compiler (e.g., `csc.exe`) or IDE like Visual Studio

---

## 👤 Author
Mohamed Mostafa  
🎯 Educational example to learn how to filter and count elements in C# collections
