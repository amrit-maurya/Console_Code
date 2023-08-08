using System;

namespace PrimeNumberChecker
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
            Console.WriteLine("Welcome to the Prime Number Checker!");

            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine(number+ " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}
