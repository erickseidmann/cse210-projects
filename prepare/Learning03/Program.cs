using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction calculate_fraction1 = new Fraction(11, 12);
        Console.WriteLine(calculate_fraction1.GetFractionString());
        Console.WriteLine(calculate_fraction1.GetDecimalValue());

        Fraction calculate_fraction2 = new Fraction(18);
        Console.WriteLine(calculate_fraction2.GetFractionString());
        Console.WriteLine(calculate_fraction2.GetDecimalValue());

        Fraction calculate_fraction3 = new Fraction(9, 3);
        Console.WriteLine(calculate_fraction3.GetFractionString());
        Console.WriteLine(calculate_fraction3.GetDecimalValue());

    }
}