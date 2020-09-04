using System;
using System.Collections.Generic;
using System.Text;

namespace FizzyBuzzy.Service.Communication
{
    public class ServiceResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ServiceResponse()
        {

        }
        public ServiceResponse(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }
    }
}
