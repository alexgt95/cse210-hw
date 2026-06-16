public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    //Does it need this constructor like the one we saw in the first example from the reading?
    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}