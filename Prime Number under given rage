using System;

namespace PrimeNumberPrinter
{
    public class Program
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Prime Number Printer!");

            Console.Write("Enter the lower bound of the range: ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the upper bound of the range: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + lowerBound +  " and " + upperBound + " :");
            
            for (int num = lowerBound; num <= upperBound; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
