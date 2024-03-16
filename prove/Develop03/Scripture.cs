public class Scripture
{

    private Reference _reference;

    private List<Word> _words = [];
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); //found online cause I was struggling to split +append in this context
    }
    public void HideRandomWords(int numberToHide)
    {
        foreach (Word item in _words){
            if (numberToHide > 0){
                Random randomGenerator = new Random();
                int indexNumber = randomGenerator.Next(0, 5);
                if (indexNumber>=4){
                    item.Hide();   
                    numberToHide -=1;
                }
                else{
                    item.Show();
                }
            }
    }
    }
    public string GetDisplayText()
    {
        List<string> blank = [];
        string refT = _reference.GetDisplayText();
        foreach (Word item in _words){ //foreach is clutch
            string wordTXT = item.GetDisplayText(item._text);
            blank.Add(wordTXT);

        }
        string scriptT = string.Join(" ", blank);
        string displayT = $"{refT}: {scriptT}";
        return displayT;
    }

    public bool IsCompletelyHidden() //I misunderstood this piece, but considering how my system resets hidden/shown words I'm not certain if this check is great
    // the randomness is generated every single time and each word has a 40% chance to be hidden, not perfectly of course as the system cascades down the list
    {
        foreach (Word item in _words){
            item.Hide();
        }
        return true;
    }

}