class References
{
    private string _book;
    private int _chapter;
    private int _initialverse;
    private int _finalVerse;

    public References(string book, int chapter, int initialVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialverse = initialVerse;
        _finalVerse = finalVerse;
    }

    public References(string book, int chapter, int initialVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialverse = initialVerse;
        _finalVerse = 0;
    }
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetInitialVerse()
    {
        return _initialverse;
    }

    public int GetFinalVerse()
    {
        return _finalVerse;
    }

    public string returningString()
    {
        if (_finalVerse == 0)
        {
            return $"{_book} {_chapter}:{_initialverse} ";
        }
        else
        {
            return $"{_book} {_chapter}:{_initialverse}-{_finalVerse} ";
        }
    }


}