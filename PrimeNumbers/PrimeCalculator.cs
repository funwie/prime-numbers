using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeCalculator
    {
        public static async Task<IEnumerable<long>> FindPrimesAsync(long number)
        {
            var primes = new List<long>();

            if (number < 2)
            {
                return primes;
            }

            if (number == 2)
            {
                primes.Add(2);
                return primes;
            }

            if (number == 3)
            {
                primes.Add(2);
                primes.Add(3);
                return primes;
            }

            primes.Add(2);
            primes.Add(3);

            for (long i = 4; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static bool IsPrime(long number)
        {
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
