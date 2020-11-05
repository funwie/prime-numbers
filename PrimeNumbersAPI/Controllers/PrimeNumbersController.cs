using Microsoft.AspNetCore.Mvc;
using PrimeNumbersAPI.Requests;
using PrimeNumbersAPI.Services;
using System.Threading.Tasks;

namespace PrimeNumbersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly IPrimeNumberService _primeNumberService;

        public PrimeNumbersController(IPrimeNumberService primeNumberService)
        {
            _primeNumberService = primeNumberService;
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> GetPrimesAsync(PrimeNumberRequest numberRequest)
        {
            if (numberRequest == null) return new BadRequestObjectResult(numberRequest);

            var foundPrimes =  await _primeNumberService.GetPrimeNumbers(numberRequest.Number);

            return new JsonResult(foundPrimes);
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get(PrimeNumberRequest numberRequest)
        {
            var exampleRequest = new PrimeNumberRequest
            {
                Number = 100
            };

            return new JsonResult(exampleRequest);
        }
    }
}
