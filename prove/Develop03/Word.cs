public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden == true)
        {
            List<char> characters = _text.ToList();
            int numberOfCharacters = characters.Count;

            return new string('_', numberOfCharacters);
        }
        
        else
        {
            return _text;
        }
    }
}