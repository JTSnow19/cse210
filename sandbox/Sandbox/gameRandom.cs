public class GameRandom :Game{
    private List<string> _weaknesses;

    public GameRandom(){}
    public int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 1009);
    }
    public List<string> TeamSelection(){//pick a team of 6 pokemon for maximum type coverage!
        List<string> pokeOptions = [];
        int count = 5; //can't ya tell I just love iterative countdowns? So simple yet effective for repetition and control of a loop
        do{

            pokeChoice = Console.Parse();
            pokeOptions.Add();
            count --;
        }while (count !=1);


        return pokeOptions;
    }
    public list<string> RandomBattle(Opponent){


        Console.WriteLine($"You encountered a wild {Opponent[1]}");
    }
	Dictionary<string, List<string>>SelectTeam(){
        


        return options;
    } //Adds a key number (for the RandomNumber)
}