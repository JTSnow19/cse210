public class Resume
{
    public string _memberName = "";
    public List<Job> _memberJob  = [];
    public Resume()
    {
    }
    public void DisplayResume()
    {
        Console.WriteLine($"{_memberName}; Worked at:");
    }
}