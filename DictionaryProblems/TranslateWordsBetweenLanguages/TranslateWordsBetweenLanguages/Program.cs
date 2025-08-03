using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateWordsBetweenLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store English-Spanish word translations
            Dictionary<string, string> translations = new Dictionary<string, string>()
            {
                {"Hello", "Hola" },     // English: Hello → Spanish: Hola
                {"World", "Mundo" },    // English: World → Spanish: Mundo
                {"Goodbye", "Adios" }   // English: Goodbye → Spanish: Adios
            };

            // Print the Spanish translation for "Hello"
            Console.WriteLine($"Hello in Spanish: {translations["Hello"]}");

            // Print the Spanish translation for "Goodbye"
            Console.WriteLine($"Goodbye in Spanish: {translations["Goodbye"]}");

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
