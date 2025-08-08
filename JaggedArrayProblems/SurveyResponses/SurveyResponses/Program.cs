using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyResponses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to store survey responses from 3 respondents
            // Each respondent has a variable number of answers (strings)
            string[][] surveyResponses = new string[3][];

            // Initialize responses for respondent 1 with 2 answers
            surveyResponses[0] = new string[] { "Yes", "No" };
            // Initialize responses for respondent 2 with 3 answers
            surveyResponses[1] = new string[] { "No", "Yes", "Yes" };
            // Initialize responses for respondent 3 with 1 answer
            surveyResponses[2] = new string[] { "Yes" };

            // Print the header for survey output
            Console.WriteLine("Survey Responses:");

            // Loop through each respondent in the jagged array
            for (int i = 0; i < surveyResponses.Length; i++)
            {
                // Print respondent number (index + 1 for human-readable)
                Console.WriteLine($"Respondent {i + 1}");

                // Loop through each response of the current respondent
                foreach (string response in surveyResponses[i])
                {
                    // Print each response followed by a space
                    Console.Write(response + " ");
                }

                // Move to the next line after printing all responses for this respondent
                Console.WriteLine();
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
