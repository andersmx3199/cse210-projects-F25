public class Job
{
    // Attributes (_company, _jobTitle, _startYear, _endYear)
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // Behaviors (Display the information listed above)
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}