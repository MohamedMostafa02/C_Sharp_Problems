# 🚦 Traffic Signal System Simulation using Queue (C# Console App)

This is a simple C# console application that simulates a **traffic signal system** using the **Queue** data structure.

## 📌 Description

In real-world traffic systems, vehicles pass through a signal one by one in the order they arrive — following a **First In, First Out (FIFO)** process.

This program demonstrates that by using a queue to represent vehicles waiting at a traffic signal. Each vehicle passes the signal one at a time, and the queue updates accordingly.

## 🧠 Concepts Used

- `Queue<string>` for vehicle management
- `Enqueue()` to add vehicles to the line
- `Dequeue()` to simulate a vehicle passing the signal
- `Count` to check how many vehicles are left
- `string.Join()` to display waiting vehicles

## 💻 Code Example

```csharp
Queue<string> q = new Queue<string>();

q.Enqueue("Car 1");
q.Enqueue("Truck 1");
q.Enqueue("Bike 1");
q.Enqueue("Bus 1");

Console.WriteLine("Traffic Signal Simulation Started....\n");

while (q.Count > 0)
{
    string Vehicle = q.Dequeue();
    Console.WriteLine(Vehicle + " has passed the signal.");

    if(q.Count > 0)
        Console.WriteLine("Vehicles Waiting: " + string.Join(", ", q));
    else
        Console.WriteLine("No vehicles waiting.");

    Console.WriteLine();
}

Console.WriteLine("Traffic Signal Ended.");
```

## 🧪 Sample Output

```
Traffic Signal Simulation Started....

Car 1 has passed the signal.
Vehicles Waiting: Truck 1, Bike 1, Bus 1

Truck 1 has passed the signal.
Vehicles Waiting: Bike 1, Bus 1

Bike 1 has passed the signal.
Vehicles Waiting: Bus 1

Bus 1 has passed the signal.
No vehicles waiting.

Traffic Signal Ended.
```

## 📁 Project Structure

```
TrafficSignalSystemSimulation/
│
├── Program.cs       # Main program file
├── README.md        # This documentation file
```

## ✅ Requirements

- .NET Framework or .NET Core
- Any C# IDE like Visual Studio or Visual Studio Code

---

You can extend this project by:
- Adding random vehicle arrivals
- Adding signal timers
- Supporting multiple lanes or directions
