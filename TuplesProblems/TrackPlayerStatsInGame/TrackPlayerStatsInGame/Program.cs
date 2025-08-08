using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackPlayerStatsInGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a tuple to store player stats with named fields
            // Name: player's name, Health: player's health points, Score: player's score
            var player = (Name: "Player", Health: 100, Score: 2000);

            // Print the player's stats by accessing the tuple's named elements
            Console.WriteLine($"Name: {player.Name}, Health: {player.Health}, Score: {player.Score}");

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
