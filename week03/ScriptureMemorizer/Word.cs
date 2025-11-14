public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() //Our boolean to hide words
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText() //Using the underscore to hide words
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}
