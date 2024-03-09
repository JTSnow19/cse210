using System;


class Program
{
    static void Main(string[] args)
    {
        // idk why I am struggling to learn classes so bad, feels like my brain is overloading....
        List<string> prompts = new List<string>
        {
            "Was there a person you saw today that made the day better?",
            "Did you read your scriptures?",
            "How many glasses of water have you drank today?",
            "How many times have you wanted to smash this computer today?",
            "Did someone make your day today?"
        };

        PromptGenerator proG = new PromptGenerator();
        proG._prompts = prompts;

        List<Entry> entList = new List<Entry>(); //I miss python : (
        Journal theJ = new Journal();
        theJ._questionsL = entList;

        int inputF = 0;
        string entryS = ""; //I kept placing this in the wrong spot, and it would end up saving blank
        do
        {
            Console.WriteLine("Write (1)");
            Console.WriteLine("Display(2)");
            Console.WriteLine("Load(3)");
            Console.WriteLine("Save(4)");
            Console.WriteLine("Quit(5)");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out inputF))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            

            switch (inputF)
            {
                case 1: //had to swap from if else, statements cause I couldn't place it properly to recognize inputF being in the area
                    string chosenPrompt = proG.GetRandomPrompt(prompts);
                    Console.Write($"{chosenPrompt}: ");
                    string promptInput = Console.ReadLine();
                    Entry theEnt = new Entry
                    {
                        _date = dateText,
                        _entryText = promptInput,
                        _promptText = chosenPrompt
                    };
                    entList.Add(theEnt);
                    entryS = $"{dateText}, {chosenPrompt}, {promptInput}";
                    break;
                case 2:
                    theJ.DisplayEntries(entList);
                    break;
                case 3:
                    theJ.LoadEntry();
                    break;
                case 4:
                    theJ.SaveEntry(entryS);
                    break;
            }
        } while (inputF != 5);
    }
}
