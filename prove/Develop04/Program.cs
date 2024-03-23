using System;

class Program
{
    static void Main(string[] args)
    {
        int choice; //assign variable early so I don't forget
        int durationI;
        string x;
        string durI;


        do{
        
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice: ");
        x = Console.ReadLine();
        choice= int.Parse(x);

        Console.Write("How long would you like to do this activity(seconds)?: ");
        durI= Console.ReadLine();
        durationI= int.Parse(durI);

        if (durationI <= 20){ //make sure adequate time is given
            choice =5;
        }
        

        if (choice ==1){
            //BreathingActivity.Run(); //note to self, fix syntax this is just place holder stuff
            BreathingActivity breath = new BreathingActivity("Breathing Activity","This activity is designed to give you a moment to clear your mind and to relax.",durationI);
            breath.Run();
        }
        else if (choice ==2){
            //ReflectingActivity.Run();
            List<string> quesList =
            [
                "Why was this experience meaningful to you?", //man I'm glad i organized all the strings first down below
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"

            ];
            List<string> promptList =
            [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            ];
            ReflectingActivity reflact = new ReflectingActivity("Reflecting Activity","This activity will give you a moment to reflect on past moments.",durationI,quesList,promptList);
            reflact.Run();
        }
        else if (choice ==3){
            //ListingActivity.Run();
            List<string> listingA =
            [
                "Who are people you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",
            ];
            ListingActivity listA = new ListingActivity("Listing Activity","This activity will help to showcase and remind of good things in your life by listing as much as possible within a certain area.",durationI,0,listingA);
            listA.Run();
        }
        else if(choice ==5){
            Console.WriteLine($"Please provide more time than{durationI}");
        }
        else{
            Console.WriteLine("Bye!");
        }




        } while (choice !=4);
    }




}

//just gonna place my strings for text here for easy access
//Reflection Start Qs(PROMPTS)

//"Think of a time when you stood up for someone else."
//"Think of a time when you did something really difficult."
//"Think of a time when you helped someone in need."
//"Think of a time when you did something truly selfless."


//Reflection End Qs


//"Why was this experience meaningful to you?"
//"Have you ever done anything like this before?"
//"How did you get started?"
//"How did you feel when it was complete?"
//"What made this time different than other times when you were not as successful?"
//"What is your favorite thing about this experience?"
//"What could you learn from this experience that applies to other situations?"
//"What did you learn about yourself through this experience?"
//"How can you keep this experience in mind in the future?"



//Listing Questions
//"Who are people you appreciate?"
//"What are personal strengths of yours?"
//"Who are people that you have helped this week?"
//"When have you felt the Holy Ghost this month?"
//"Who are some of your personal heroes?"

//Breathing Desc
//"This activity is designed to give you a moment to clear your mind and to relax."

//Reflection Desc
//"This activity will give you a moment to reflect on past moments."

//Listing Desc
//"This activity will help to showcase and remind of good things in your life by listing as much as possible within a certain area."