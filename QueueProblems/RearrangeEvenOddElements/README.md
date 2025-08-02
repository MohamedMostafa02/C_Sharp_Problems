# Rearrange Even and Odd Elements in a Queue

This C# console application demonstrates how to **rearrange a queue** such that all even numbers come first followed by all odd numbers.

---

## 📌 Problem Statement

Given a queue of integers, your task is to:
- Extract all even numbers and enqueue them at the front.
- Then enqueue all odd numbers at the end.

---

## 🚀 Example

**Input Queue:**
```
1, 2, 3, 4, 5, 6
```

**Output Queue:**
```
2, 4, 6, 1, 3, 5
```

---

## 💡 How It Works

The program separates elements into two temporary queues:
- `even` → to hold even numbers.
- `odd` → to hold odd numbers.

Then it rebuilds the original queue by:
1. Enqueuing all elements from `even`.
2. Enqueuing all elements from `odd`.

---

## 🧠 Data Structures Used

- `Queue<int>` – For the main queue, even queue, and odd queue.

---

## 🧪 Sample Code Output

```csharp
Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
```

```bash
Output:
2, 4, 6, 1, 3, 5
```

---

## 🛠️ Technologies

- Language: **C#**
- Framework: **.NET Framework / .NET Core Console App**

---

## 📁 File Structure

```
RearrangeEvenOddElements/
│
├── Program.cs   // Main logic and execution
```

---

## ✅ Author

- **Mohamed Mostafa**
- GitHub: [MohamedMostafa02](https://github.com/MohamedMostafa02)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
