using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int y = 0;
        string x = "";
        do
        {
            Console.Write("Guess a Number");
            x = Console.ReadLine();
            y = int.Parse(x);
            if (y > number) {
                Console.WriteLine("Lower");
            }
            else if (y< number){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("CORRECTTTTTTTTTTTTTTT");
            }
        } while (y != number);
    }
}