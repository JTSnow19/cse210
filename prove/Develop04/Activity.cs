public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string desc, int duration){
        _description = desc;
        _name = name;
        _duration = duration;
    }
    protected int Duration{ //apparently there's this property called protected? Pretty cool: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    
        get { return _duration; }
        set { _duration = value; }
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"{_name}: {_description}");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"Well done! Thank you for your time and completing {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds){

        List<string> animationS = new List<string>();
        animationS.Add("|");
        animationS.Add("/");
        animationS.Add("-");
        animationS.Add("\\");
        animationS.Add("|");
        animationS.Add("/");
        animationS.Add("-");
        animationS.Add("\\");
        animationS.Add("|");
        animationS.Add("/");
        animationS.Add("-");
        animationS.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        do
        {

        foreach (string s in animationS){
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
           startTime = DateTime.Now;
        }
        } while (startTime<=endTime);


    }
    public void ShowCountDownSeconds(int seconds){
        do{
            Console.Write($"{seconds}");

            Thread.Sleep(1000);

            Console.Write("\b \b");
            
            seconds --;
        } while (seconds !=0);

    }
    //public bool actualTimer(){ I ended up scraping this, wanted to make a clean timer for everything but I cant get it to work
    //    DateTime startTime = DateTime.Now; 
    //    DateTime endTime = startTime.AddSeconds(Duration); //im so glad i found "protected" allows for some fun stuff
    //    do{
    //        Thread.Sleep(1001*Duration); 
    //    } while (endTime> startTime);
    //    return true;
    //}
}