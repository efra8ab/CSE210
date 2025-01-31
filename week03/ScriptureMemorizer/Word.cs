using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
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

    public string GetDisplayText()
    {
        int letterCount = _text.Count(char.IsLetter);

        if (_isHidden)
        {
            string lines = new string('_', letterCount);
            return lines;
        }

        return _text;
    }
}
