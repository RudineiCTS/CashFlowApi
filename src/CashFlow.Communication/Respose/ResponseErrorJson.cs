using System;
using System.Collections.Generic;
using System.Text;

namespace CashFlow.Communication.Respose
{
    public class ResponseErrorJson
    {
        public string ErrorMessage { get; set; } = string.Empty;
        
        public ResponseErrorJson(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
