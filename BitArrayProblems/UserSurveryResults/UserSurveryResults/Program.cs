using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSurveryResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BitArray to store 5 survey responses (true = yes, false = no)
            BitArray surveyResponses = new BitArray(5);

            // Set individual responses for each user
            surveyResponses[0] = true;   // User 1: Yes
            surveyResponses[1] = false;  // User 2: No
            surveyResponses[2] = true;   // User 3: Yes
            surveyResponses[3] = true;   // User 4: Yes
            surveyResponses[4] = false;  // User 5: No

            // Loop through all responses and print them
            for (int i = 0; i < surveyResponses.Length; i++)
            {
                Console.WriteLine($"User {i + 1} Response: {surveyResponses[i]}");
            }

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
