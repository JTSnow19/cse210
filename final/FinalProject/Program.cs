using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        string filename = "typeChart.csv";
        //string selectedMon = "pikachu";
        typeCalc typeCalculator = new typeCalc();
        Game gameBase =new Game();
        
        Dictionary<string, List<string>> defenseRelation = typeCalculator.typeChartDefense(filename);
        //ok, I got the type chart working which is nice
        //foreach (var kvp in defenseRelation)
        //{
        //    Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        //}
        while (playerTeam.Count != 6){ //iterates over the team creator


        } do;
    }
}