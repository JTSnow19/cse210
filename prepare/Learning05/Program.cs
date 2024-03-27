using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        var shapes = new List<Shape>
        {
            new Square("Yellow", 19.7),
            new Rectangle("Red", 8, 12),
            new Circle("Purple", 11.11)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}