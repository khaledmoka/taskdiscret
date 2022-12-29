using System;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the start and end of the range
            Console.Write("Enter the start of the range: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1}:", n1, n2);

            // Generate and print the prime numbers in the specified range
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Function to check if a number is prime
        static bool IsPrime(int n)
        {
            // Handle the edge case of n = 2
            if (n == 2) return true;

            // Return false for any number less than 2
            if (n < 2) return false;

            // Check if n is divisible by any number from 2 to the square root of n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            // If no divisors were found, then the number is prime
            return true;
        }
    }
}
