using System;

namespace PerfectNumberGenerator
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

            Console.WriteLine("Perfect numbers between {0} and {1}:", n1, n2);

            // Generate and print the perfect numbers in the specified range
            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Function to check if a number is perfect
        static bool IsPerfect(int n)
        {
            // Return false for any number less than 6
            if (n < 6) return false;

            // Keep track of the sum of the divisors
            int sum = 1;

            // Check if n is divisible by any number from 2 to the square root of n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // If the number is divisible, add both the divisor and the quotient to the sum
                if (n % i == 0)
                {
                    sum += i;
                    sum += n / i;
                }
            }

            // If the sum of the divisors is equal to the number, then the number is perfect
            return sum == n;
        }
    }
}
