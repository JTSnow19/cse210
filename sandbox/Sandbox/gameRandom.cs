public class gameRandom :Game{

    public static int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 1009);
    }
    public List<string> teamSelection(){
        int count = 30;
        do{
            count --;
        }while (count !=1);


        return pokeOptions;
    }
}