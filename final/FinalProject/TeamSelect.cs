public class TeamSelect{

    public Dictionary<string, List<string>> TeamSelection(){//pick a team of 6 pokemon for maximum type coverage!
        List<string> pokeOptions = [];
        Dictionary<string, List<string>>finalTeam = new Dictionary<string, List<string>>();
        int count = 7; //can't ya tell I just love iterative countdowns? So simple yet effective for repetition and control of a loop
        do{
            List<string>a =ChosenMon();
            List<string>b =ChosenMon();
            List<string>c =ChosenMon();
            List<string>d =ChosenMon();
            List<string>e =ChosenMon();
            List<string>f =ChosenMon();

            Console.WriteLine($"{a}"); //I know there's a better way but my brain is frying
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
            Console.WriteLine($"{d}");
            Console.WriteLine($"{e}");
            Console.WriteLine($"{f}");

            

            Console.Write(":");
            string x = Console.ReadLine();
            int pokeChoice = int.Parse(x);

            if (pokeChoice== 1){
                pokeOptions = a;
            }
            else if (pokeChoice==2){
                pokeOptions =b;
            }
                        else if (pokeChoice==3){
                pokeOptions =c;
            }
                        else if (pokeChoice==4){
                pokeOptions =d;
            }
                        else if (pokeChoice==5){
                pokeOptions =e;
            }
                        else if (pokeChoice==6){
                pokeOptions =f;
            }
            else{
                Console.WriteLine("Stop being picky");
            }


            string keyCount = count.ToString();
            finalTeam.Add(keyCount, pokeOptions);
            count --;
        }while (count !=1);


        return finalTeam;
    }
    public Dictionary<string, List<string>> PokeList(){
        Dictionary<string, List<string>> pokeDictionary = new Dictionary<string, List<string>>();
        using (var csvReader = new StreamReader("pokedexX.csv"))
        {
            csvReader.ReadLine(); // Skip header row
            while (!csvReader.EndOfStream)
            {
                var line = csvReader.ReadLine();
                var parts = line.Split(',');
                var keyImportant = parts[0];
                var pokemonName = parts[1];
                var typeOne = parts[38];
                var typeTwo = parts[39];
                List<string> componentP = [pokemonName, typeOne, typeTwo];

                pokeDictionary[keyImportant] = componentP;


            }
        }
        return pokeDictionary;
    }
    public int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 1008);
    }
    public List<string> ChosenMon()
    {
        List<string> selected = new List<string>();
        int x = RandomNumber();
        foreach (var cMon in PokeList())
        {
            if (int.TryParse(cMon.Key, out int key) && key == x)
            {
                selected.AddRange(cMon.Value);
            }
        }
        return selected;
    }
}