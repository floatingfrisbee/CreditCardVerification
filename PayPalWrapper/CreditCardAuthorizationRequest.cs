namespace CreditCardUtils
{
    public class CreditCardAuthorizationRequest : ICreditCardAuthorizationRequest
    {
        public CreditCardAuthorizationRequest(  string firstName, 
                                                string lastName, 
                                                ICreditCardInfo creditCardInfo, 
                                                IAddressInfo addressInfo)
        {
            FirstName = firstName;
            LastName = lastName;
            CreditCardInfo = creditCardInfo;
            AddressInfo = addressInfo;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public ICreditCardInfo CreditCardInfo { get; private set; }
        public IAddressInfo AddressInfo { get; private set; }
    }
}