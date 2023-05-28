public class Reference
{
    // ---------------------------------variables----------------------------------------
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    // --------------------------------constructor----------------------------------------
    public Reference(string book, int chapter, int firstVerse, int lastVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    // ----------------------------------methods----------------------------------------

    public void Display() 
    {
        if (_lastVerse > 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }

    }


}