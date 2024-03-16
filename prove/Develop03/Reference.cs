public class Reference
{
    private string _book = "Genesis";
    private int _chapter = 1;

    private int _verse = 1;

    private int _endVerse = 0;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _verse= verse;
        _chapter =chapter;
    }
    
    public Reference(string book, int chapter, int StartVerse, int EndVerse)
    {
        _book = book;
        _verse= StartVerse;
        _endVerse= EndVerse;
        _chapter =chapter;
    }

    public string GetDisplayText()
    {   
        string txt = "";
        if (_endVerse ==0){
            txt = $"{_book} {_chapter}:{_verse}";
        }
        else{
            txt = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return txt;
    }
}