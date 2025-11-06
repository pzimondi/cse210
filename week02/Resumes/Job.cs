using System;

public class Job
{
    // Member variables for job details
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job()
    {
    }

    // Method to display job information in the format:
    // "Job Title (Company) StartYear-EndYear"
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}