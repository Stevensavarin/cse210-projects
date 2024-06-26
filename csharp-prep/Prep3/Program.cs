using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetFractionDecimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFractionDecimal());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetFractionDecimal());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetFractionDecimal());

        Console.Write("Insert top: ");
        string topInput = Console.ReadLine();
        int top = int.Parse(topInput);

        Console.Write("Insert bottom: ");
        string bottomInput = Console.ReadLine();
        int bottom = int.Parse(bottomInput);
        
        Fraction f5 = new Fraction();

        f5.SetTop(top);
        f5.SetBottom(bottom);

        Console.WriteLine();
        Console.WriteLine($"Top: {f5.GetTop()}");
        Console.WriteLine($"Bottom: {f5.GetBottom()}");
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetFractionDecimal());
    }
}