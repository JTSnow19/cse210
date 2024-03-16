public class Word
{
    public string _text = "default";
    private bool _isHidden;
    public Word(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden(bool _isHidden)
    {
        return _isHidden;
    }
    public string GetDisplayText(string txt)
    {
        if (_isHidden == true){
            txt ="___";
        }
        else{
            txt = _text;
        }
        
        return txt;
    }
}