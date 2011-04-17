using System;
using CreditCardUtils.Enumerations;
using CreditCardUtils.Implementations;

namespace CreditCardUtils
{
    public class CreditCardProviderFactory
    {
        public static ICreditCardAuthorizationProvider Create(CreditCardGatewayProviders providerCode)
        {
            ICreditCardAuthorizationProvider provider = null;
              
            switch (providerCode)
            {
                case CreditCardGatewayProviders.PayPal:

                    provider = new PayPalAuthorizationProvider();

                    break;

                default:

                    throw new Exception("Invalid Provider Code");
            }

            return provider;
        }
    }
}
