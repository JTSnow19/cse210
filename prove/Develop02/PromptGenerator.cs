

public class PromptGenerator
{

    public List<string> _prompts = [];
    
    public string GetRandomPrompt(List<string> questions)
    {
        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, 4);
        string returnPrompt =questions[indexNumber];
        return returnPrompt;
    }


}