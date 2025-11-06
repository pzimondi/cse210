using System;
using System.Collections.Generic;

public class Resume
{
    // Member variable for the person's name
    public string _personName;
    
    // Member variable for the list of jobs
    // Initialize the list to a new List when declared
    public List<Job> _jobList = new List<Job>();

    // Constructor
    public Resume()
    {
    }

    // Method to display the resume details
    // Shows the person's name followed by all their jobs
    public void ShowResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        
        // Iterate through each Job in the list and display it
        foreach (Job position in _jobList)
        {
            // Call the DisplayJobDetails method on each job
            position.DisplayJobDetails();
        }
    }
}