using System;
using CreditCardUtils.Enumerations;

namespace CreditCardUtils
{
    public interface ICreditCardInfo
    {
        CreditCardTypes Type { get; }
        string CreditCardNumber { get; }
        string Cvv2Number { get; }
        DateTime ExpirationDate { get; }
    }
}
