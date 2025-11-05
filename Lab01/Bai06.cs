using System;

namespace Bai06;

public static class Bai06
{
    public static void Print2DArray(int[,] a, int n, int m)
    {
        if (m == 0 || n == 0) return;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
                Console.Write(a[i, j] + " ");
            Console.WriteLine();
        }
    }

    public static int FindMax(int[,] a, int n, int m)
    {
        var max = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
                max = max > a[i, j] ? max : a[i, j];
        }
        return max;
    }

    public static int FindMaxRow(int[,] a, int n, int m)
    {
        var max = 0;
        var maxRow = 0;
        for (var i = 0; i < n; i++)
        {
            var sum = 0;
            for (var j = 0; j < m; j++)
                sum += a[i, j];
            if (sum > max)
            {
                max = sum;
                maxRow = i;
            }
        }
        return maxRow;
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

    public static int SumNonPrime(int[,] a, int n, int m)
    {
        var sum = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
                if (IsPrime(a[i, j]))
                    sum += a[i, j];
        }

        return sum;
    }

    public static int[,] DeleteRow(int[,] a, ref int n, int m, int row)
    {
        var result = new int[n - 1, m];
        for (var i = 0; i < n; i++)
        {
            if (i == row - 1) continue;
            for (var j = 0; j < m; j++)
                if (i >= row) result[i - 1, j] = a[i, j];
                else result[i, j] = a[i, j];
        }

        n--;
        return result;
    }
    
    public static (int[,], int) DeleteMaxColumn(int[,] a, int n, ref int m)
    {
        var maxVal = 0;
        var maxColumn = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                if (a[i, j] <= maxVal) continue;
                maxVal = a[i, j];
                maxColumn = j;
            }
        }
        
        var result = new int[n, m - 1];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                if (j == maxColumn) continue;
                if (j > maxColumn) result[i, j - 1] = a[i, j];
                else result[i, j] = a[i, j];
            }
        }

        m--;
        return (result, maxColumn);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        ReadInput(out var n);
        Console.Write("Enter number of columns: ");
        ReadInput(out var m);
        
        var a = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
                a[i, j] = new Random().Next(-1000, 1000);
        }

        while (true)
        {
            var choice = AskChoice();
            int k;
            switch (choice)
            {
                case 1:
                    Bai06.Print2DArray(a, n, m);
                    break;
                case 2:
                    Console.WriteLine("Max value of the array is: " + Bai06.FindMax(a, n, m));
                    break;
                case 3:
                    Console.WriteLine("Row with biggest sum is row: " + (Bai06.FindMaxRow(a, n, m) + 1));
                    break;
                case 4:
                    Console.WriteLine("Sum of all non-prime values is: " + Bai06.SumNonPrime(a, n, m));
                    break;
                case 5:
                    if (m == 0 || n == 0)
                    {
                        Console.WriteLine("Array is empty");
                        break;
                    }
                    Console.Write($"Enter the row you want to delete (1 - {n}): ");
                    while (true)
                    {
                        ReadInput(out k);
                        if (k <= n) break;
                        Console.Write($"Please enter an integer from 1 to {n}: ");
                    }
                    a = Bai06.DeleteRow(a, ref n, m, k);
                    Console.WriteLine("New Array:");
                    Bai06.Print2DArray(a, n, m);
                    break;
                case 6:
                    if (m == 0 || n == 0)
                    {
                        Console.WriteLine("Array is empty");
                        break;
                    }
                    (a, k) = Bai06.DeleteMaxColumn(a, n, ref m);
                    Console.WriteLine("Column contain max value is: " + (k + 1) + "\nNew Array:");
                    Bai06.Print2DArray(a, n, m);
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
            Console.WriteLine("2. Find max value of the array");
            Console.WriteLine("3. Find row with the biggest sum");
            Console.WriteLine("4. Calculate sum of all non-prime values");
            Console.WriteLine("5. Delete k-th row of the array");
            Console.WriteLine("6. Delete column contain max value");
            Console.WriteLine("0. Quit");
            Console.Write("Enter your choice: ");
            int choice = Console.ReadKey().KeyChar;
            if (choice is < '0' or > '6')
            {
                Console.Clear();
                continue;
            }
            Console.WriteLine();
            return choice - '0';
        }
    }
    
    static void ReadInput(out int number)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
                if (number > 0) return;
            
            Console.Write("Please enter an integer greater than 0: ");
        }
    }
}