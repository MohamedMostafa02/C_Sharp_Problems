
# 🎟️ Ticketing System Simulation using Queue (C# Console App)

This is a basic C# console application that simulates a **ticketing system** using the **Queue** data structure.

## 📌 Description

In a real-world ticketing system (e.g., bank, hospital, customer service), tickets are issued in order and processed **First In, First Out (FIFO)**.  
This program mimics that behavior by issuing tickets and processing them using a `Queue<int>`.

## 🧠 Concepts Used

- `Queue<int>` to manage ticket numbers
- `Enqueue()` to issue (add) a new ticket
- `Dequeue()` to process (remove) the first ticket
- `Count` to check remaining tickets
- `string.Join()` to display all tickets still waiting

## 💻 Code Example

```csharp
Queue<int> q = new Queue<int>();

for(int i = 101; i <= 105; i++)
{
    q.Enqueue(i); // Issue ticket
    Console.WriteLine($"Ticket {i} is issued.");
}

Console.WriteLine("\nTicketing System Simulation Started...\n");

while(q.Count > 0)
{
    int ticket = q.Dequeue();
    Console.WriteLine($"Processing Ticket: {ticket}");

    if(q.Count > 0)
        Console.WriteLine("Remaining Tickets: " + string.Join(", ", q));
    else
        Console.WriteLine("No More Tickets in the Queue.");
}

Console.WriteLine("Ticketing System Simulation Ended.");
```

## 🧪 Sample Output

```
Ticket 101 is issued.
Ticket 102 is issued.
Ticket 103 is issued.
Ticket 104 is issued.
Ticket 105 is issued.

Ticketing System Simulation Started...

Processing Ticket: 101
Remaining Tickets: 102, 103, 104, 105

Processing Ticket: 102
Remaining Tickets: 103, 104, 105

...

Processing Ticket: 105
No More Tickets in the Queue.

Ticketing System Simulation Ended.
```

## 📁 Project Structure

```
TicketingSystemSimulation/
│
├── Program.cs       # Main program file
├── README.md        # This documentation file
```

## ✅ Requirements

- .NET Framework or .NET Core
- Any C# IDE (e.g., Visual Studio, VS Code)

---

You can extend this project by:
- Allowing dynamic ticket generation
- Adding service counters
- Including estimated wait time per ticket
