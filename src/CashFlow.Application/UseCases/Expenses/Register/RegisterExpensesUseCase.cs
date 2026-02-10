using CashFlow.Communication.Request;
using CashFlow.Communication.Respose;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpensesUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
        {
            Validate(request);

            return new ResponseRegisteredExpenseJson();
        }
        private void Validate(RequestRegisterExpenseJson request)
        {
            var validator = new RegisterExpenseValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(msg => msg.ErrorMessage).ToList();
                throw new ArgumentException();
            }
        }
    }
}
