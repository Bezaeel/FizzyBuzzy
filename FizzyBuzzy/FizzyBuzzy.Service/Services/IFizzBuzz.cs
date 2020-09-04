using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FizzyBuzzy.Service.Services
{
    public interface IFizzBuzz
    {
        Task<string> GenerateFizzBuzz(int value);
    }
}
