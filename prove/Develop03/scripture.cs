public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordList = text.Split(' ');
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                foreach (char letter in word.GetDisplayText())
                {
                    displayText += "_";
                }
                displayText += ' ';
            }
            else
            {
                displayText += word.GetDisplayText() + ' ';
            }
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}