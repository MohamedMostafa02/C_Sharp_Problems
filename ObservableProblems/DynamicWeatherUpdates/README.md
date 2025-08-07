# Dynamic Weather Updates - C# Console App
This project demonstrates a simple real-time weather update system using ObservableCollection in C#. Whenever a new weather update is added, it is immediately printed to the console using the CollectionChanged event.

## ✅ Features
- Uses ObservableCollection<string> to store weather updates.
- Subscribes to collection changes to detect new additions.
- Displays each new weather update as it is added.

## 🧠 How It Works
- The app creates an ObservableCollection<string> called weatherUpdates.
- It subscribes to the CollectionChanged event to listen for added items.
- When a new weather update is added, it displays a message like:
  Weather Update: New York: Sunny, 25°

## 🖥 Example Output
Weather Update: New York: Sunny, 25°
Weather Update: London: Rainy, 15°

## ▶️ How to Compile and Run
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the project.
3. You’ll see weather updates appear in the console as they're added.

## 📦 Requirements
- .NET Framework or .NET Core
- C# language support
- Console application project

## 👤 Author
Mohamed Mostafa
