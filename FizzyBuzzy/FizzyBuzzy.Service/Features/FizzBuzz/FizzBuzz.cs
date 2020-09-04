using FizzyBuzzy.Service.Communication;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FizzyBuzzy.Service.Features.FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly ILogger _logger;
        private ServiceResponse response;
        public FizzBuzz(ILogger<FizzBuzz> logger)
        {
            _logger = logger;
            response = new ServiceResponse();
        }
        public async Task<ServiceResponse> GenerateFizzBuzz(int num)
        {
            try
            {
                response.IsSuccess = true;
                bool fizz = num % 3 == 0;
                bool buzz = num % 5 == 0;
                if (fizz && buzz)
                {
                    response.Message = "FizzBuzz";
                }
                else if (fizz)
                {
                    response.Message = "Fizz";
                }
                else if (buzz)
                {
                    response.Message = "Buzz";
                }
                else
                {
                    response.Message = num.ToString();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex.ToString()}");
                response.IsSuccess = false;
                response.Message = "Error occurred";
            }
            return response;
        }
    }
}
