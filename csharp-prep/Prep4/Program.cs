using System;
using System.IO.Compression;
using System.Numerics;
using System.Xml;

class Program

{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //I havent defined this many variables since I started python haha, cant wait for functions!
        int total = 0;

        int y = 0;
        string x = "";
        List<string> numLists = new List<string>();
        do
        {
            Console.Write("Add a Number(0 to quit)");
            x = Console.ReadLine();
            y = int.Parse(x);
            numLists.Add(x);
        } while (y !=0);
        foreach (string numList in numLists)
        {
            int a= int.Parse(numList);
            total += a;
            if (a > y){
                y = a;
            }
        }


        int avgCalc = numLists.Count;
        int average = total/avgCalc;

        Console.WriteLine($"Total(or sum): {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Biggest Number: {y}");
    }
}