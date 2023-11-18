public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_book} {_chapter}:{_verse} ";

        if (_endVerse > 0)
        {
            displayText += $"-{_endVerse} ";
        }
        
        return displayText;
    }
}