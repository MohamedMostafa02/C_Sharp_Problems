# DynamicSkillMatching

A simple C# console application that compares a candidate's skills to job requirements and finds matching skills using HashSet.

## Features
- Uses HashSet<string> to store candidate skills and job requirements.
- Compares both sets using IntersectWith to find matching skills.
- Outputs matched skills to the console.

## Example Data
Candidate Skills: C#, SQL, JavaScript  
Job Requirements: C#, JavaScript, React

## Example Output
Matching Skills: C#, JavaScript

## Code Overview
- CandidateSkills and jobRequirements are defined as HashSet<string>.
- IntersectWith is used to modify CandidateSkills so it only contains skills also in jobRequirements.
- Matching skills are displayed using string.Join for clean formatting.

## How to Run
1. Open the project in Visual Studio or any C# IDE.
2. Build and run the project.
3. View the matching skills output in the console.

## Author
Mohamed Mostafa

