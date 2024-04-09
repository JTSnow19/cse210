using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        //Oh boy, this is gonna be a lot
        //I may need to scrap the hud idea... thought there would be more resources... python diff
        string filename = "pokeInfo.csv";
        //string selectedMon = "pikachu";
        typeCalc typeCalculator = new typeCalc();
        
        Dictionary<string, List<string>> defenseRelation = typeCalculator.typeChartDefense(filename);
        Console.WriteLine(defenseRelation);



        //Console.WriteLine("Pick a pokemon:");
        //Console.WriteLine($"1. {selectedMon}");
        //Console.WriteLine($"2. {selectedMon}");
        //Console.WriteLine($"3. {selectedMon}");
        //Console.WriteLine($"4. {selectedMon}");
        //Console.WriteLine($"5. {selectedMon}");
        //Console.Write(":");
//
//
//
//
//
        //Console.WriteLine("Did you expect a Triple-A game?");

    }
}