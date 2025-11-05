using System;
using System.Linq;

namespace Bai04;

public static class Bai04
{
    private static readonly int[] Month31 = [1, 3, 5, 7, 8, 10, 12];
    
    public static int GetNumDaysInMonth(int month, int year)
    {
        if (Month31.Contains(month))
            return 31;
        if (month != 2) return 30;
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            return 29;
        return 28;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter month: ");
        ReadInput("Please enter an integer between 1 and 12: ", t => t is >= 1 and <= 12, out var m);
        
        Console.Write("Enter year: ");
        ReadInput("Please enter an integer greater or equal 1: ", t => t >= 1, out var y);

        var numDays = Bai04.GetNumDaysInMonth(m, y);
        Console.WriteLine($"This month has {numDays} days");
    }
    
    static void ReadInput(string errorString, Func<int, bool> lambda, out int number)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (lambda(number)) return;
            }

            Console.Write(errorString);
        }
    }
}