using System;

class Program
{
    static void Main(string[] args)
    {
        //tips never never push debug anaway that is going to use your old
        Console.Write("What is your First(1) name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        
        Console.WriteLine($"So your name is {last}, {first} {last}");
    }
}