using System;

public class Job {
    //my first member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}