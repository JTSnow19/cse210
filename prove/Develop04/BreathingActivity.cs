public class BreathingActivity: Activity
{
    

    public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {
        
        
    }
       
    
    public void Run(){
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(Duration);
        do{
        
        Console.WriteLine("Breathe in...");
        ShowCountDownSeconds(5);
        Console.WriteLine("");
        Console.WriteLine($"Breathe out....");
        ShowCountDownSeconds(6);
        startTime = DateTime.Now; //I just placed these around to ensure the current time is updating
        } while (startTime<= endTime);
        DisplayEndingMessage();
    }
}