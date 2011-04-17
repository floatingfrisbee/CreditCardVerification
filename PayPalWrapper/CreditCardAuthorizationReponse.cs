﻿namespace CreditCardUtils
{
    class CreditCardAuthorizationReponse : ICreditCardAuthorizationResponse
    {
        public CreditCardAuthorizationReponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; private set; }
    }
}
