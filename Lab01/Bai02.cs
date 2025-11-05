using System;

namespace Bai02;

public static class Bai02
{
    public static int SumPrimeUnderN(int n)
    {
        var sum = 0;
        for (var i = 2; i < n; i++) {
            if (Bai02.IsPrime(i))
                sum += i;
        }

        return sum;
    }
    
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = -1;
        Console.Write("Enter an integer: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
                if (n > 0) break;
            Console.Write("Please enter an integer greater than 0: ");
        }
        Console.WriteLine($"Sum of prime numbers smaller than {n}: " + Bai02.SumPrimeUnderN(n));
    }
}