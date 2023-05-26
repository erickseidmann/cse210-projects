using System;
using System.Text.RegularExpressions;

class Scripture
{
    private string _text;

    public Scripture(string text)
    {
        _text = text;
    }

    public string[] GetWords()
    {
        char[] delimiters = { ' ' };
        string[] words = _text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }

    public void ReplaceWord(string wordToReplace, string replacement)
    {
        string pattern = $@"\b{Regex.Escape(wordToReplace)}\b";
        _text = Regex.Replace(_text, pattern, replacement);
    }

    public void HideRandomWord()
    {
        string[] words = GetWords();

        if (words.Length == 0)
        {
            return;
        }

        Random random = new Random();
        int randomIndex = random.Next(words.Length);
        string wordToHide = words[randomIndex];

        ReplaceWord(wordToHide, new string('*', wordToHide.Length));
    }

    public string DisplayScripture()
    {
        string[] words = _text.Split(' ');
        string scriptureText = string.Join(" ", words);
        return scriptureText;
    }
}
