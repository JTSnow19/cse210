public class ListingActivity: Activity
{
    
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts)
    : base(name, description, duration)
    {
        
        _prompts = prompts;
        _count = count;
    }
    public void Run(){
        DisplayStartingMessage();
        

        List<string> responseCount = GetListFromUser();
    
        Console.WriteLine($"Congratulations! You listed {responseCount.Count()} responses!"); 
        DisplayEndingMessage();


    }
    public void GetRandomPrompt(){
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        Console.WriteLine(_prompts[number]);
    }
    public List<string> GetListFromUser(){
        List<string> lFUser = new List<string>();
        string item;
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(Duration);
        do{   
            GetRandomPrompt();
            Console.Write(": ");
            item = Console.ReadLine();
            lFUser.Add(item);
            startTime = DateTime.Now; 
        } while (startTime<= endTime);

        return lFUser;
    }
}