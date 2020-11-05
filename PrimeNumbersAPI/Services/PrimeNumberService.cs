using PrimeNumbers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNumbersAPI.Services
{
    public class PrimeNumberService : IPrimeNumberService
    {
        public async Task<IEnumerable<long>> GetPrimeNumbers(long number)
        {
           return await PrimeCalculator.FindPrimesAsync(number);
        }
    }
}
