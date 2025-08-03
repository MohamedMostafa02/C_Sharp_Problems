using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSkillMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a HashSet of skills the candidate has
            HashSet<string> CandidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };

            // Create a HashSet of skills required for the job
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            // Use IntersectWith to keep only the skills that exist in both sets
            CandidateSkills.IntersectWith(jobRequirements);

            // Display the matching skills between the candidate and the job requirements
            Console.WriteLine("Matching Skills: " + string.Join(", ", CandidateSkills));

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
