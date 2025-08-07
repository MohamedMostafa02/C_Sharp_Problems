# 📈 Real-Time Stock Price Tracker – C# Console App

This is a simple C# console application that simulates a **real-time stock price tracker** using `ObservableCollection` and event handling. It prints a message whenever a stock price is **added** or **removed** from the collection.

## ✅ Features
- Uses `ObservableCollection<string>` to store stock prices.
- Responds to real-time changes in the collection using the `CollectionChanged` event.
- Displays messages in the console whenever a stock is added or removed.

## 🧠 How It Works
- The app creates an `ObservableCollection<string>` called `stockPrices`.
- It subscribes to the `CollectionChanged` event to monitor when:
  - New stock prices are added.
  - Existing stock prices are removed.
- Event handler uses `NotifyCollectionChangedAction` to determine the type of change and prints the result.

## 🖥 Example Output
New Stock Price Added: AAPL: 150.00  
New Stock Price Added: MSFT: 240.50  
Stock Price Removed: AAPL: 150.00

## ▶️ How to Compile and Run
1. Open Visual Studio.
2. Create a new **Console App (.NET Framework)** project.
3. Replace the contents of `Program.cs` with the provided code.
4. Press `Ctrl + F5` to run the project.

## 📦 Requirements
- .NET Framework
- C# compiler
- Visual Studio or any C# IDE

## 👤 Author
Mohamed Mostafa  
Basic console example for learning `ObservableCollection` and event handling.
