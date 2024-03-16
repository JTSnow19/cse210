using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        //Ok, right now the program is a mess so im gonna break it down into what I know I have to do
        //#1 I need to take a string, (the selected scripture) and pass it into a format that turns it into a list
        //#2 The word list needs to randomly hide a set amount of words. I can probably use an if statement along with a -= variable to count how many words
        //#3 Return the string with "___" for the hidden words.

        // I really have not been enjoying how "set" the approaches are within the formatting guidelines. I write much more easily when I can deduce the 
        //problem myself. I UNDERSTAND that this is a valueble (valubal? Valubul? good thing im not an english major) method to learn encapsulation but it
        //does little to quell my frustration.

        int randomW = 3; 
        string input = "";
        while (input!= "quit"){
            Console.WriteLine("Would you like a random scripture? Or to quit?");
            Console.Write(": ");
            input = Console.ReadLine();


            Reference first = new Reference("john",17, 4);
            Scripture scripture1 = new Scripture(first, "I have glorified Thee on the earth; I have finished the work which Thou gavest Me to do.");

            Reference second = new Reference("Numbers",25, 2,3);
            Scripture scripture2 = new Scripture(second, "And they called the people unto the sacrifices of their gods, and the people ate and bowed down to their gods. And Israel joined himself unto Baal of Peor, and the anger of the Lord was kindled against Israel.");

            Reference third = new Reference("Genesis",6, 8);
            Scripture scripture3 = new Scripture(third, "But Noah found grace in the eyes of the Lord.");


            List<Scripture> randomS = [scripture1, scripture2, scripture3];
            Random randomGenerator = new Random();
            int indexNumber = randomGenerator.Next(0, 3);

            if (input!="quit"){
                randomS[indexNumber].HideRandomWords(randomW);
                Console.WriteLine(randomS[indexNumber].GetDisplayText());
                randomW +=1; // due to my misunderstanding I figured a simple increase will work, plus the randomness of each scripture adds difficulty
                //I bet it's possible to write a seperate program that adds every single line in all books and then the increase could be overkill
            }

            else {
                Console.WriteLine("Buh bye!");
                break;
            }

        }
        
    }
}