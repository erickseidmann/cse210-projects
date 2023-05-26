using System;

class Program
{
    static void Main(string[] args)
    {
        References ref1 = new References("John", 3, 16, 16);
        keyWords kw1 = new keyWords("Loved");
        Scripture scr1 = new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        string keyWord = kw1.returningKeyword_1();
        string fullReference = ref1.returningString();
        string returningScripture = scr1.DisplayScripture();
        ScripMemorizer memorizer = new ScripMemorizer(scr1, fullReference);

        Console.WriteLine(keyWord);
        Console.Write(fullReference);
        Console.WriteLine(returningScripture);
        memorizer.MemorizeScripture();
    }
}
