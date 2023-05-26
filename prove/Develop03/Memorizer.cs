using System;

class ScripMemorizer
{
    private Scripture _scripture;
    private string[] _wordsToHide;
    private int _wordIndex;
    private Random _random;
    private string _fullReference; 

    public ScripMemorizer(Scripture scripture, string fullReference)
    {
        _scripture = scripture;
        _wordsToHide = _scripture.GetWords();
        _wordIndex = 0;
        _random = new Random();
        _fullReference = fullReference; 
    }

    public void MemorizeScripture()
    {
        Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            HideWord();
        }
    }

    private void HideWord()
    {
        if (_wordIndex >= _wordsToHide.Length)
        {
            Console.WriteLine("All words have been hidden. Type 'quit' to exit.");
            return;
        }

        int randomIndex = _random.Next(_wordsToHide.Length - _wordIndex);
        string wordToHide = _wordsToHide[randomIndex];
        string hiddenWord = new string('_', wordToHide.Length);


        _scripture.ReplaceWord(wordToHide, hiddenWord);
        Console.Clear();
        Console.WriteLine(_fullReference);
        Console.WriteLine(_scripture.DisplayScripture());

        _wordsToHide[randomIndex] = _wordsToHide[_wordsToHide.Length - _wordIndex - 1];
        _wordIndex++;
    }
}