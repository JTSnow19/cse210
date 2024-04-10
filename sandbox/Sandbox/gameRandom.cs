public class GameRandom :Game{
    private List<string> _weaknesses;

    public GameRandom(){}
    public int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 1008);
    }

    public List<string> RandomBattle(Opponent){


        Console.WriteLine($"You encountered a wild {Opponent[1]}");
    }
	Dictionary<string, List<string>>SelectTeam(pokemonList){
        choice = 6;
        do{
            int a = RandomNumber();
        

        } while (choice!=0);
        return options;
    } //Adds a key number (for the RandomNumber)
}