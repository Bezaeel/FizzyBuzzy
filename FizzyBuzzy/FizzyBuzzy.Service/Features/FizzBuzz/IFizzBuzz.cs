using FizzyBuzzy.Service.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FizzyBuzzy.Service.Features.FizzBuzz
{
    public interface IFizzBuzz
    {
        Task<ServiceResponse> GenerateFizzBuzz(int value);
    }
}
