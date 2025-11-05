using System;

namespace Bai01;

public static class Bai01
{
    public static void GenerateArray(int n, out int[] a)
    {
        a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = new Random().Next(-1000, 1000);
    }

    public static void PrintArray(int[] a)
    {
        foreach (var t in a)
            Console.Write(t + " ");
        Console.WriteLine();
    }

    public static int OddSum(int[] a)
    {
        var sum = 0;
        foreach (var t in a)
        {
            if (t % 2 == 1)
                sum += t;
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

    public static int CountPrime(int[] a)
    {
        var count = 0;
        foreach (var t in a)
        {
            if (IsPrime(t))
                count++;
        }

        return count;
    }

    public static int MinSquareNumber(int[] a)
    {
        var minVal = -1;
        foreach (var t in a)
        {
            if (t < 0) continue;
            var tmp = Math.Sqrt(t);
            if ((int)Math.Floor(tmp) != (int)Math.Ceiling(tmp)) continue;
            if (minVal == -1 || minVal > tmp)
                minVal = t;
        }
        return minVal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
                if (n > 0) break;
            Console.Write("Please enter an integer greater than 0: ");
        }
        Console.Clear();

        Bai01.GenerateArray(n, out var a);

        while (true)
        {
            var choice = AskChoice();
            switch (choice)
            {
                case 1:
                    Bai01.PrintArray(a);
                    break;
                case 2:
                    Console.WriteLine("Sum of odd numbers: " + Bai01.OddSum(a));
                    break;
                case 3:
                    Console.WriteLine("Count of prime numbers: " + Bai01.CountPrime(a));
                    break;
                case 4:
                    Console.WriteLine("Smallest square number: " + Bai01.MinSquareNumber(a));
                    break;
                default:
                    return;
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static int AskChoice()
    {
        while (true)
        {
            Console.WriteLine("1. Print array");
            Console.WriteLine("2. Calculate sum of odd numbers in the array");
            Console.WriteLine("3. Count prime numbers in the array");
            Console.WriteLine("4. Find the smallest square number in the array");
            Console.WriteLine("0. Quit");
            Console.Write("Enter your choice: ");
            int choice = Console.ReadKey().KeyChar;
            if (choice is < '0' or > '4')
            {
                Console.Clear();
                continue;
            }
            Console.WriteLine();
            return choice - '0';
        }
    }
}