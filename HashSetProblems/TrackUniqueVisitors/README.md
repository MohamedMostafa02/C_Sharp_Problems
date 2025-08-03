# TrackUniqueVisitors

A simple C# console application that tracks the number of unique visitors using their IP addresses.

## Features
- Uses HashSet<string> to store IP addresses.
- Automatically prevents duplicate entries.
- Displays the total count of unique visitors.

## Example Code Behavior
- Adds three IP addresses: "192.168.1.1", "192.168.1.2", "192.168.1.2".
- The duplicate IP ("192.168.1.2") is ignored.
- Output will be:
  Unique Visitors: 2

## Code Overview
- A HashSet is used to store unique IP addresses.
- Duplicates are automatically ignored by the HashSet.
- The Count property is used to display the number of unique visitors.

## How to Run
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the application.
3. The console will display the number of unique visitors based on IPs added to the set.

## Author
Mohamed Mostafa
