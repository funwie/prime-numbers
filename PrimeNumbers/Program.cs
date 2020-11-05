using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (long.TryParse(args[0], out long validNumber))
                {
                    FindPrimes(validNumber);
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
        }

        private static void FindPrimes(long number)
        {
            if (number < 2)
            {
                Console.WriteLine("There are no prime numbers below 2");
                return;
            }

            if (number == 2)
            {
                Console.WriteLine(2);
            }

            if (number == 3)
            {
                Console.WriteLine(2);
                Console.WriteLine(3);
            }

            for (long i = 4; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPrime(long number)
        {
            var leastDivisible = (int)Math.Sqrt(number) - 1;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
