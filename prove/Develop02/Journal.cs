using System.IO;
public class Journal
{
    public List<Entry> _questionsL = new List<Entry>();
    //makes sense    ~|~

    public Journal()
    {
    }

    public void DisplayEntries(List<Entry> el)
    {
        foreach (Entry item in el)
            item.Display();
    }
    
    public void SaveEntry(string text)
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{text}");
        }
    }

    
    public void LoadEntry()
    {
                
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            Console.WriteLine($"{date}, {prompt}:");
            Console.WriteLine($"{entry}");
        }
    }
}