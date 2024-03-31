

public class Scripture
{
    private Reference _reference; 
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] array = text.Split(new char[]{' ', ',', '.'},StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in array)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {
            int index;
            do
            {
                index = _random.Next(_words.Count);
            }
            while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string result = "";
        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i].GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}