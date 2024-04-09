public class Game
{
    private Dictionary<string, int> _playerTeam;
    private List<string> _opponent;

    public bool Outcome(){
        foreach(item in hitsEffective){
            if item in opponentWeakness{
                return true;
            }
        }
        return false;

    } //pokemon perma die because that sounds fun

    public int SelectedForBattle(){

        Console.Write(": ");
        string x = Console.ReadLine();
        int theSelectedPokemon  = int.Parse(x);

        theSelectedPokemon --;
        return theSelectedPokemon;
    }
    public void Battle(){//determine an outcome

    RandomBattle(opponent)
    battleBool = Outcome(enemy)
    if (battleBool == false){
        Console.WriteLine("Your pokemon has been vanquished");
        Console.WriteLine("1. Continue?");
        Console.WriteLine("2. Flee");
        Console.Write(":");
    }
    else{
        Console.WriteLine("You continue your climb of the poke-tower");
    }


    }

}