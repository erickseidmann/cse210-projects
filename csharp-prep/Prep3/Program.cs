using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your name?");
        string name = Console.ReadLine();

        bool playAgain = true;

        while (playAgain)
        {

            Random generator = new Random();
            int numberM = generator.Next(1,101);

            int number = -1;

            while (number != numberM)
            {
                Console.Write($"{name} What is your guess for the Magic Number?");
                number = int.Parse(Console.ReadLine());
                if(numberM > number){
                    Console.WriteLine("Higher, try again");
                }
                else if (numberM < number){
                    Console.WriteLine("Lower, try again");
                }
                else
                {
                    Console.WriteLine($"{name}, you Guessed!");
                }
            }
            Console.WriteLine($"{name}, Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = playAgainInput == "yes";
        }

        Console.WriteLine("Thanks for playing! see you soon!!");

    }
}