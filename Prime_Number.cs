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
/*
When checking for the primality of a number num, we don't need to test divisibility by numbers greater than its square root.
This is because if num is not a prime number and has a divisor larger than its square root,
it must also have a corresponding divisor smaller than its square root.
So, by checking divisors up to the square root of num,
we cover all possible divisors and can determine whether num is prime or not efficiently.
Using Math.Sqrt(num) in the loop condition helps us avoid unnecessary iterations and makes the primality check more efficient.
We only need to iterate up to the square root of the number being checked,
which reduces the number of divisions we need to perform and speeds up the process.
*/
