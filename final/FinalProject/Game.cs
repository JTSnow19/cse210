public class Game
{
    private Dictionary<string, List<string>> _playerTeam;
    private List<string> _opponent;

    public Game(List<string>opponent, Dictionary<string, List<string>> playerTeam){
        _opponent = opponent;
        _playerTeam = playerTeam;
        
        
        }

    public bool Battle(bool battleBool, string key){//determine an outcome
        bool progress;
        progress = true; 
        if (battleBool == false){
            if (_playerTeam.ContainsKey(key))
                {
                    _playerTeam.Remove(key);
                }
            Console.WriteLine("Your pokemon has been vanquished");
            Console.WriteLine("1. Continue?");
            Console.WriteLine("2. Flee");
            Console.Write(":");
            string x = Console.ReadLine();
            int cfChoice  = int.Parse(x);
            if (cfChoice ==2){
                progress = false;
            }
        }
        else{
            Console.WriteLine("You continue your climb of the poke-tower");
            progress = true;
            //IncreaseFloor();
        }
        return progress;
    }

    
    public string SelectedForBattle(){
        //ViewTeam();
        Console.Write(": ");
        string theSelectedPokemon = Console.ReadLine();
        //int theSelectedPokemon  = int.Parse(x);

        //theSelectedPokemon --;
        return theSelectedPokemon;
    }
    public int GameOver(){
        Console.WriteLine("You are out of usable pokemon!");
        Console.WriteLine("You black out.");
        return 3;
    }
}