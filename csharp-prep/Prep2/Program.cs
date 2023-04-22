using System;

class Program
{
    static void Main(string[] args)
    {
        //- create the question! atention with semicolon!!!!
        Console.Write("Hello, what is your name?");
        string name = Console.ReadLine();
        Console.Write($"{name}, what is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string letter = "";

        if ( percent >= 90 )
        {
            letter = "A";
        }
        // - here was my first error attention that it is different from python we can't use elif!!!
        else if ( percent >= 80)
        {
            letter = "B";
        }
        else if (percent >=70 )
        {
            letter = "C";
        }
        else if ( percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"{name}, your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine($"{name}, congratulations you passed!!!! ");
        }
        else
        {
            Console.WriteLine($"{name}, sorry but better luck next time!");
        }


    }
}