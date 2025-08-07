# Shopping Cart Observer - C# Console App

This is a simple C# console application that simulates a shopping cart using ObservableCollection<string> to automatically detect and respond to changes (Add, Remove, Replace) in the cart items.

## ✅ Features
- Automatically detects when an item is added to the cart.
- Automatically detects when an item is removed from the cart.
- Detects when an item is replaced (e.g., Mouse ➝ Keyboard).
- Demonstrates how to use the CollectionChanged event of ObservableCollection.

## 🧠 How It Works
- The shopping cart is represented by an ObservableCollection<string>.
- The CollectionChanged event is subscribed to, allowing the app to print messages whenever:
  - An item is added → NotifyCollectionChangedAction.Add
  - An item is removed → NotifyCollectionChangedAction.Remove
  - An item is replaced → NotifyCollectionChangedAction.Replace
- The event handler reads from e.NewItems and e.OldItems depending on the action.

## 🖥 Example Output
Item Added to cart: Laptop  
Item Added to cart: Mouse  
Item Replaced: Mouse with keyboard  
Item Removed from cart: Laptop

## ▶️ How to Compile and Run
1. Open the project in Visual Studio or any C# IDE.
2. Ensure the target framework is .NET Framework or .NET Core.
3. Build and run the project.
4. Observe the console output based on the item actions.

## 📦 Requirements
- .NET Framework or .NET Core SDK
- C# compatible IDE (e.g., Visual Studio)

## 👤 Author
Made with ❤️ for learning purposes by Mohamed Mostafa.
