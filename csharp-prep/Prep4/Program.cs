using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your name?");
        string name = Console.ReadLine();
        
        List<int> numbers = new List<int>();

        Console.WriteLine($"{name}, please enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write($"{name}, please Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        
        //I can't give a space between the information I'm still using Console.WriteLine(); to give the space I promise to solve this
        //Here I'm going to put the sum to average the largest number, be careful with the zero hahaha I made a mistake here
        numbers.Remove(0);
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine();
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);

        // Stretch challenges this time tested me but I think I did as asked
        List<int> positiveNumbers = numbers.Where(x => x > 0).ToList();
        int minPositive = positiveNumbers.Min();
        // You have to remove the zero if you don't get errors in this part, it took me a while to understand!
        Console.WriteLine("The smallest positive number is: " + minPositive);
        Console.WriteLine();
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}