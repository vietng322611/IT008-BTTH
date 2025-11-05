using System;

namespace Bai03;

public static class Bai03
{
    public static bool IsValidDate(int day, int month, int year)
    {
        return DateTime.TryParse($"{month}/{day}/{year}", out _);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter day: ");
        ReadInput(out var d);
        
        Console.Write("Enter month: ");
        ReadInput(out var m);
        
        Console.Write("Enter year: ");
        ReadInput(out var y);

        var isValid = Bai03.IsValidDate(d, m, y);
        if (isValid)
            Console.WriteLine($"{d}/{m}/{y} is valid");
        else
            Console.WriteLine($"{d}/{m}/{y} is invalid");
    }
    
    static void ReadInput(out int number)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
                return;
            
            Console.Write("Please enter an integer: ");
        }
    }
}