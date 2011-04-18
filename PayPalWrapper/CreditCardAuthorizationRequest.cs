namespace CreditCardUtils
{
    public class CreditCardAuthorizationRequest : ICreditCardAuthorizationRequest
    {
        public CreditCardAuthorizationRequest()
        {}

        public CreditCardAuthorizationRequest(  string firstName, 
                                                string lastName, 
                                                CreditCardInfo creditCardInfo, 
                                                AddressInfo addressInfo)
        {
            FirstName = firstName;
            LastName = lastName;
            CreditCardInfo = creditCardInfo;
            AddressInfo = addressInfo;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CreditCardInfo CreditCardInfo { get; set; }
        public AddressInfo AddressInfo { get; set; }
    }
}