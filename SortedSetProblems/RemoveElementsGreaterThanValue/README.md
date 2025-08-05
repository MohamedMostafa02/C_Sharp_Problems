# ✅ Remove Elements Greater Than a Value using SortedSet in C#

## 📄 Description
This C# console application demonstrates how to use `SortedSet<T>` and the `GetViewBetween` method to filter and retain only elements **less than or equal to a given value** from a sorted set.

---

## 🔧 Features
- Uses `SortedSet<int>` to automatically sort and store integers.
- Filters the set to only include values within a given range.
- Demonstrates the use of `GetViewBetween` for range queries.

---

## 💡 How It Works

1. A `SortedSet<int>` is initialized with values `{1, 2, 3, 4, 5}`.
2. The method `GetViewBetween(int.MinValue, 3)` is called to retrieve all elements from the minimum integer value up to 3 (inclusive).
3. The original set is replaced with this filtered view.
4. The resulting set `{1, 2, 3}` is printed to the console.

---

## 🧪 Example

**Input Set**:
```csharp
{ 1, 2, 3, 4, 5 }

Filtered Output (<= 3):

1, 2, 3


🧑‍💻 Author
Mohamed Mostafa

