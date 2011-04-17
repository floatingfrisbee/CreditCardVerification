namespace CreditCardUtils
{
    public interface ICreditCardAuthorizationRequest
    {
        string FirstName { get; }
        string LastName { get; }
        ICreditCardInfo CreditCardInfo { get; }
        IAddressInfo AddressInfo { get; }
    }
}
