# 🧮 Basic Calculator in C#

A simple C# console application that evaluates **mathematical expressions** containing:

- Integers
- Addition (`+`)
- Subtraction (`-`)
- Parentheses (`(` and `)`)

Supports **multi-digit numbers** and properly nested **parentheses**.

---

## ✅ Features

- Correct operator precedence (parentheses first)
- Handles white spaces
- Evaluates left-to-right for `+` and `-`
- Handles expressions like:
  ```
  1 + (2 - (3 + 4))
  ```

---

## 📘 Example

### ▶️ Input:
```csharp
"1 + (5 - 3)"
```

### 🔍 Evaluation:

1. Read `1` → result = 1  
2. See `+` → sign = +1  
3. Encounter `(` → push current result and sign  
4. Evaluate `5 - 3` inside parentheses = 2  
5. Pop sign and result, and combine: `1 + 2` = **3**

### ✅ Output:
```
3
```

---

## 🧠 How It Works (Algorithm Summary)

- Uses a **stack** to remember previous results and signs when entering parentheses.
- Uses:
  - `num` to build multi-digit numbers
  - `sign` to track current operation (`+1` or `-1`)
  - `result` to accumulate the total
- When `)` is found:
  - Inner result is calculated and multiplied by the saved sign.
  - Then added to the saved result.

---

## 📂 Project Structure

```
BasicCalculator/
├── Program.cs       // Contains the main logic and test case
```

---

## 🛠️ Technologies

- Language: **C#**
- Type: **.NET Console Application**
- No external libraries required

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Run the application.
3. Modify the expression string in `Main()` to test other expressions.

---

## 👨‍💻 Author

**Mohamed Mostafa**  

