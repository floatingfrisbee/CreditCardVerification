using System;
using CreditCardUtils.Enumerations;

namespace CreditCardUtils
{
    public class CreditCardInfo : ICreditCardInfo
    {
        public CreditCardInfo(CreditCardTypes creditCardType, string creditCardNumber, string cVV2Number, DateTime expirationDate)
        {
            Type = creditCardType;
            CreditCardNumber = creditCardNumber;
            Cvv2Number = cVV2Number;
            ExpirationDate = expirationDate;
        }

        public CreditCardTypes Type { get; private set; }  
        public string CreditCardNumber { get; private set; }
        public string Cvv2Number { get; private set; }
        public DateTime ExpirationDate { get; private set; }
    }
}
