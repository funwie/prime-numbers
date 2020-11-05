using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNumbersAPI.Services
{
    public interface IPrimeNumberService
    {
        Task<IEnumerable<long>> GetPrimeNumbers(long number);
    }
}
