using System.Reflection;

public class ReflectingActivity: Activity
{
    
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
    : base(name, description, duration)
    {
        _questions = questions;
        _prompts = prompts;   
    }
    public void Run(){
        string x; //I couldnt get the machine to give a moment to input so im trying this

        DisplayStartingMessage();
        DisplayPrompt();
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(Duration);
        Console.Write(": ");
        x = Console.ReadLine();
        Thread.Sleep(Duration*1000/5);
        do{
        DisplayQuestion();
        Console.Write(": ");
        x = Console.ReadLine();
        startTime = DateTime.Now;
        //Thread.Sleep(Duration*1000/5); my futile first attempt to slow down the flood of questions lol
        } while (startTime<= endTime);

        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count()-1);

        string prS = _prompts[number];

        return prS;
    }
        public string GetRandomQuestion(){
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _questions.Count()-1);

        string prS = _questions[number];

        return prS;
    }
    public void DisplayPrompt(){
        string dP = GetRandomPrompt();
        Console.WriteLine(dP);
        
    }
    public void DisplayQuestion(){
        string dP = GetRandomQuestion();
        Console.WriteLine(dP);
    }
}