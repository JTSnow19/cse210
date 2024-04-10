using System;

class Program
{
    static void Main(string[] args)
    {
        //I have such bad planning skills, I thought I had more DAYS LOL, time to program 4 my life
        string filename = "typeChart.csv";
        //string selForBattle;
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
        int gameOption;
        do{
        floor.roomStatus();
        floor.ClimbProgress();
        //Console.WriteLine($"{floor._floor}")
        Console.WriteLine("1. Battle");
        Console.WriteLine("2.Look at team");
        Console.WriteLine("3.Quit");
        string x = Console.ReadLine();
        gameOption = int.Parse(x);

        if (gameOption ==1){
             List<string> encounter = urTeam.ChosenMon();
             Console.WriteLine($"You encounter a wild {encounter[0]}");
             urTeam.ViewTeam(playerTeam);
             string selForBattle = gameBase.SelectedForBattle();
             bool Outcome = typeCalculator.Outcome(playerTeam,selForBattle,encounter);
             bool progressX = gameBase.Battle(Outcome, selForBattle);
             if (progressX){
                floor.IncreaseRoom();
            }
            if (!playerTeam.Any()){
                gameOption =gameBase.GameOver();
            }
        }
        else if (gameOption ==2){
                urTeam.ViewTeam(playerTeam);
            }
//
        //    floor.roomStatus();
        } while (gameOption!=3);
    }//
}