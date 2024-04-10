using System;

class Program
{
    static void Main(string[] args)
    {
        //I have such bad planning skills, I thought I had more DAYS LOL, time to program 4 my life
        string filename = "typeChart.csv";
        //string selectedMon = "pikachu";
        typeCalc typeCalculator = new typeCalc();
        
        //Dictionary<string,List<string>> playerTeam = new Dictionary<string,List<string>>();

        Dictionary<string, List<string>> defenseRelation = typeCalculator.typeChartDefense(filename);
        Dictionary<string, List<string>> offenseRelation = typeCalculator.typeChartOffense(filename,defenseRelation);
        //Dictionary<string, List<string>> pokemonDict = gameBase.PokeList();
        //ok, I got the type chart working which is nice
        //foreach (var kvp in pokemonDict)
        //{
        //    Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        //}
        TeamSelect urTeam = new TeamSelect();
        Dictionary<string, List<string>> playerTeam = urTeam.TeamSelection();

        //while (playerTeam.Count != 6){ //iterates over the team creator
//
//
        //} do;

        Game gameBase =new Game(["25","pikachu","electric"],playerTeam);
        GameFloor floor = new GameFloor();
        ////Gameplay Loop
        //int gameOption;
        //do{
//
//
        //    Console.WriteLine("4.Look at team");
//
//
        //    else if gameOption ==4{
        //        gameBase.ViewTeam()
        //    }
//
        //    floor.roomStatus();
        //} while (gameOption!=3);
    }//
}