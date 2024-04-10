public class Game
{
    private Dictionary<string, List<string>> _playerTeam;
    private List<string> _opponent;

    public Game(List<string>opponent, Dictionary<string, List<string>> playerTeam){
        _opponent = opponent;
        _playerTeam = playerTeam;
    }

    public bool Outcome(typeCalc tc, Dictionary<string, List<string>> off,Dictionary<string, List<string>> defense){
       string chosenMon=SelectedForBattle();
       List<string> opponentWeakness = tc.WeaknessList(off,defense,_opponent[1]);
        if (_playerTeam.ContainsKey(chosenMon)){
            List<string> hitsEffective = _playerTeam[chosenMon];

            // Assuming hitsEffective contains at least 3 elements
            foreach (var item in hitsEffective.GetRange(1, 2)) // Get elements at index 1 and 2
                {
                    if (opponentWeakness.Contains(item))
                    {
                        return true;
                    }
                }
        }
        else{
            return false};
            }
         //pokemon perma die because that sounds fun

    public void Battle(){//determine an outcome

   // RandomBattle(opponent)
   // battleBool = Outcome(enemy)
   // if (battleBool == false){
   //     Console.WriteLine("Your pokemon has been vanquished");
   //     Console.WriteLine("1. Continue?");
   //     Console.WriteLine("2. Flee");
   //     Console.Write(":");
   //     string x = Console.ReadLine();
   //     int cfChoice  = int.Parse(x);
   // }
   // else{
   //     Console.WriteLine("You continue your climb of the poke-tower");
   //     IncreaseFloor();
   // }
    static void ViewTeam(Dictionary<string,List<string>>z){
        foreach (var kvp in z)
        {
            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        }
    }

    }

    
    public string SelectedForBattle(){
        //ViewTeam();
        Console.Write(": ");
        string theSelectedPokemon = Console.ReadLine();
        //int theSelectedPokemon  = int.Parse(x);

        //theSelectedPokemon --;
        return theSelectedPokemon;
    }
}