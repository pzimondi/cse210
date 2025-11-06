using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job instance
        Job firstJob = new Job();
        firstJob._jobTitle = "Web Developer";
        firstJob._company = "Netflix";
        firstJob._startYear = 2017;
        firstJob._endYear = 2020;

        // Create the second job instance
        Job secondJob = new Job();
        secondJob._jobTitle = "Full Stack Engineer";
        secondJob._company = "Spotify";
        secondJob._startYear = 2020;
        secondJob._endYear = 2023;

        // Create the third job instance
        Job thirdJob = new Job();
        thirdJob._jobTitle = "Lead Software Architect";
        thirdJob._company = "Meta";
        thirdJob._startYear = 2023;
        thirdJob._endYear = 2025;

        // Create a resume instance
        Resume professionalResume = new Resume();
        professionalResume._personName = "Munashe Zimondi";
        
        // Add the jobs to the resume's job list
        professionalResume._jobList.Add(firstJob);
        professionalResume._jobList.Add(secondJob);
        professionalResume._jobList.Add(thirdJob);

        // Display the complete resume
        professionalResume.ShowResume();
    }
}