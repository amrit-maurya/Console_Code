using System;

public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        // Initialize the first two terms of the series
        int a = 0, b = 1;

        Console.Write("Fibonacci Series: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            // Calculate the next term by summing up the previous two terms
            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}
