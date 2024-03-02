using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your username: ");
            string x = Console.ReadLine();
            return x;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter a number: ");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            return y;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult( string name,  int rnumber)
        {
            Console.WriteLine($"{name}, the square of your number is {rnumber}");
        }



        DisplayWelcome();

        string op1 = PromptUserName();
        int opNHalf = PromptUserNumber();
        int op2 = SquareNumber(opNHalf);

        DisplayResult(op1, op2);
    }
}