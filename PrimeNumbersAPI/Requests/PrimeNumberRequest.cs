using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeNumbersAPI.Requests
{
    public class PrimeNumberRequest
    {
        [Required, Range(2, long.MaxValue)]
        public long Number { get; set; }
    }
}
