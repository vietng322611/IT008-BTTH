using System;

namespace Bai05;

public static class Bai05
{
    public static string GetDayOfWeek(int day, int month, int year)
    {
        return DayOfWeek(day, month, year) switch
        {
            0 => "Sunday",
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            _ => "Error"
        };
    }
    
    static int DayOfWeek(int day, int month, int year)
    {
        int[] t = [0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4];
        year -= (month < 3) ? 1 : 0;
        
        return (year + year/4 - year/100 + year/400 + t[month-1] + day) % 7;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter day: ");
        ReadInput("Please enter an integer between 1 and 31: ", t => t is >= 1 and <= 31, out var d);
        
        Console.Write("Enter month: ");
        ReadInput("Please enter an integer between 1 and 12: ", t => t is >= 1 and <= 12, out var m);
        
        Console.Write("Enter year: ");
        ReadInput("Please enter an integer greater or equal 1: ", t => t >= 1, out var y);

        if (DateTime.TryParse($"{m}/{d}/{y}", out _))
            Console.WriteLine($"{d}/{m}/{y} is {Bai05.GetDayOfWeek(d, m, y)}");
        else
            Console.WriteLine("Input date is invalid");
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