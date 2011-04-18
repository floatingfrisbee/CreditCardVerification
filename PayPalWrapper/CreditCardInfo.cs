using System;
using CreditCardUtils.Enumerations;

namespace CreditCardUtils
{
    public class CreditCardInfo : ICreditCardInfo
    {
        public CreditCardInfo()
        {}

        public CreditCardInfo(CreditCardTypes creditCardType, string creditCardNumber, string cVV2Number, DateTime expirationDate)
        {
            Type = creditCardType;
            CreditCardNumber = creditCardNumber;
            Cvv2Number = cVV2Number;
            ExpirationDate = expirationDate;
        }

        public CreditCardTypes Type { get; set; }  
        public string CreditCardNumber { get; set; }
        public string Cvv2Number { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
