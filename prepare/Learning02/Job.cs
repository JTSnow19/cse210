public class Job
{
    public string _jobCompany = "";
    public string _jobLocation = "";
    public string _jobTitle = "";
    public int _jobRate = 0;
    public Job()
    {
    }

    public void PayRate()
    {
        Console.WriteLine($"At a rate of ${_jobRate} an hour");
    }
    public void DisplayJobStats()
    {
        Console.WriteLine($"{_jobCompany}, {_jobLocation}, {_jobTitle}");
    }
}