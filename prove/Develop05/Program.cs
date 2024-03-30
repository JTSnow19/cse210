using System;

class Program
{
    static void Main(string[] args)
    {
        string x;
        int choice;
        GoalManager goalManager = new GoalManager();
        do{
        Console.WriteLine("Options:");
        Console.WriteLine("1. Create a New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice: ");
        //x = Console.ReadLine(); faster method vvvv
        choice= int.Parse(Console.ReadLine());

        if (choice ==1){
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter choice: ");
            int goalType = int.Parse(Console.ReadLine());
            string selectedGoalType = "";

            if (goalType == 1){
                selectedGoalType = "SimpleGoal";
            }
            else if (goalType == 2){
                selectedGoalType = "EternalGoal";
            }
            else if (goalType == 3){
                selectedGoalType = "ChecklistGoal";
            }
            else{
                Console.WriteLine("Invalid Option");
                return;
            }

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            if (selectedGoalType == "ChecklistGoal"){
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goalManager.CreateGoal(selectedGoalType, name, description, points, target, bonus);
            }
            else{
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("Goal created successfully!");}
        else if (choice ==2){
            goalManager.ListGoalDetails();
        }
        else if (choice ==3){
            Console.WriteLine("Please Enter a name for the savefile");
            Console.Write(": ");
            x = Console.ReadLine();
            goalManager.SaveGoals(x);

            
        }
        else if (choice ==4){
            Console.Write("Enter filename to load goals: ");
            string loadFileName = Console.ReadLine();
            goalManager.LoadGoals(loadFileName);
        }
        else if (choice ==5){
            Console.Write("Enter the name of the goal to record an event for: ");
            string goalName = Console.ReadLine();
            goalManager.RecordEvent(goalName);
        }

        goalManager.DisplayPlayerInfo();
        



        } while (choice != 6);
}}