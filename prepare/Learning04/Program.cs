using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment sampleO = new Assignment("Samuel Bennett","Multiplication");
        string sampleSummary = sampleO.GetSummary();
        Console.WriteLine($"{sampleSummary}");

        MathAssignment sample02 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string secondSummary = sample02.GetSummary();
        Console.WriteLine(secondSummary);
        Console.WriteLine(sample02.GetHomeworkList());

        WritingAssignment sample03 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string thirdSummary = sample03.GetSummary();
        Console.WriteLine(thirdSummary);
        Console.WriteLine(sample03.GetWritingInformation());
    }
}